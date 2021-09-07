using Core;
using Core.Utils;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace MovistarSolution.Controllers
{
    [ApiController]
    [Route("Solution")]
    public class SolutionController : ControllerBase
    {
        [HttpGet]
        [Route("GetResultQuadraticFunction")]
        public GenericResponse<QuadraticFunctionResult> GetResultQuadraticFunction(double valueA, double valueB, double valueC)
        {
            return RunFunction.Run<QuadraticFunctionResult>(() => Functions.GetResultQuadraticFunction(valueA, valueB, valueC));
        }

        [HttpGet]
        [Route("GetResultFibonacci")]
        public GenericResponse<List<long>> GetResultFibonacci(int limit)
        {
            return RunFunction.Run<List<long>>(() => Functions.GetResultFibonacci(limit));
        }
    }
}
