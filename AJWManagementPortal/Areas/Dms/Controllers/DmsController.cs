using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Dms.Controllers
{
    [Area("Dms")]
    public class DmsController : Controller
    {
        //GET --Dashboard DMS
        public IActionResult DmsDashboard()
        {
            return View();
        }

        //GET --LAW Book DMS
        public IActionResult DmsLawBook()
        {
            return View();
        }

        //GET --DmsUserGuide DMS
        public IActionResult DmsUserGuide()
        {
            return View();
        }

    }
}
