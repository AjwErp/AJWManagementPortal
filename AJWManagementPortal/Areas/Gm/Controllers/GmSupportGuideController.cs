using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Gm.Controllers
{[Area("Gm")]
    public class GmSupportGuideController : Controller
    {
        //GET -start- for GmLawBookList
        public IActionResult GmLawBookList()
        {
            return View();
        }
        //GET -ended- for GmLawBookList
        //POST -start- for GmLawBookList
        //POST -ended- for GmLawBookList

        //GET -start- for GM LAW Book
        public IActionResult GmLawBook()
        {
            return View();
        }
        //GET -ended- for GM LAW Book
        //POST -start- for GM LAW Book
        //POST -ended- for GM LAW Book

        //GET -start- for GM User Guide Book
        public IActionResult GmUserGuide()
        {
            return View();
        }
        //GET -ended- for GM User Guide Book
        //POST -ended- for GM User Guide Book
        //POST -ended- for GM User Guide Book
    }
}
