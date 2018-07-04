using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numNum = new double[] { 1, 2, 3, 4, 5 };
            double[] numNumNum = new double[] { 3, 5, 7, 9, 11 };
            linearRegression linFit = new linearRegression(numNum, numNumNum);
            Console.WriteLine(linFit.XCoefficient);
            Console.WriteLine(linFit.intercept);
            Console.ReadLine();
        }

        static void testing( int[] x )
        {
            foreach (var item in x)
            {
                Console.WriteLine(item);
            }
        }
    }

    class linearRegression
    {
        public double intercept;
        public double XCoefficient;

        public linearRegression(double[] x, double[] y)
        {
            double meanX = mean(x);
            double meanY = mean(y);
            double covarience = 0;
            double varienceOfX = 0;

            foreach (var item in x)
            {
                varienceOfX += (item - meanX) * (item - meanX);
            }

            for (int i = 0; i < x.Length; i++)
            {
                covarience += (x[i] - meanX) * (y[i] - meanY);
            }

            XCoefficient = covarience / varienceOfX;
            intercept = meanY - XCoefficient * meanX;


        }

        private double mean(double[] x)
        {
            double sum = 0;
            int numberOfitems = 0;
            foreach (var item in x)
            {
                sum += item;
                numberOfitems++;
            }
            return sum / numberOfitems;
        }
    }
}
