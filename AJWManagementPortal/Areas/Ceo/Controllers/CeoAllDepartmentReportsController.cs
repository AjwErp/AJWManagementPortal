using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Ceo.Controllers
{
    [Area("Ceo")]
    public class CeoAllDepartmentReportsController : Controller
    {
        //GET--Start---gm---CeoGmDepartmentReportsList----
        public IActionResult CeoGmDepartmentReportsList()
        {
            return View();
        }
        //GET--Ended---gm---CeoGmDepartmentReportsList----
        //POST--Start--gm----CeoGmDepartmentReportsList----
        //POST--Ended--gm----CeoGmDepartmentReportsList----

        //GET--Start---Account---AccountsBankCheckApprovalVoucherList----
        public IActionResult AccountsBankCheckApprovalVoucherList()
        {
            return View();
        }
        //GET--Ended---Account---AccountsBankCheckApprovalVoucherList----
        //POST--Start--Account----AccountsBankCheckApprovalVoucherList----
        //POST--Ended--Account----AccountsBankCheckApprovalVoucherList----
    }
}
