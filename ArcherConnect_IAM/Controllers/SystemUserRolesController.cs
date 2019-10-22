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
    public class SystemUserRolesController : Controller
    {
        private ArcherConnectIAMEntities db = new ArcherConnectIAMEntities();

        // GET: SystemUserRoles
        public ActionResult Index()
        {
            return View(db.SystemUserRoles.ToList());
        }

        // GET: SystemUserRoles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SystemUserRole systemUserRole = db.SystemUserRoles.Find(id);
            if (systemUserRole == null)
            {
                return HttpNotFound();
            }
            return View(systemUserRole);
        }

        // GET: SystemUserRoles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SystemUserRoles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,RoleId,UserId")] SystemUserRole systemUserRole)
        {
            if (ModelState.IsValid)
            {
                db.SystemUserRoles.Add(systemUserRole);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(systemUserRole);
        }

        // GET: SystemUserRoles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SystemUserRole systemUserRole = db.SystemUserRoles.Find(id);
            if (systemUserRole == null)
            {
                return HttpNotFound();
            }
            return View(systemUserRole);
        }

        // POST: SystemUserRoles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,RoleId,UserId")] SystemUserRole systemUserRole)
        {
            if (ModelState.IsValid)
            {
                db.Entry(systemUserRole).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(systemUserRole);
        }

        // GET: SystemUserRoles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SystemUserRole systemUserRole = db.SystemUserRoles.Find(id);
            if (systemUserRole == null)
            {
                return HttpNotFound();
            }
            return View(systemUserRole);
        }

        // POST: SystemUserRoles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SystemUserRole systemUserRole = db.SystemUserRoles.Find(id);
            db.SystemUserRoles.Remove(systemUserRole);
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
