using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Dgm.Controllers
{
    [Area("Dgm")]
    public class DgmController : Controller
    {
        public IActionResult DgmDashboard()
        {
            return View();
        }
      
    }
}
