using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Dms.Controllers
{ [Area("Dms")]
    public class DmsAllDepartmentsController : Controller
    {
    //GET--Start---1---DmsAccountsDepartment----start-----
    public IActionResult DmsAccountsDepartment()
    {
        return View();
    }
        //GET--Ended---1---DmsAccountsDepartment-----ended----
        //POST--Start---1---DmsAccountsDepartment----start----
        //POST--Ended---1---DmsAccountsDepartment----ended----

        //GET--Start---2---DmsDgmDepartment----start-----
        public IActionResult DmsDgmDepartment()
        {
            return View();
        }
        //GET--Ended---2---DmsDgmDepartment-----ended----
        //POST--Start---2---DmsDgmDepartment----start----
        //POST--Ended---2---DmsDgmDepartment----ended----

        //GET--Start---3---DmsGmDepartment----start-----
        public IActionResult DmsGmDepartment()
        {
            return View();
        }
        //GET--Ended---3---DmsGmDepartment-----ended----
        //POST--Start---3---DmsGmDepartment----start----
        //POST--Ended---3---DmsGmDepartment----ended----

        //GET--Start---4---DmsCeoDepartment----start-----
        public IActionResult DmsCeoDepartment()
        {
            return View();
        }
        //GET--Ended---4---DmsCeoDepartment-----ended----
        //POST--Start---4---DmsCeoDepartment----start----
        //POST--Ended---4---DmsCeoDepartment----ended----

        //GET--Start---4---DmsProductionDepartment----start-----
        public IActionResult DmsProductionDepartment()
        {
            return View();
        }
        //GET--Ended---4---DmsProductionDepartment-----ended----
        //POST--Start---4---DmsProductionDepartment----start----
        //POST--Ended---4---DmsProductionDepartment----ended----

        //GET--Start---5---DmsAdminDepartment----start-----
        public IActionResult DmsAdminDepartment()
        {
            return View();
        }
        //GET--Ended---5---DmsAdminDepartment-----ended----
        //POST--Start---5---DmsAdminDepartment----start----
        //POST--Ended---5---DmsAdminDepartment----ended----

        //GET--Start---6---DmsHrmDepartment----start-----
        public IActionResult DmsHrmDepartment()
        {
            return View();
        }
        //GET--Ended---6---DmsHrmDepartment-----ended----
        //POST--Start---6---DmsHrmDepartment----start----
        //POST--Ended---6---DmsHrmDepartment----ended----
    }
}
