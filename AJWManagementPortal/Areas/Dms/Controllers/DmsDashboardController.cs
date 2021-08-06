using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Dms.Controllers
{
    [Area("Dms")]
    public class DmsDashboardController : Controller
    {
        public IActionResult DmsDashboard()
        {
            return View();
        }
    }
}
