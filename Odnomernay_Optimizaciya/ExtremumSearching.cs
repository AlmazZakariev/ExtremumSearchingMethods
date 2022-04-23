using System;
using System.Collections.Generic;
using System.Text;

namespace Odnomernay_Optimizaciya
{
    class ExtremumSearching
    {
        public double A { get; set; }
        public double B { get; set; }
        public double Epsilon { get; }
        public double Sigma { get; }
        public double Xkc { get; set; }
        public double L2k { get; set; }
        public  double XResult { get; set; }
        public double YResult { get; set; }



        public ExtremumSearching(double a, double b, double epsilon, double sigma)
        {
            A = a;
            B = b;
            Epsilon = epsilon;
            Sigma = sigma;
            Xkc = (A + B) / 2;
            L2k = Math.Abs(B - A);
        }
        public ExtremumSearching(double epsilon, double sigma)
        {
            A = 0;
            B = 10;
            Epsilon = epsilon;
            Sigma = sigma;
            Xkc = (A + B) / 2;
            L2k = Math.Abs(B - A);
        }
        
        public void DivisionSegmentInHalf(FunctionHandler fh)
        {
            while (L2k > Epsilon)
            {               
                var Fxkc = fh.Function(Xkc);
                var yk = A + L2k / 4;
                var zk = B - L2k / 4;
                var Fyk = fh.Function(yk);
                var Fzk = fh.Function(zk);
                if (Fyk < Fxkc)
                {
                    B = Xkc;
                    Xkc = yk;
                }
                else if (Fyk > Fxkc)
                {
                    if (Fzk > Fxkc)
                    {
                        A = yk;
                        B = zk;
                    }
                    else if (Fzk < Fxkc)
                    {
                        A = Xkc;
                        Xkc = zk;
                    }
                }
                L2k = Math.Abs(B - A);
            }           
            XResult = Xkc;
            YResult = fh.Function(Xkc);
        }
        public void Dichotomy(FunctionHandler fh)
        {
            while (L2k > Epsilon)
            {
                var yk = (A + B - Sigma) / 2;
                var zk = (A + B + Sigma) / 2;
                var Fyk = fh.Function(yk);
                var Fzk = fh.Function(zk);
                if (Fyk < Fzk)
                {
                    B = zk;
                }
                else if (Fyk > Fzk)
                {
                    A = yk;
                }


                L2k = Math.Abs(B - A);
            }
            Xkc = (A + B) / 2;
            XResult = Xkc;
            YResult = fh.Function(Xkc);
        }
        public void GoldenRatio(FunctionHandler fh)
        {
            while (L2k > Epsilon)
            {
                var yk = A + (3 - Math.Sqrt(5)) / 2 * (B - A);
                var zk = A + B - yk;
                var Fyk = fh.Function(yk);
                var Fzk = fh.Function(zk);
                if (Fyk < Fzk)
                {
                    B = zk;
                    zk = yk;
                    yk = A + B - yk;
                }
                else if (Fyk > Fzk)
                {
                    A = yk;
                    yk = zk;
                    zk = A + B - zk;
                }
                L2k = Math.Abs(B - A);
            }
            Xkc = (A + B) / 2;
            XResult = Xkc;
            YResult = fh.Function(Xkc);
        }
    }
}
