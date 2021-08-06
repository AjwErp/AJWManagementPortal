using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Dgm.Controllers
{
    [Area("Dgm")]
    public class DgmController : Controller
    {
        public IActionResult DgmDashboard()
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
        public IActionResult AllDepartment()
        {
            return View();
        }
        //action method for all department
    }
}
