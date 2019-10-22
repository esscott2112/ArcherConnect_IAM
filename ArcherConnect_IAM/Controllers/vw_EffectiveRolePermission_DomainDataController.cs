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
    public class vw_EffectiveRolePermission_DomainDataController : Controller
    {
        private ArcherConnectIAMEntities db = new ArcherConnectIAMEntities();

        // GET: vw_EffectiveRolePermission_DomainData
        public ActionResult Index()
        {
            return View(db.vw_EffectiveRolePermission_DomainData.ToList());
        }

        // GET: vw_EffectiveRolePermission_DomainData/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vw_EffectiveRolePermission_DomainData vw_EffectiveRolePermission_DomainData = db.vw_EffectiveRolePermission_DomainData.Find(id);
            if (vw_EffectiveRolePermission_DomainData == null)
            {
                return HttpNotFound();
            }
            return View(vw_EffectiveRolePermission_DomainData);
        }

        // GET: vw_EffectiveRolePermission_DomainData/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: vw_EffectiveRolePermission_DomainData/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RoleId,RoleName,SystemRolePermissionId,systemObjectPermissionID,DataType,PermissionName,objectId,name")] vw_EffectiveRolePermission_DomainData vw_EffectiveRolePermission_DomainData)
        {
            if (ModelState.IsValid)
            {
                db.vw_EffectiveRolePermission_DomainData.Add(vw_EffectiveRolePermission_DomainData);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vw_EffectiveRolePermission_DomainData);
        }

        // GET: vw_EffectiveRolePermission_DomainData/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vw_EffectiveRolePermission_DomainData vw_EffectiveRolePermission_DomainData = db.vw_EffectiveRolePermission_DomainData.Find(id);
            if (vw_EffectiveRolePermission_DomainData == null)
            {
                return HttpNotFound();
            }
            return View(vw_EffectiveRolePermission_DomainData);
        }

        // POST: vw_EffectiveRolePermission_DomainData/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RoleId,RoleName,SystemRolePermissionId,systemObjectPermissionID,DataType,PermissionName,objectId,name")] vw_EffectiveRolePermission_DomainData vw_EffectiveRolePermission_DomainData)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vw_EffectiveRolePermission_DomainData).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vw_EffectiveRolePermission_DomainData);
        }

        // GET: vw_EffectiveRolePermission_DomainData/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vw_EffectiveRolePermission_DomainData vw_EffectiveRolePermission_DomainData = db.vw_EffectiveRolePermission_DomainData.Find(id);
            if (vw_EffectiveRolePermission_DomainData == null)
            {
                return HttpNotFound();
            }
            return View(vw_EffectiveRolePermission_DomainData);
        }

        // POST: vw_EffectiveRolePermission_DomainData/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            vw_EffectiveRolePermission_DomainData vw_EffectiveRolePermission_DomainData = db.vw_EffectiveRolePermission_DomainData.Find(id);
            db.vw_EffectiveRolePermission_DomainData.Remove(vw_EffectiveRolePermission_DomainData);
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
