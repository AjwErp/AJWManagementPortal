using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Dms.Controllers
{ [Area("Dms")]
    public class AjwNoticeBoardDmsController : Controller
    {
        //GET --for AjwNoticeBoardDms----start----
        public IActionResult AjwNoticeBoardDms()
        {
            return View();
        }
        //GET --for AjwNoticeBoardDms----ended----
        //POST --for AjwNoticeBoardDms----Start----
        //POST --for AjwNoticeBoardDms----ended----

    }
}
