using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ArcherConnect_IAM.Models;

namespace ArcherConnect_IAM.Controllers
{
    public class SystemPersonsController : Controller
    {
        private ArcherConnectIAMEntities db = new ArcherConnectIAMEntities();

        // GET: SystemPersons
        public ActionResult Index()
        {
            return View(db.SystemPersons.ToList());
        }

        // GET: SystemPersons/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SystemPerson systemPerson = db.SystemPersons.Find(id);
            if (systemPerson == null)
            {
                return HttpNotFound();
            }
            return View(systemPerson);
        }

        // GET: SystemPersons/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SystemPersons/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,Email")] SystemPerson systemPerson)
        {
            if (ModelState.IsValid)
            {
                db.SystemPersons.Add(systemPerson);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(systemPerson);
        }

        // GET: SystemPersons/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SystemPerson systemPerson = db.SystemPersons.Find(id);
            if (systemPerson == null)
            {
                return HttpNotFound();
            }
            return View(systemPerson);
        }

        // POST: SystemPersons/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,Email")] SystemPerson systemPerson)
        {
            if (ModelState.IsValid)
            {
                db.Entry(systemPerson).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(systemPerson);
        }

        // GET: SystemPersons/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SystemPerson systemPerson = db.SystemPersons.Find(id);
            if (systemPerson == null)
            {
                return HttpNotFound();
            }
            return View(systemPerson);
        }

        // POST: SystemPersons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SystemPerson systemPerson = db.SystemPersons.Find(id);
            db.SystemPersons.Remove(systemPerson);
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
