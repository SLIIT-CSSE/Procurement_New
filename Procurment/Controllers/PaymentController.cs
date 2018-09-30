using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Procurment.Controllers
{
    public class PaymentController : Controller
    {
        // GET: Payment
        public ActionResult SuccessfullPayment()
        {
            return View();
        }

        public ActionResult SuccessfullPaymentList()
        {
            return View();
        }
        
        public ActionResult PendingPayment()
        {
            return View();
        }

        public ActionResult PendingPaymentList()
        {
            return View();
        }

        public ActionResult ManagerApprovedList()
        {
            return View();
        }

        public ActionResult ManagerApprovedItem()
        {
            return View();
        }

    }
}