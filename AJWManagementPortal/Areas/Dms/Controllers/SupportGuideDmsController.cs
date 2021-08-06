using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Dms.Controllers
{ [Area("Dms")]
    public class SupportGuideDmsController : Controller
    {

        //GET--Start---1---DmsLawBookList----start-----
        public IActionResult DmsLawBookList()
        {
            return View();
        }
        //GET--Ended---1---DmsLawBookList-----ended----
        //POST--Start---1---DmsLawBookList----start----
        //POST--Ended---1---DmsLawBookList----ended----

        //GET--Start---2---UserGuideDms----start-----
        public IActionResult DmsUserGuide()
        {
            return View();
        }
        //GET--Ended---2---UserGuideDms-----ended----
        //POST--Start---2---UserGuideDms----start----
        //POST--Ended---2---UserGuideDms----ended----

        //GET--Start---2---UserGuideDms----start-----
        public IActionResult DmsLawBook()
        {
            return View();
        }
        //GET--Ended---2---UserGuideDms-----ended----
        //POST--Start---2---UserGuideDms----start----
        //POST--Ended---2---UserGuideDms----ended----
    }
}
