using System;

namespace IntegralCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter mean:");
            double mean = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter standard deviation:");
            double deviation = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter lower bound of integral:");
            double lowerBound = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter upper bound of integral:");
            double upperBound = Convert.ToDouble(Console.ReadLine());

            double area = 0;
            double deltaX = 0.00001;
            for (double i = lowerBound; i < upperBound; i += deltaX)
            {
                area += NormalDistribution(i, mean, deviation) * deltaX;
            }

            Console.WriteLine("Area: " + area);
        }

        static double NormalDistribution(double x, double m, double d)
        {
            double number = Math.Exp(-0.5 * Math.Pow((x - m) / d, 2)) / (d * Math.Sqrt(2 * Math.PI));
            return number;
        }
    }
}
