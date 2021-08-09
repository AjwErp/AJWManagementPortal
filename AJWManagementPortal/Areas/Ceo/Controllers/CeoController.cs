using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Ceo.Controllers
{
    [Area("Ceo")]
    public class CeoController : Controller
    {
        //--GET--CEoDashboard---Start----
        public IActionResult CeoDashboard()
        {
            return View();
        }
        //--GET--CEoDashboard---Ended----
        //--POST--CEoDashboard---Start----
        //--POST--CEoDashboard---Eded----

    }
}
