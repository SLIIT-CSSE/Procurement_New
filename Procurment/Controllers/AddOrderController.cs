using Procurment.Models;
using System.Data.Entity;
using System.Web.Mvc;
using System.Collections.Generic;


namespace Procurment.Controllers
{
    public class AddOrderController : Controller
    {
        private ApplicationDbContext _context; 

        public AddOrderController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: AddOrder
        public ActionResult AddMyOrder()
        {
            return View();
        }

        public ActionResult AddNewItem()
        {
            var viewmodel = new ConstructionItem { };
            return View(viewmodel);
        }

        [HttpPost]
        public ActionResult create(ConstructionItem constructionitem)
        {
            _context.ConstructionItems.Add(constructionitem);
            _context.SaveChanges();
            return RedirectToAction("AddNewItem","AddOrder");
        }
    }
}