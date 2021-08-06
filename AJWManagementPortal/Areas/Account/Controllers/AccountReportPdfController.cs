using AJWManagementPortal.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Account.Controllers
{
    [Area("Account")]
    public class AccountReportPdfController : Controller
    {
        private readonly ApplicationDbContext _db;
        //private readonly IWebHostEnvironment _iwebhost;
        //IWebHostEnvironment iwebhost
        //                _iwebhost = iwebhost;

        public AccountReportPdfController(ApplicationDbContext db)
        {
            _db = db;

        }
        //GET --for AccountsPdfReports-- start
        public IActionResult AccountsPdfReports()
        {
            return View();
        }
        //GET --for AccountsPdfReports-- ended
        //POST --for AccountsPdfReports-- start
        //POST --for AccountsPdfReports-- ended

        //-------start------01---------------

        //1---GET for Daily Account Report --PDF--  
        public IActionResult DailyReportPdf()
        {
            return View();
        }
        //-GET ended  for Daily Account Report --PDF--  
        //-POST ended  for Daily Account Report --PDF--  
        //-POST ended  for Daily Account Report --PDF--  


        //2---GET for Monthly Account Report --PDF--  
        public IActionResult MonthlyReportPdf()
        {
            return View();
        }
        //-GET ended  for Monthly Account Report --PDF--  
        //-POST ended  for Monthly Account Report --PDF--  
        //-POST ended  for Monthly Account Report --PDF--  


        //--3---GET for Yearly Account Report --PDF--  
        public IActionResult YearlyReportPdf()
        {
            return View();
        }
        //-GET ended  for Yearly Account Report --PDF--  
        //-POST ended  for Yearly Account Report --PDF--  
        //-POST ended  for Yearly Account Report --PDF--  

        //--3---GET for AuditReportPdf Account Report --PDF--  
        public IActionResult AuditReportPdf()
        {
            return View();
        }
        //-GET ended  for AuditReportPdf Account Report --PDF--  
        //-POST ended  for AuditReportPdf Account Report --PDF--  
        //-POST ended  for AuditReportPdf Account Report --PDF--  


        //--3---GET for BankCheckApprovalVoucherPdf Account Report --PDF--  
        public IActionResult BankCheckApprovalVoucherPdf()
        {
            return View();
        }
        //-GET ended  for BankCheckApprovalVoucherPdf Account Report --PDF--  
        //-POST ended  for BankCheckApprovalVoucherPdf Account Report --PDF--  
        //-POST ended  for BankCheckApprovalVoucherPdf Account Report --PDF--


        //-------------------------Ended----------------------

    }
}
