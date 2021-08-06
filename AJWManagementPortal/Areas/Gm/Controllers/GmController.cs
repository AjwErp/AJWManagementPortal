using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Gm.Controllers
{
    [Area("Gm")]
    public class GmController : Controller
    {
        public IActionResult GmDashboard()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
        //action for Calender Page 
        public IActionResult Calender()
        {
            return View();
        }
        //end Calender page action
        //action method for all department
        public IActionResult AjwPrtalAllDepartments()
        {
            return View();
        }
        //action method for all department

    }
}
