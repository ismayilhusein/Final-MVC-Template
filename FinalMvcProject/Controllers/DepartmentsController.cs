﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalMvcProject.ViewModels;

namespace FinalMvcProject.Controllers
{
    public class DepartmentsController : BaseController
    {
        // GET: Departments
        public ActionResult Index()
        {
           
            return View();
        }
        public ActionResult Single()
        {
            return View();
        }
    }
}