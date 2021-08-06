using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Ceo.Controllers
{
    [Area("Ceo")]
    public class CeoController : Controller
    {
        public IActionResult CeoDashboard()
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
        //action for All Departments Page 
        public IActionResult AllDepartment()
        {
            return View();
        }
        //end All Departmentsr page action
        //action for Userprofile Page 
        public IActionResult UserProfile()
        {
            return View();
        }
        //action for Userprofile Page\
    }
}
