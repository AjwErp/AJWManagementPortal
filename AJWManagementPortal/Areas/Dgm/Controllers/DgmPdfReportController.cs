using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Dgm.Controllers
{[Area("Dgm")]
    public class DgmPdfReportController : Controller
    {
        public IActionResult DgmPdfReportList()
        {
            return View();
        }

        public IActionResult DgmDailyPdfReport()
        {
            return View();
        }

        public IActionResult DgmMonthlyPdfReport()
        {
            return View();
        }

        public IActionResult DgmYearlyPdfReport()
        {
            return View();
        }
    }

}
