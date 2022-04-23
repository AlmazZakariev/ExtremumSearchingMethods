using System;

namespace Optimizacia_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            var FH = new FunctionHandler("-12 -7 +1");
            var Extremum = new ExtremumSearching(FH.RegionA, FH.RegionB, 0.01, 0.2);
            Extremum.GoldenRatio(FH);
            var a = 2;
                

            //double ak = 0;
            //double bk = 10;
            //int k = 1;
            //double epsilon = 1;
            //double sigma = 0.2;
            //double Xkc = (ak + bk) / 2;
            //var L2k = Math.Abs(bk - ak);

            //method1(L2k, epsilon, Xkc, ak, bk);
            ////method2(L2k, epsilon, Xkc, ak, bk, sigma);
            ////method3(L2k, epsilon, Xkc, ak, bk);

        }
        //public static double function(double x)
        //{
        //    return 2 * x * x - 12 * x;
        //}
        //public static void method1(double L2k, double epsilon, double Xkc, double ak, double bk)
        //{
        //    while (L2k > epsilon)
        //    {
        //        // var Xkc = (ak + bk) / 2;

        //        var Fxkc = function(Xkc);
        //        var yk = ak + L2k / 4;
        //        var zk = bk - L2k / 4;
        //        var Fyk = function(yk);
        //        var Fzk = function(zk);
        //        if (Fyk < Fxkc)
        //        {
        //            bk = Xkc;
        //            Xkc = yk;

        //        }
        //        else if (Fyk > Fxkc)
        //        {
        //            if (Fzk > Fxkc)
        //            {
        //                ak = yk;
        //                bk = zk;
        //            }
        //            else if (Fzk < Fxkc)
        //            {
        //                ak = Xkc;
        //                Xkc = zk;

        //            }
        //        }
        //        L2k = Math.Abs(bk - ak);

        //    }
        //    Console.WriteLine("Метод деления отрезками пополам");
        //    Console.WriteLine(Xkc);
        //    Console.WriteLine(function(Xkc));
        //}
        //public static void method2(double L2k, double epsilon, double Xkc, double ak, double bk, double sigma)
        //{
        //    while (L2k > epsilon)
        //    {
        //        var yk = (ak + bk - sigma) / 2;
        //        var zk = (ak + bk + sigma) / 2;
        //        var Fyk = function(yk);
        //        var Fzk = function(zk);
        //        if (Fyk < Fzk)
        //        {
        //            bk = zk;
        //        }
        //        else if (Fyk > Fzk)
        //        {
        //            ak = yk;

        //        }


        //        L2k = Math.Abs(bk - ak);
        //    }
        //    Xkc = (ak + bk) / 2;
        //    Console.WriteLine("Метод дихотомии");
        //    Console.WriteLine(Xkc);
        //    Console.WriteLine(function(Xkc));
        //}
        //public static void method3(double L2k, double epsilon, double Xkc, double ak, double bk)
        //{
        //    while (L2k > epsilon)
        //    {
        //        var yk = ak + (3 - Math.Sqrt(5)) / 2 * (bk - ak);
        //        var zk = ak + bk - yk;
        //        var Fyk = function(yk);
        //        var Fzk = function(zk);
        //        if (Fyk < Fzk)
        //        {
        //            bk = zk;
        //            zk = yk;
        //            yk = ak + bk - yk;
        //        }
        //        else if (Fyk > Fzk)
        //        {
        //            ak = yk;
        //            yk = zk;
        //            zk = ak + bk - zk;
        //        }
        //        L2k = Math.Abs(bk - ak);
        //    }
        //    Xkc = (ak + bk) / 2;
        //    Console.WriteLine("Метод золотго сечения");
        //    Console.WriteLine(Xkc);
        //    Console.WriteLine(function(Xkc));
        //}
    }
}
