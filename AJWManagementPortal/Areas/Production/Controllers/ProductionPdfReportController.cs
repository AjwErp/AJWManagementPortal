using AJWManagementPortal.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Production.Controllers
{[Area("Production")]
    public class ProductionPdfReportController : Controller
    {
        //private readonly ApplicationDbContext _db;
        //private readonly IWebHostEnvironment _iwebhost;
        //IWebHostEnvironment iwebhost
        //                _iwebhost = iwebhost;

        //public ProductiontPdfReportController(ApplicationDbContext db)
        //{
        //    _db = db;

        //}
        //GET --for ProductionPdfReports-- start
        public IActionResult ProductionPdfReports()
        {
            return View();
        }
        //GET --for ProductionPdfReports-- ended
        //POST --for ProductionPdfReports-- start
        //POST --for ProductionPdfReports-- ended

        //-------start------01---------------

        //1---GET for Daily Production Report --PDF--  
        public IActionResult ProductionDailyReportPdf()
        {
            return View();
        }
        //-GET ended  for Daily Production Report --PDF--  
        //-POST ended  for Daily Production Report --PDF--  
        //-POST ended  for Daily Production Report --PDF--  


        //2---GET for Monthly Production Report --PDF--  
        public IActionResult ProductionMonthlyReportPdf()
        {
            return View();
        }
        //-GET ended  for Monthly Production Report --PDF--  
        //-POST ended  for Monthly Production Report --PDF--  
        //-POST ended  for Monthly Production Report --PDF--  


        //--3---GET for Yearly Production Report --PDF--  
        public IActionResult ProductionYearlyReportPdf()
        {
            return View();
        }
        //-GET ended  for Yearly Production Report --PDF--  
        //-POST ended  for Yearly Production Report --PDF--  
        //-POST ended  for Yearly Production Report --PDF--  

        //--3---GET for AuditReportPdf Production Report --PDF--  
        public IActionResult ProductionAuditReportPdf()
        {
            return View();
        }
        //-GET ended  for AuditReportPdf Production Report --PDF--  
        //-POST ended  for AuditReportPdf Production Report --PDF--  
        //-POST ended  for AuditReportPdf Production Report --PDF--  


        //-------------------------Ended----------------------
    }
}
