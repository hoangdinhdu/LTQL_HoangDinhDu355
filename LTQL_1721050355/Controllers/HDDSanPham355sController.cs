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
    public class HDDSanPham355sController : Controller
    {
        private LTQLDb db = new LTQLDb();

        // GET: HDDSanPham355s
        public ActionResult Index()
        {
            var hDDSanPham355s = db.HDDSanPham355s.Include(h => h.NhaCungCap355);
            return View(hDDSanPham355s.ToList());
        }

        // GET: HDDSanPham355s/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HDDSanPham355 hDDSanPham355 = db.HDDSanPham355s.Find(id);
            if (hDDSanPham355 == null)
            {
                return HttpNotFound();
            }
            return View(hDDSanPham355);
        }

        // GET: HDDSanPham355s/Create
        public ActionResult Create()
        {
            ViewBag.Manhacungcap = new SelectList(db.NhaCungCap355s, "Manhacungcap", "Tennhacungcap");
            return View();
        }

        // POST: HDDSanPham355s/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Masanpham,TenSanPham,Manhacungcap")] HDDSanPham355 hDDSanPham355)
        {
            if (ModelState.IsValid)
            {
                db.HDDSanPham355s.Add(hDDSanPham355);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Manhacungcap = new SelectList(db.NhaCungCap355s, "Manhacungcap", "Tennhacungcap", hDDSanPham355.Manhacungcap);
            return View(hDDSanPham355);
        }

        // GET: HDDSanPham355s/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HDDSanPham355 hDDSanPham355 = db.HDDSanPham355s.Find(id);
            if (hDDSanPham355 == null)
            {
                return HttpNotFound();
            }
            ViewBag.Manhacungcap = new SelectList(db.NhaCungCap355s, "Manhacungcap", "Tennhacungcap", hDDSanPham355.Manhacungcap);
            return View(hDDSanPham355);
        }

        // POST: HDDSanPham355s/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Masanpham,TenSanPham,Manhacungcap")] HDDSanPham355 hDDSanPham355)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hDDSanPham355).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Manhacungcap = new SelectList(db.NhaCungCap355s, "Manhacungcap", "Tennhacungcap", hDDSanPham355.Manhacungcap);
            return View(hDDSanPham355);
        }

        // GET: HDDSanPham355s/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HDDSanPham355 hDDSanPham355 = db.HDDSanPham355s.Find(id);
            if (hDDSanPham355 == null)
            {
                return HttpNotFound();
            }
            return View(hDDSanPham355);
        }

        // POST: HDDSanPham355s/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            HDDSanPham355 hDDSanPham355 = db.HDDSanPham355s.Find(id);
            db.HDDSanPham355s.Remove(hDDSanPham355);
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
