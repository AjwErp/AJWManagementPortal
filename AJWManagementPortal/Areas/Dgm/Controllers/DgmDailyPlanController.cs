using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Dgm.Controllers
{[Area("Dgm")]
    public class DgmDailyPlanController : Controller
    {
        //Get--Start---Daily Plan 
        public IActionResult DgmDailyPlanList()
        {
            return View();
        }
        //Get--ended---Daily Plan 
        //POSt--Start---Daily Plan 
        //POSt--ended---Daily Plan 
    }
}
