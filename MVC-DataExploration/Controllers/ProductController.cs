﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_DataExploration.Models;
namespace MVC_DataExploration.Controllers
{
    public class ProductController : Controller
    {
        MyDBContext DB = new MyDBContext();
        // GET: Product
        public ActionResult Index()
        {
            return View(DB.Products);
        }
    }
}