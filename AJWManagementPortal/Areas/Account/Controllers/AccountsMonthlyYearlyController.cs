using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Account.Controllers
{
    [Area("Account")]
    public class AccountsMonthlyYearlyController : Controller
    {

        //GET --AccountsMonthlyYearlyReports--start----
        public IActionResult AccountsMonthlyYearlyReports()
        {
            return View();
        }
        //GET --AccountsMonthlyYearlyReports--ended----
        //POST --AccountsMonthlyYearlyReports--start----
        //POST --AccountsMonthlyYearlyReports--ended----


    }
}
