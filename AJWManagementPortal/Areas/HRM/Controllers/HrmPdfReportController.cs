using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.HRM.Controllers
{ [Area("Hrm")]
    public class HrmPdfReportController : Controller
    {
        //private readonly ApplicationDbContext _db;
        //private readonly IWebHostEnvironment _iwebhost;
        //IWebHostEnvironment iwebhost
        //                _iwebhost = iwebhost;

        //public ProductiontPdfReportController(ApplicationDbContext db)
        //{
        //    _db = db;

        //}
        //GET --for HrmPdfReports-- start
        public IActionResult HrmPdfReports()
        {
            return View();
        }
        //GET --for HrmPdfReports-- ended
        //POST --for HrmPdfReports-- start
        //POST --for HrmPdfReports-- ended

        //-------start------01---------------

        //1---GET for HrmDailyReportPdf --PDF--  
        public IActionResult HrmDailyReportPdf()
        {
            return View();
        }
        //-GET ended  for HrmDailyReportPdf --PDF--  
        //-POST ended  for HrmDailyReportPdf --PDF--  
        //-POST ended  for HrmDailyReportPdf --PDF--  


        //2---GET for HrmMonthlyReportPdf --PDF--  
        public IActionResult HrmMonthlyReportPdf()
        {
            return View();
        }
        //-GET ended  for HrmMonthlyReportPdf --PDF--  
        //-POST ended  for HrmMonthlyReportPdf --PDF--  
        //-POST ended  for HrmMonthlyReportPdf --PDF--  


        //--3---GET for HrmYearlyReportPdf --PDF--  
        public IActionResult HrmYearlyReportPdf()
        {
            return View();
        }
        //-GET ended  for HrmYearlyReportPdf --PDF--  
        //-POST ended  for HrmYearlyReportPdf --PDF--  
        //-POST ended  for HrmYearlyReportPdf --PDF--  

        //--3---GET for HrmAuditReportPdf --PDF--  
        public IActionResult HrmAuditReportPdf()
        {
            return View();
        }
        //-GET ended  for HrmAuditReportPdf --PDF--  
        //-POST ended  for HrmAuditReportPdft --PDF--  
        //-POST ended  for HrmAuditReportPdf --PDF--  


        //-------------------------Ended----------------------
    }
}
