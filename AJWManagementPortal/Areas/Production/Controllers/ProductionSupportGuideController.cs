using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Production.Controllers
{[Area("Production")]
    public class ProductionSupportGuideController : Controller
    {
        //GET -start- for ProductionLawBookList
        public IActionResult ProductionLawBookList()
        {
            return View();
        }
        //GET -ended- for ProductionLawBookList
        //POST -start- for ProductionLawBookList
        //POST -ended- for ProductionLawBookList

        //GET -start- for Production LAW Book
        public IActionResult ProductionLawBook()
        {
            return View();
        }
        //GET -ended- for Production LAW Book
        //POST -start- for Production LAW Book
        //POST -ended- for Production LAW Book

        //GET -start- for Production User Guide Book
        public IActionResult ProductionUserGuide()
        {
            return View();
        }
        //GET -ended- for Production User Guide Book
        //POST -ended- for Production User Guide Book
        //POST -ended- for Production User Guide Book
    }
}
