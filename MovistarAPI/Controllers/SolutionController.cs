using Core;
using Core.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovistarAPI.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MovistarAPI.Controllers
{

    [ApiController]
    [Route("Solution")]
    public class SolutionController : Controller
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
