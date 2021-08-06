using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Ceo.Controllers
{
    [Area("Ceo")]
    public class CeoNoticeBoardController : Controller
    {
        //Get--Start---CeoNoticeBoardList---------------- 
        public IActionResult CeoNoticeBoardList()
        {
            return View();
        }
        //Get--ended---CeoNoticeBoardList------------- 
        //POSt--Start---CeoNoticeBoardList-------------- 
        //POSt--ended---CeoNoticeBoardList---------------- 
    }
}
