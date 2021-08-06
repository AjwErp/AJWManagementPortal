using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Gm.Controllers
{
    [Area("Gm")]
    public class GmAllDepartmentReportsController : Controller
    {
        //GET--Start---gm---GmAccountsDepartmentReportsList----
        public IActionResult GmAccountsDepartmentReportsList()
        {
            return View();
        }
        //GET--Ended---gm---GmAccountsDepartmentReportsList----
        //POST--Start--gm----GmAccountsDepartmentReportsList----
        //POST--Ended--gm----GmAccountsDepartmentReportsList----

        //GET--Start---gm---GmDgmDepartmentReportsList----
        public IActionResult GmDgmDepartmentReportsList()
        {
            return View();
        }
        //GET--Ended---gm---GmDgmDepartmentReportsList----
        //POST--Start--gm----GmDgmDepartmentReportsList----
        //POST--Ended--gm----GmDgmDepartmentReportsList----
    }
}
