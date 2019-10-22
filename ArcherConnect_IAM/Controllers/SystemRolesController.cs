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
    public class SystemRolesController : Controller
    {
        private ArcherConnectIAMEntities db = new ArcherConnectIAMEntities();

        // GET: SystemRoles
        public ActionResult Index()
        {
            return View(db.SystemRoles.ToList());
        }

        // GET: SystemRoles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SystemRole systemRole = db.SystemRoles.Find(id);
            if (systemRole == null)
            {
                return HttpNotFound();
            }
            return View(systemRole);
        }

        // GET: SystemRoles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SystemRoles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,RoleName")] SystemRole systemRole)
        {
            if (ModelState.IsValid)
            {
                db.SystemRoles.Add(systemRole);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(systemRole);
        }

        // GET: SystemRoles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SystemRole systemRole = db.SystemRoles.Find(id);
            if (systemRole == null)
            {
                return HttpNotFound();
            }
            return View(systemRole);
        }

        // POST: SystemRoles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,RoleName")] SystemRole systemRole)
        {
            if (ModelState.IsValid)
            {
                db.Entry(systemRole).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(systemRole);
        }

        // GET: SystemRoles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SystemRole systemRole = db.SystemRoles.Find(id);
            if (systemRole == null)
            {
                return HttpNotFound();
            }
            return View(systemRole);
        }

        // POST: SystemRoles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SystemRole systemRole = db.SystemRoles.Find(id);
            db.SystemRoles.Remove(systemRole);
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
