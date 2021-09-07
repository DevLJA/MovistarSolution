using Core;
using Core.Utils;
using NUnit.Framework;
using System;

namespace SolutionTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CalculateQuadraticFunction()
        {
            var result = RunFunction.Run<bool>(EvaluateRandomQuadraticFunction);
            Assert.AreEqual(true, result.Result);
        }


        bool EvaluateRandomQuadraticFunction()
        {
            var valueA = 1;
            var valueB = -2;
            var valueC = -15;
            var result = Functions.GetResultQuadraticFunction(valueA, valueB, valueC);
            return Functions.EvaluateQuadraticFunction(valueA, valueB, valueC, result.FirstSolution) && Functions.EvaluateQuadraticFunction(valueA, valueB, valueC, result.SecondSolution);
        }

    }
}