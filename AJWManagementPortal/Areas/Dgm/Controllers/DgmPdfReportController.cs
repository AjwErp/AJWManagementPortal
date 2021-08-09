using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Dgm.Controllers
{[Area("Dgm")]
    public class DgmPdfReportController : Controller
    {
        //GET---DgmPdfReportList---start-----
        public IActionResult DgmPdfReportList()
        {
            return View();
        }
        //GET---DgmPdfReportList---ended-----
        //POST---DgmPdfReportList---start-----
        //POST---DgmPdfReportList---edned-----

        //GET--DgmDailyPdfReport---start
        public IActionResult DgmDailyPdfReport()
        {
            return View();
        }
        //GET---DgmDailyPdfReport---ended-----
        //POST---DgmDailyPdfReport---start-----
        //POST---DgmDailyPdfReport---edned-----

        //GET ---DgmMonthlyPdfReport---Start
        public IActionResult DgmMonthlyPdfReport()
        {
            return View();
        }
        //GET---DgmMonthlyPdfReport---ended-----
        //POST---DgmMonthlyPdfReport---start-----
        //POST---DgmMonthlyPdfReport---edned-----

        //GET ---DgmYearlyPdfReport---start---
        public IActionResult DgmYearlyPdfReport()
        {
            return View();
        }
        //GET---DgmYearlyPdfReport---ended-----
        //POST---DgmYearlyPdfReport---start-----
        //POST---DgmYearlyPdfReport---edned-----
    }

}
