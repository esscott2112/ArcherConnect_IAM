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
    public class vw_OrgTypeAssignmentController : Controller
    {
        private ArcherConnectIAMEntities db = new ArcherConnectIAMEntities();

        // GET: vw_OrgTypeAssignment
        public ActionResult Index()
        {
            return View(db.vw_OrgTypeAssignment.ToList());
        }

        // GET: vw_OrgTypeAssignment/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vw_OrgTypeAssignment vw_OrgTypeAssignment = db.vw_OrgTypeAssignment.Find(id);
            if (vw_OrgTypeAssignment == null)
            {
                return HttpNotFound();
            }
            return View(vw_OrgTypeAssignment);
        }

        // GET: vw_OrgTypeAssignment/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: vw_OrgTypeAssignment/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OrganizationName,OrganizationType,OrgTypeAssignmentId")] vw_OrgTypeAssignment vw_OrgTypeAssignment)
        {
            if (ModelState.IsValid)
            {
                db.vw_OrgTypeAssignment.Add(vw_OrgTypeAssignment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vw_OrgTypeAssignment);
        }

        // GET: vw_OrgTypeAssignment/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vw_OrgTypeAssignment vw_OrgTypeAssignment = db.vw_OrgTypeAssignment.Find(id);
            if (vw_OrgTypeAssignment == null)
            {
                return HttpNotFound();
            }
            return View(vw_OrgTypeAssignment);
        }

        // POST: vw_OrgTypeAssignment/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OrganizationName,OrganizationType,OrgTypeAssignmentId")] vw_OrgTypeAssignment vw_OrgTypeAssignment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vw_OrgTypeAssignment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vw_OrgTypeAssignment);
        }

        // GET: vw_OrgTypeAssignment/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vw_OrgTypeAssignment vw_OrgTypeAssignment = db.vw_OrgTypeAssignment.Find(id);
            if (vw_OrgTypeAssignment == null)
            {
                return HttpNotFound();
            }
            return View(vw_OrgTypeAssignment);
        }

        // POST: vw_OrgTypeAssignment/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            vw_OrgTypeAssignment vw_OrgTypeAssignment = db.vw_OrgTypeAssignment.Find(id);
            db.vw_OrgTypeAssignment.Remove(vw_OrgTypeAssignment);
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
