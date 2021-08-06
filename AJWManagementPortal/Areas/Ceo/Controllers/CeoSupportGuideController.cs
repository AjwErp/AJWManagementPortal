using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Ceo.Controllers
{[Area("Ceo")]
    public class CeoSupportGuideController : Controller
    {
        //GET -start- for CeoLawBookList
        public IActionResult CeoLawBookList()
        {
            return View();
        }
        //GET -ended- for CeoLawBookList
        //POST -start- for CeoLawBookList
        //POST -ended- for CeoLawBookList

        //GET -start- for GM LAW Book
        public IActionResult CeoLawBook()
        {
            return View();
        }
        //GET -ended- for GM LAW Book
        //POST -start- for GM LAW Book
        //POST -ended- for GM LAW Book

        //GET -start- for GM User Guide Book
        public IActionResult CeoUserGuide()
        {
            return View();
        }
        //GET -ended- for GM User Guide Book
        //POST -ended- for GM User Guide Book
        //POST -ended- for GM User Guide Book
    }
}
