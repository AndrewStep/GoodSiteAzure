using DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetIdentity2ExtendingUsersAndRoles.Controllers
{
    public class AdminController : Controller
    {
        static int carsOnPage = 3;
        CarContext context;

        public AdminController()
        {
            context = new CarContext();
        }

        public ActionResult Index(int id = 1)
        {
            ViewBag.Count = context.CARSINFO.ToList().Count();
            var model = context.CARSINFO;
            ViewBag.Index = id;
            return View();
        }

        public ActionResult Add(int id)
        {
            CARSINFO c = null;
            if (id != 0)
                c = context.CARSINFO.ToList().FirstOrDefault(x => x.CARId == id);

            return View(c);
        }

        [HttpPost]
        public ActionResult Add(CARSINFO c)
        {
            if (ModelState.IsValid)
            {
                context.CARSINFO.Add(c);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
                return View(c);
        }

        public ActionResult Edit(int id)
        {
            CARSINFO c = null;
            if (id != 0)
                c = context.CARSINFO.ToList().FirstOrDefault(x => x.CARId == id);

            return View(c);
        }

        [HttpPost]
        public ActionResult Edit(CARSINFO c)
        {
            if (ModelState.IsValid)
            {
                context.CARSINFO.AddOrUpdate(c);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
                return View(c);
        }

        public PartialViewResult GetTable(int id = 1)
        {
            if (Request["g"] != null)
                carsOnPage = Convert.ToInt32(Request["g"]);

            ViewBag.Cars = context.CARSINFO.ToList().Skip((id - 1) * carsOnPage).Take(carsOnPage);
            ViewBag.PageCount = Math.Ceiling(context.CARSINFO.ToList().Count / (double)carsOnPage);
            return PartialView();
        }

        // GET
        public ActionResult Remove(int? id)
        {
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            CARSINFO car = context.CARSINFO.Find(id);
            if (car == null)
            {
                return HttpNotFound();
            }
            return View(car);
        }
        // POST
        [HttpPost]
        public ActionResult Remove(int id)
        {
            CARSINFO car = context.CARSINFO.Find(id);
            context.CARSINFO.Remove(car);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}