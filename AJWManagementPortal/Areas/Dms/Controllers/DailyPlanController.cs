using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Dms.Controllers
{
    [Area("Dms")]
    public class DailyPlanController : Controller
    {
        //GET--Start---5---DailyPlanDms----start-----
        public IActionResult AJWDailyPlanList()
        {
            return View();
        }
        //GET--Ended---5---DailyPlanDms-----ended----
        //POST--Start---5---DailyPlanDms----start----
        //POST--Ended---5---DailyPlanDms----ended----
    }
}
