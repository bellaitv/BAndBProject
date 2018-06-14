using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BAndBProject.Models;

namespace BAndBProject.Controllers
{
    public class ItemsController : Controller
    {
        // GET: Items
        public ActionResult Index()
        {

            var item = new Item { Name = "TEST ITEM" };
            return View(item);
        }
    }
}