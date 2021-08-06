using AJWManagementPortal.Data;
using AJWManagementPortal.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Account.Controllers
{
    [Area("Account")]
    public class DailyAccountReportController : Controller
    {

        private readonly ApplicationDbContext _db;
        DailyTransactionReportM DTReport = new DailyTransactionReportM();
        //private readonly IWebHostEnvironment _iwebhost;
        //IWebHostEnvironment iwebhost
        //                _iwebhost = iwebhost;

        public DailyAccountReportController(ApplicationDbContext db)
        {
            _db = db;

        }

        //GET--start---for All Daily Accounts Reports----- 
        public IActionResult AllDailyAccountsReports()
        {
            return View();
        }
        //GET--ended---for All Daily Accounts Reports----- 
        //POST--ended---for All Daily Accounts Reports----- 
        //POST--ended---for All Daily Accounts Reports----- 


        //GET- for index method
        public IActionResult Index()
        {
            return View();
        } 
        //ended--GET- for index method
        //POST- for index method
        //ended--POST- for index method
      
        //Get -1 for Daily Continue Report
        public IActionResult DailyContinueReport()
        {
            //string DCSId, string hide
            //DailyTransactionReportM.hide = Boolean.Parse(hide);
            //DailyTransactionReportM.hide = Boolean.Parse(hide);
            //if (DCSId == null)
            //{
            //    return NotFound();
            //}
            //DCSId = DCSId.Replace("-", "/");
            //DateTime dateTime10 = DateTime.Parse(DCSId);
            //DailyTransactionReportM.DCs = dateTime10;
            //DailyTransactionReportM.DailyContinueReportMs = _context.aDailyCashes.
            //    Where(z => z.ValueDate <= dateTime10)
            //    .ToList();

            //return View("Index", trans);

            return View();
        }
        //---1-Get-ended - for Daily Continue Report
        //POST -1 for Daily Continue Report
        //---1-POST-ended - for Daily Continue Report
     
        //Get -2 for Daily Transaction Report
        public IActionResult DailyTransactionReport()
        {
            return View();
        }
        //--2-Get-ended - for Daily Transaction Report
        //POST -2 for Daily Transaction Report
        //--2-POST-ended - for Daily Transaction Report
       
        //Get -3 for Daily Meezan bank income/Expence Report
        public IActionResult DailyMeezanBankIEReport()
        {
            return View();
        }
        //--3-Get-ended - for Daily Meezan bank income/Expence Report
        //POST -3 for Daily Meezan bank income/Expence Report
        //--3-POST-ended - for Daily Meezan bank income/Expence Report
       
        //Get -4 for Daily Punjab bank income/Expence Report
        public IActionResult DailyPunjabBankIEReport()
        {
            return View();
        }
        //--4-Get-ended - for Daily Punjab bank income/Expence Report
        //POST -4 for Daily Punjab bank income/Expence Report
        //--4-POST-ended - for Daily Punjab bank income/Expence Report     

        //Get -5 for Daily Cash closing Report
        public IActionResult DailyCashClosingReport()
        {
            return View();
        }
        //---5-Get-ended - for Daily Cash closing Report
        //POST -5 for Daily Cash closing Report
        //-POST--5-Get-ended - for Daily Cash closing Report      

        //Get -6 for Daily Meezan bank voucher Report
        public IActionResult DailyMeezanBankVoucherReport()
        {
            return View();
        }
        //---6-Get-ended - for Daily Meezan bank voucherReport
        //POST -6 for Daily Meezan bank voucher Report
        //-POST--6-Get-ended - for Daily Meezan bank voucherReport     

        //Get -7 for Daily Punjab bank voucher Report
        public IActionResult DailyPunjabBankVoucherReport()
        {
            return View();
        }
        //--7--Get-ended - for Daily Punjab bank voucherReport
        //POST -7 for Daily Punjab bank voucher Report
        //-POST-7--Get-ended - for Daily Punjab bank voucherReport      

        //Get -8 for Daily closing voucher Report
        public IActionResult DailyClosingVoucherReport()
        {
            return View();
        }
        //----Get-ended - for Daily closing voucher Report
        //POST -8 for Daily closing voucher Report
        //----POST-ended - for Daily closing voucher Report     

        //Get -9 for Daily Geneeral Ledger  Report
        public IActionResult DailyGeneralLedgerReport()
        {
            return View();
        }
        //---9-Get-ended - for Daily Geneeral Ledger  Report
        //POST -9 for Daily Geneeral Ledger  Report
        //---9-POST-ended - for Daily Geneeral Ledger  Report
     
        //Get -9 for DailySuppliersCashTransactionReport
        public IActionResult DailySuppliersCashTransactionReport()
        {
            return View();
        }
        //---9-Get-ended - for DailySuppliersCashTransactionReport
        //POST -9 for DailySuppliersCashTransactionReport
        //---9-POST-ended - for DailySuppliersCashTransactionReport



    }
}
