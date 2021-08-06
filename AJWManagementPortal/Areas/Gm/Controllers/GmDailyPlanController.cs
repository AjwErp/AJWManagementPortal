using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Gm.Controllers
{[Area("Gm")]
    public class GmDailyPlanController : Controller
    {
        //Get--Start---Daily Plan 
        public IActionResult GmDailyPlanList()
        {
            return View();
        }
        //Get--ended---Daily Plan 
        //POSt--Start---Daily Plan 
        //POSt--ended---Daily Plan 
    }
}
