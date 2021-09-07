using System;
using System.Collections.Generic;

namespace Core
{
    public static class Functions
    {
        public static QuadraticFunctionResult GetResultQuadraticFunction(double valueA, double valueB, double valueC)
        {
            var valueToSqrt = Math.Abs(Math.Pow(valueB, 2) - (4 * valueA * valueC));
            double sqrt = Math.Sqrt(valueToSqrt);
            double firstSolution = (-valueB + sqrt) / (2 * valueA);
            double secondSolution = (-valueB - sqrt) / (2 * valueA);

            return new QuadraticFunctionResult()
            {
                FirstSolution = firstSolution,
                SecondSolution = secondSolution
            };
        }

        public static bool EvaluateQuadraticFunction(double valueA, double valueB, double valueC, double result)
        {
            double value = (valueA * Math.Pow(result, 2)) + (valueB * result);
            return -valueC == value;
        }

        public static List<long> GetResultFibonacci(int limit)
        {
            var serie = new List<long>() { 0, 1 };
            for (int position = 1; position < limit; position++)
            {
                var next = serie[position] + serie[position - 1];
                serie.Add(next);
            }
            return serie;
        }
    }
}
