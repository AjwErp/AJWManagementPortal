using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.HRM.Controllers
{[Area("Hrm")]
    public class HrmSupportGuideController : Controller
    {
        //GET -start- for HrmLawBookList
        public IActionResult HrmLawBookList()
        {
            return View();
        }
        //GET -ended- for HrmLawBookList
        //POST -start- for HrmLawBookList
        //POST -ended- for HrmLawBookList


        //GET -start- for Hrm LAW Book
        public IActionResult HrmLawBook()
        {
            return View();
        }
        //GET -ended- for Hrm LAW Book
        //POST -start- for Hrm LAW Book
        //POST -ended- for Hrm LAW Book

        //GET -start- for Hrm User Guide Book
        public IActionResult HrmUserGuide()
        {
            return View();
        }
        //GET -ended- for Hrm User Guide Book
        //POST -ended- for Hrm User Guide Book
        //POST -ended- for Hrm User Guide Book
    }
}
