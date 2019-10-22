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
    public class vw_EffectiveRolePermissionController : Controller
    {
        private ArcherConnectIAMEntities db = new ArcherConnectIAMEntities();

        // GET: vw_EffectiveRolePermission
        public ActionResult Index()
        {
            return View(db.vw_EffectiveRolePermission.ToList());
        }

        // GET: vw_EffectiveRolePermission/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vw_EffectiveRolePermission vw_EffectiveRolePermission = db.vw_EffectiveRolePermission.Find(id);
            if (vw_EffectiveRolePermission == null)
            {
                return HttpNotFound();
            }
            return View(vw_EffectiveRolePermission);
        }

        // GET: vw_EffectiveRolePermission/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: vw_EffectiveRolePermission/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RoleId,RoleName,SystemRolePermissionId,systemObjectPermissionID,ElementName,ModuleName,PermissionName")] vw_EffectiveRolePermission vw_EffectiveRolePermission)
        {
            if (ModelState.IsValid)
            {
                db.vw_EffectiveRolePermission.Add(vw_EffectiveRolePermission);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vw_EffectiveRolePermission);
        }

        // GET: vw_EffectiveRolePermission/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vw_EffectiveRolePermission vw_EffectiveRolePermission = db.vw_EffectiveRolePermission.Find(id);
            if (vw_EffectiveRolePermission == null)
            {
                return HttpNotFound();
            }
            return View(vw_EffectiveRolePermission);
        }

        // POST: vw_EffectiveRolePermission/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RoleId,RoleName,SystemRolePermissionId,systemObjectPermissionID,ElementName,ModuleName,PermissionName")] vw_EffectiveRolePermission vw_EffectiveRolePermission)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vw_EffectiveRolePermission).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vw_EffectiveRolePermission);
        }

        // GET: vw_EffectiveRolePermission/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vw_EffectiveRolePermission vw_EffectiveRolePermission = db.vw_EffectiveRolePermission.Find(id);
            if (vw_EffectiveRolePermission == null)
            {
                return HttpNotFound();
            }
            return View(vw_EffectiveRolePermission);
        }

        // POST: vw_EffectiveRolePermission/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            vw_EffectiveRolePermission vw_EffectiveRolePermission = db.vw_EffectiveRolePermission.Find(id);
            db.vw_EffectiveRolePermission.Remove(vw_EffectiveRolePermission);
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
