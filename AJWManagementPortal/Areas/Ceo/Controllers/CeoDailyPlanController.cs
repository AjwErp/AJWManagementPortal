using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Ceo.Controllers
{ [Area("Ceo")]
    public class CeoDailyPlanController : Controller
    {
        //Get--Start---Daily Plan 
        public IActionResult CeoDailyPlanList()
        {
            return View();
        }
        //Get--ended---Daily Plan 
        //POSt--Start---Daily Plan 
        //POSt--ended---Daily Plan 
    }
}
