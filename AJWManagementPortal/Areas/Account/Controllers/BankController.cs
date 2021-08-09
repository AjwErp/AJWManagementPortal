using AJWManagementPortal.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Account.Controllers
{[Area("Account")]
    public class BankController : Controller
    {
        private readonly ApplicationDbContext _db;
        //private readonly IWebHostEnvironment _iwebhost;
        //IWebHostEnvironment iwebhost
        //                _iwebhost = iwebhost;

        public BankController(ApplicationDbContext db)
        {
            _db = db;

        }
        //GET--MeezanBankAccountReportsList--start---
        public IActionResult MeezanBankAccountReportsList()
        {
            return View();
        }
        //GET--for MeezanBankAccountReportsList---ended---
        //POST--for MeezanBankAccountReportsList---Start---
        //POST--for MeezanBankAccountReportsList---ended----

        //GET--BOPBankAccountReportsList--start--
        public IActionResult BOPBankAccountReportsList()
        {
            return View();
        }
        //GET--for BOPBankAccountReportsList---ended---
        //POST--for BOPBankAccountReportsList---Start---
        //POST--for BOPBankAccountReportsList---ended----


        //GET--for BankCheckApprovelVoucherList---start--
        public IActionResult BankCheckApprovelVoucherList()
        {
            return View();
        }
        //GET--for BankCheckApprovelVoucherList---ended---
        //POST--for BankCheckApprovelVoucherList--start---
        //POST--for BankCheckApprovelVoucherList---ended--

        //GET--for Bank Check Approvel Voucher---start---
        public IActionResult BankCheckApprovelVoucher()
        {
            return View();
        }
        //GET--for Bank Check Approvel Voucher---ended---
        //POST--for Bank Check Approvel Voucher---start---
        //POST--for Bank Check Approvel Voucher--ended---
    }
}
