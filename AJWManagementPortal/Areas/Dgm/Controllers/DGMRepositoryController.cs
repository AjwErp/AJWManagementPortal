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

       
    }
}
