using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    public class CompoundController : Controller
    {
        public static Assignment1Context context;
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult CalculateCompoundValue(Compound cObj)
        {
            cObj.Result = cObj.Principal * (Math.Pow((1 + (cObj.Rate / cObj.Number)), (cObj.Number * cObj.Time)));
            return View(cObj);
        }
    }
}