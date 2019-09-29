using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCprac.Models;

namespace MVCprac.Controllers
{
    public class MoneyTemplateController : Controller
    {
        public ActionResult Index()
        {
            var randomData = new RandomData();
            return View(randomData.viewModelList());
        }
    }
}