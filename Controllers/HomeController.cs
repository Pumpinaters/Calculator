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
        return View("Index");
    }

        public ActionResult Details(string id)
        {
            //logic to fetch details on ID
            return View("Details");
        }

        [HttpPost]
        public ActionResult Index(CalculatorViewModel model, string command)
        {
            if (model == null)
            {
                TryValidateModel(model);
            }
            else
            {
                if (command == "Add")
                {
                    model.Result = model.A + model.B;
                }
                if (command == "Sub")
                {
                    model.Result = model.A - model.B;
                }
                if (command == "Mul")
                {
                    model.Result = model.A * model.B;
                }
                if (command == "Div")
                {
                    model.Result = model.A / model.B;
                }
              }
                return View(model);
            }
}    
}
