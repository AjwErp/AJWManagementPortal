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
        public IActionResult MeezanBankAccountReportsList()
        {
            return View();
        }

        public IActionResult BOPBankAccountReportsList()
        {
            return View();
        }
   
        //GET--for BankCheckApprovelVoucherList--
        public IActionResult BankCheckApprovelVoucherList()
        {
            return View();
        }
        //GET--for BankCheckApprovelVoucherList--
        //POST--for BankCheckApprovelVoucherList--
        //POST--for BankCheckApprovelVoucherList--

        //GET--for Bank Check Approvel Voucher--
        public IActionResult BankCheckApprovelVoucher()
        {
            return View();
        }
        //GET--for Bank Check Approvel Voucher--
        //POST--for Bank Check Approvel Voucher--
        //POST--for Bank Check Approvel Voucher--
    }
}
