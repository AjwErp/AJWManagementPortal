﻿using AJWManagementPortal.Data;
using AJWManagementPortal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Account.Controllers
{
    [Area("Account")]
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _db;
        //private readonly IWebHostEnvironment _iwebhost;
        //IWebHostEnvironment iwebhost
        //                _iwebhost = iwebhost;

        public AccountController(ApplicationDbContext db)
        {
            _db = db;

        }
        //action for Dashboard  Page 
        public IActionResult AccountDashboard()
        {
            return View();
        }
        //action for Dashboard Page 
        //action for Index Page 
        public IActionResult Index()
        {
            return View();
        }
        //action for Index Page 
        //action for Error Page 
        public IActionResult Error()
        {
            return View();
        }
        //end error page action
        //action for Calender Page 
        public IActionResult Calender()
        {
            return View();
        }
        //end Calender page action
        
        public IActionResult Loading()
        {
            return View();
        }

  

    }
}
