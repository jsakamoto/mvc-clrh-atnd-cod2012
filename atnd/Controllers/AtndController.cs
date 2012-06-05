using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using atnd.Models;

namespace atnd.Controllers
{
    public class AtndController : Controller
    {
        private AtndDB db = new AtndDB();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            return View(db.Attendees.ToList());
        }

        /// <summary>
        /// Regist
        /// </summary>
        /// <returns></returns>
        public ActionResult Regist()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Regist(Attendee attendee, string cmd)
        {
            if (cmd == "Cancel") return RedirectToAction("Index");

            if (ModelState.IsValid)
            {
                db.Attendees.Add(attendee);
                db.SaveChanges();

                return RedirectToAction("Complete");
            }

            return View(attendee);
        }

        public ActionResult Complete()
        {
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}