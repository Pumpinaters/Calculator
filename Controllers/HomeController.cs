using MattTest2.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
using System.Web;
using System.Web.Mvc;

namespace MattTest2.Controllers
{
    public class HomeController : Controller { 
        //    
        // GET: /Home/    
        [HttpGet]
        public ActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public ActionResult Index(CalculatorViewModel model, string command)
    {
        if (command == "add")
        {
            model.Result = model.A + model.B;
        }
        if (command == "sub")
        {
            model.Result = model.A - model.B;
        }
        if (command == "mul")
        {
            model.Result = model.A * model.B;
        }
        if (command == "div")
        {
            model.Result = model.A / model.B;
        }
        return View(model);
    }
}    
}
