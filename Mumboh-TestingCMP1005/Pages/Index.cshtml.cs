﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mumboh_TestingCMP1005.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public double Calculation
        {
            get; set;
        }

        public bool CalculationSet
        {
            get; protected set;
        } = false;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
        public void OnPost(double NumberOne, double NumberTwo, string logic)
        {

            switch (logic)
            {
                case "add":
                    Calculation = NumberOne + NumberTwo;
                    CalculationSet = true;
                    break;
                case "sub":
                    Calculation = NumberOne - NumberTwo;
                    CalculationSet = true;
                    break;
                case "mul":
                    Calculation = NumberOne * NumberTwo;
                    CalculationSet = true;
                    break;
                case "div":
                    Calculation = NumberOne / NumberTwo;
                    CalculationSet = true;
                    break;
                default:
                    break;
            }
        }
    }
}
