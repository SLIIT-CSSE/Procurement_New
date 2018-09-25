using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Procurment.Controllers
{
    public class AddOrderController : Controller
    {
        // GET: AddOrder
        public ActionResult AddMyOrder()
        {
            return View();
        }

        public ActionResult AddNewItem()
        {
            return View();
        }
    }
}