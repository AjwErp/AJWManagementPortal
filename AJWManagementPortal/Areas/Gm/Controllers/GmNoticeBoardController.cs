using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Gm.Controllers
{[Area("Gm")]
    public class GmNoticeBoardController : Controller
    {
        //Get--Start---DgmNoticeBoardList---------------- 
        public IActionResult GmNoticeBoardList()
        {
            return View();
        }
        //Get--ended---DgmNoticeBoardList------------- 
        //POSt--Start---DgmNoticeBoardList-------------- 
        //POSt--ended---DgmNoticeBoardList---------------- 
    }
}
