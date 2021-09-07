using Core;
using Core.Utils;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace SolutionTest
{
    public class Series
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ValidateSerieFibonacc()
        {
            var result = RunFunction.Run<bool>(GetRandomSeries);
            Assert.AreEqual(true, result.Successful);
        }

        bool GetRandomSeries()
        {
            return ValidateNumber(Functions.GetResultFibonacci(new Random().Next(8000)));
        }

        bool ValidateNumber(List<long> serie)
        {
            for (var position = 1; position < serie.Count - 1; position++)
                if ((serie[position - 1] + serie[position]) != serie[position + 1])
                    return false;
            return true;
        }
    }
}