using AJWManagementPortal.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Production.Controllers
{[Area("Production")]
    public class ProductionRepositoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        //private readonly IWebHostEnvironment _iwebhost;
        //IWebHostEnvironment iwebhost
        //                _iwebhost = iwebhost;

        public ProductionRepositoryController(ApplicationDbContext db)
        {
            _db = db;

        }
        public IActionResult DailyMonthlyYearlyAuditProductionReportsListRepository()
        {
            return View();
        }

        //Repository for ProductionDailyReportRepository  list
  
    }
}
