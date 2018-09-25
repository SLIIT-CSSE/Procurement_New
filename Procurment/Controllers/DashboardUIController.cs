using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Procurment.Controllers
{
    public class DashboardUIController : Controller
    {
        // GET: DashboardUI
        public ActionResult SiteMgr()
        {
            return View();
        }
    }
}