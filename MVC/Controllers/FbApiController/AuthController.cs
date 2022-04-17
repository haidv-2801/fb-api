using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using MVC.Models;
using Newtonsoft.Json;

namespace MVC.Controllers.FbApiController
{
    public class AuthController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}