using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoadController : Controller
    {
        public IActionResult Loading()
        {
            return View();
        }
    }
}
