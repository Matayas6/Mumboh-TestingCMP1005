using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculator;

namespace MyAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class MyCalcController : ControllerBase
    {
        [HttpGet]
        public double add(double NumberOne, double NumberTwo)
        {
            return Calculate.add(NumberOne, NumberTwo);
        }
        [HttpGet]
        public double multiply(double NumberOne, double NumberTwo)
        {
            return Calculate.multiply(NumberOne, NumberTwo);
        }
        [HttpGet]
        public double subtract(double NumberOne, double NumberTwo)
        {
            return Calculate.subtract(NumberOne, NumberTwo);
        }
        [HttpGet]
        public double divide(double NumberOne, double NumberTwo)
        {
            return Calculate.divide(NumberOne, NumberTwo);
        }
    }
}

