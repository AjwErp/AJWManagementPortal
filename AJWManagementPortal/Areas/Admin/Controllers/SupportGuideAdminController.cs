using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Admin.Controllers
{[Area("Admin")]
    public class SupportGuideAdminController : Controller
    {
        public IActionResult AdminLawBookList()
        {
            return View();
        }
        public IActionResult AdminLawBook()
        {
            return View();
        }

        public IActionResult AdminUserGuide()
        {
            return View();
        }
    }
}
