using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Account.Controllers
{[Area("Account")]
    public class AccountsSupportGuideController : Controller
    {
        //GET -start- for AccountsLawBookLkst
        public IActionResult AccountsLawBookList()
        {
            return View();
        }
        //GET -ended- for AccountsLawBookList
        //POST -start- for AccountsLawBookList
        //POST -ended- for AccountsLawBookList


        //GET -start- for AccountsLawBook
        public IActionResult AccountsLawBook()
        {
            return View();
        }
        //GET -ended- for AccountsLawBook
        //POST -start- for AccountsLawBook
        //POST -ended- for AccountsLawBook

        //GET -start- for AccountsLawBook Book
        public IActionResult AccountsUserGuide()
        {
            return View();
        }
        //GET -ended- for AccountsLawBook Guide Book
        //POST -ended- for AccountsLawBook
        //POST -ended- for AccountsLawBook
    }
}

