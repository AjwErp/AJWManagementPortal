using AJWManagementPortal.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Dgm.Controllers
{
    [Area("Dgm")]
    public class DgmSupportGuideController : Controller
    {
        //GET -start- for DgmLawBookList
        public IActionResult DgmLawBookList()
        {
            return View();
        }
        //GET -ended- for DgmLawBookList
        //POST -start- for DgmLawBookList
        //POST -ended- for DgmLawBookList

        //GET -start- for DGM LAW Book
        public IActionResult DgmLawBook()
        {
            return View();
        }
        //GET -ended- for DGM LAW Book
        //POST -start- for DGM LAW Book
        //POST -ended- for DGM LAW Book

        //GET -start- for DGM User Guide Book
        public IActionResult DgmUserGuide()
        {
            return View();
        }
        //GET -ended- for DGM User Guide Book
        //POST -ended- for DGM User Guide Book
        //POST -ended- for DGM User Guide Book
    }
}
