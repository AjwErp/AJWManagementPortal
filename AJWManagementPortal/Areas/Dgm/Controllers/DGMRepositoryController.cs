using AJWManagementPortal.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Dgm.Controllers
{ [Area("Dgm")]
    public class DGMRepositoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        //private readonly IWebHostEnvironment _iwebhost;
        //IWebHostEnvironment iwebhost
        //                _iwebhost = iwebhost;

        public DGMRepositoryController(ApplicationDbContext db)
        {
            _db = db;

        }
        public IActionResult DailyMonthlyYearlyAuditDgmReportsListRepository()
        {
            return View();
        }

        //Repository for Daily cash continues report list
        public IActionResult DailyReportRepository()
        {
            return View();
        }
        //Repository for Daily cash continues report list
        //Monthly Accounts report repository
        public IActionResult MonthlyReportRepository()
        {
            return View();
        }
        //Monthly Accounts report repository
        //Yearly report Repository List
        public IActionResult YearlyReportRepository()
        {
            return View();
        }
        //Yearly report Repository List

        //Yearly report Repository List
        public IActionResult AccountsAuditReportsRepository()
        {
            return View();
        }
        //Yearly report Repository List
    }
}
