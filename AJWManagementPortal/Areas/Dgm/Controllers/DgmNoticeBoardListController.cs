using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Dgm.Controllers
{ [Area("Dgm")]
    public class DgmNoticeBoardListController : Controller
    {
        //Get--Start---DgmNoticeBoardList---------------- 
        public IActionResult DgmNoticeBoardList()
        {
            return View();
        }
        //Get--ended---DgmNoticeBoardList------------- 
        //POSt--Start---DgmNoticeBoardList-------------- 
        //POSt--ended---DgmNoticeBoardList---------------- 
    }
}

