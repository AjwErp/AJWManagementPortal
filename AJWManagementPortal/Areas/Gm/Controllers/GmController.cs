using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Gm.Controllers
{
    [Area("Gm")]
    public class GmController : Controller
    {
        public IActionResult GmDashboard()
        {
            return View();
        }
       

    }
}
