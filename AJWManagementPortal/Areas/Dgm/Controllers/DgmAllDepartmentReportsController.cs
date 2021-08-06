using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Dgm.Controllers
{
    [Area("Dgm")]
    public class DgmAllDepartmentReportsController : Controller
    {

        //GET--Start------AccountsDepartmentReportsList----
        public IActionResult DgmAccountsDepartmentReportsList()
        {
            return View();
        }
        //GET--Ended------AccountsDepartmentReportsList----
        //POST--Start------AccountsDepartmentReportsList----
        //POST--Ended------AccountsDepartmentReportsList----

    }
}
