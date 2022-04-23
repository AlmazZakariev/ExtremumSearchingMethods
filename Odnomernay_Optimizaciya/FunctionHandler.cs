using System;
using System.Collections.Generic;
using System.Text;

namespace Odnomernay_Optimizaciya
{
    class FunctionHandler
    {
        private double[] Coefficients { get; }
        private int MaxDegree { get; }
        public double RegionA { get; set; }
        public double RegionB { get; set; }
        public FunctionHandler(string coefficients)
        {
            
            Coefficients = ConvertStringToDouble(coefficients);
            MaxDegree = Coefficients.Length;
            RegionCalculation();
        }
        private double[] ConvertStringToDouble(string input)
        {
            var strings = input.Split(' ', (char)StringSplitOptions.None);
            double[] result = new double[strings.Length];
            for (int i = 0; i < strings.Length; i++)
            {
                result[i] = Convert.ToDouble(strings[i]);
            }
            return result;
        }
        public double Function(double x)
        {
            double result = 0;
            for (int i = 0; i < MaxDegree; i++)
            {
                result += Coefficients[i] * Math.Pow(x, i);
            }
            return result;
        }
        private void RegionCalculation()
        {
            double ak0 = 0;
            double bk0 = 0;
            double delta = 1;
            double[] xk = new double[10000];
            xk[0] = 1;
            double t = 1;
            var F0 = Function(xk[0] - t);
            var F1 = Function(xk[0]);
            var F2 = Function(xk[0] + t);
            var kCount = 2;
            var stepCount = 0;
            bool firstStep = false;
            if (F0 >= F1 && F1 >= F2 )
            {
                delta = t;
                ak0 = xk[0];
                xk[1] = xk[0] + t;
                stepCount++;            
                xk[2] = xk[1] + Math.Pow(2, stepCount) * delta;
            }
            else if (F0 <= F1 && F1 <= F2)
            {
                delta = -t;
                bk0 = xk[0];
                xk[1] = xk[0] - t;
                stepCount++;
                xk[2] = xk[1] + Math.Pow(2, stepCount) * delta;
            }
            else if (F0 >= F1 && F1 <= F0)
            {
                ak0 = xk[0] - t;
                bk0 = xk[0] + t;
                firstStep = true;
            }
            else if (F0 >= F1 && F1 <= F0)
            {
                Console.WriteLine("Функция не унимодальная");
                firstStep = true;
            }
            while (Function(xk[kCount]) < Function(xk[kCount - 1])&&!firstStep)
            {
                if (delta == t)
                {
                    ak0 = xk[kCount - 1];
                }
                else if (delta == -t)
                {
                    bk0 = xk[kCount];
                }
                stepCount++;
                kCount++;
                xk[kCount] = xk[kCount - 1] + Math.Pow(2, stepCount) * delta;
            }
            if (Function(xk[kCount]) >= Function(xk[kCount - 1])&&!firstStep)
            {
                if (delta == 1)
                {
                    bk0 = xk[kCount];
                }
                else
                {
                    ak0 = xk[kCount];
                }
            }
            
            RegionA =ak0;
            RegionB =bk0;
        }
    
    }
}
