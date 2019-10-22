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
    public class vw_UserRoleController : Controller
    {
        private ArcherConnectIAMEntities db = new ArcherConnectIAMEntities();

        // GET: vw_UserRole
        public ActionResult Index()
        {
            return View(db.vw_UserRole.ToList());
        }

        // GET: vw_UserRole/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vw_UserRole vw_UserRole = db.vw_UserRole.Find(id);
            if (vw_UserRole == null)
            {
                return HttpNotFound();
            }
            return View(vw_UserRole);
        }

        // GET: vw_UserRole/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: vw_UserRole/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "systemuserRoleID,Username,UserId,RoleName,RoleId")] vw_UserRole vw_UserRole)
        {
            if (ModelState.IsValid)
            {
                db.vw_UserRole.Add(vw_UserRole);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vw_UserRole);
        }

        // GET: vw_UserRole/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vw_UserRole vw_UserRole = db.vw_UserRole.Find(id);
            if (vw_UserRole == null)
            {
                return HttpNotFound();
            }
            return View(vw_UserRole);
        }

        // POST: vw_UserRole/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "systemuserRoleID,Username,UserId,RoleName,RoleId")] vw_UserRole vw_UserRole)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vw_UserRole).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vw_UserRole);
        }

        // GET: vw_UserRole/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vw_UserRole vw_UserRole = db.vw_UserRole.Find(id);
            if (vw_UserRole == null)
            {
                return HttpNotFound();
            }
            return View(vw_UserRole);
        }

        // POST: vw_UserRole/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            vw_UserRole vw_UserRole = db.vw_UserRole.Find(id);
            db.vw_UserRole.Remove(vw_UserRole);
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
