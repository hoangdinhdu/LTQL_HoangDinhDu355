using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LTQL_1721050355.Models;

namespace LTQL_1721050355.Controllers
{
    public class NhaCungCap355sController : Controller
    {
        private LTQLDb db = new LTQLDb();

        // GET: NhaCungCap355s
        public ActionResult Index()
        {
            return View(db.NhaCungCap355s.ToList());
        }

        // GET: NhaCungCap355s/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhaCungCap355 nhaCungCap355 = db.NhaCungCap355s.Find(id);
            if (nhaCungCap355 == null)
            {
                return HttpNotFound();
            }
            return View(nhaCungCap355);
        }

        // GET: NhaCungCap355s/Create
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        // POST: NhaCungCap355s/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Manhacungcap,Tennhacungcap")] NhaCungCap355 nhaCungCap355)
        {
            if (ModelState.IsValid)
            {
                db.NhaCungCap355s.Add(nhaCungCap355);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nhaCungCap355);
        }

        // GET: NhaCungCap355s/Edit/5
        [Authorize]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhaCungCap355 nhaCungCap355 = db.NhaCungCap355s.Find(id);
            if (nhaCungCap355 == null)
            {
                return HttpNotFound();
            }
            return View(nhaCungCap355);
        }

        // POST: NhaCungCap355s/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Manhacungcap,Tennhacungcap")] NhaCungCap355 nhaCungCap355)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nhaCungCap355).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nhaCungCap355);
        }

        // GET: NhaCungCap355s/Delete/5
        [Authorize]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhaCungCap355 nhaCungCap355 = db.NhaCungCap355s.Find(id);
            if (nhaCungCap355 == null)
            {
                return HttpNotFound();
            }
            return View(nhaCungCap355);
        }

        // POST: NhaCungCap355s/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NhaCungCap355 nhaCungCap355 = db.NhaCungCap355s.Find(id);
            db.NhaCungCap355s.Remove(nhaCungCap355);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
