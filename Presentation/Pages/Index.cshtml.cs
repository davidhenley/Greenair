﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Presentation.Helpers;
using Microsoft.AspNetCore.Http;

namespace Presentation.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        public string RouteFrom { get; set; }
        [BindProperty]
        public string RouteWhere { get; set; }
        [BindProperty]
        public string DepDate { get; set; }
        [BindProperty]
        public string ArrDate { get; set; }
        [BindProperty]
        public string NumAdults { get; set; }
        [BindProperty]
        public string NumChilds { get; set; }
        [BindProperty]
        public string FlightType { get; set; }

        //public List<FlightDetail> FlightSearch { get; set; }
        public string Msg { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            
        }
        public IActionResult OnPost()
        {
            
            return RedirectToPage("Flight");
        }
    }
}