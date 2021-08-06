using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Dms.Controllers
{[Area("Dms")]
    public class NoticeBoardController : Controller
    {
        //GET--Start---5---NoticeBoardDms----start-----
        public IActionResult AJWNoticeBoardDms()
        {
            return View();
        }
        //GET--Ended---5---NoticeBoardDms-----ended----
        //POST--Start---5---NoticeBoardDms----start----
        //POST--Ended---5---NoticeBoardDms----ended----
    }
}
