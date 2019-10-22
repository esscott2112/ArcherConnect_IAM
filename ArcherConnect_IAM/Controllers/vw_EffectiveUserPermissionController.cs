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
    public class vw_EffectiveUserPermissionController : Controller
    {
        private ArcherConnectIAMEntities db = new ArcherConnectIAMEntities();

        // GET: vw_EffectiveUserPermission
        public ActionResult Index()
        {
            return View(db.vw_EffectiveUserPermission.ToList());
        }

        // GET: vw_EffectiveUserPermission/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vw_EffectiveUserPermission vw_EffectiveUserPermission = db.vw_EffectiveUserPermission.Find(id);
            if (vw_EffectiveUserPermission == null)
            {
                return HttpNotFound();
            }
            return View(vw_EffectiveUserPermission);
        }

        // GET: vw_EffectiveUserPermission/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: vw_EffectiveUserPermission/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SystemUserId,Username,ElementName,ModuleName,PermissionName,PermissionType")] vw_EffectiveUserPermission vw_EffectiveUserPermission)
        {
            if (ModelState.IsValid)
            {
                db.vw_EffectiveUserPermission.Add(vw_EffectiveUserPermission);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vw_EffectiveUserPermission);
        }

        // GET: vw_EffectiveUserPermission/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vw_EffectiveUserPermission vw_EffectiveUserPermission = db.vw_EffectiveUserPermission.Find(id);
            if (vw_EffectiveUserPermission == null)
            {
                return HttpNotFound();
            }
            return View(vw_EffectiveUserPermission);
        }

        // POST: vw_EffectiveUserPermission/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SystemUserId,Username,ElementName,ModuleName,PermissionName,PermissionType")] vw_EffectiveUserPermission vw_EffectiveUserPermission)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vw_EffectiveUserPermission).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vw_EffectiveUserPermission);
        }

        // GET: vw_EffectiveUserPermission/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vw_EffectiveUserPermission vw_EffectiveUserPermission = db.vw_EffectiveUserPermission.Find(id);
            if (vw_EffectiveUserPermission == null)
            {
                return HttpNotFound();
            }
            return View(vw_EffectiveUserPermission);
        }

        // POST: vw_EffectiveUserPermission/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            vw_EffectiveUserPermission vw_EffectiveUserPermission = db.vw_EffectiveUserPermission.Find(id);
            db.vw_EffectiveUserPermission.Remove(vw_EffectiveUserPermission);
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
