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
    public class OrgTypeAssignmentsController : Controller
    {
        private ArcherConnectIAMEntities db = new ArcherConnectIAMEntities();

        // GET: OrgTypeAssignments
        public ActionResult Index()
        {
            return View(db.OrgTypeAssignments.ToList());
        }

        // GET: OrgTypeAssignments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrgTypeAssignment orgTypeAssignment = db.OrgTypeAssignments.Find(id);
            if (orgTypeAssignment == null)
            {
                return HttpNotFound();
            }
            return View(orgTypeAssignment);
        }

        // GET: OrgTypeAssignments/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrgTypeAssignments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Organization,OrganizationType,Name")] OrgTypeAssignment orgTypeAssignment)
        {
            if (ModelState.IsValid)
            {
                db.OrgTypeAssignments.Add(orgTypeAssignment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(orgTypeAssignment);
        }

        // GET: OrgTypeAssignments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrgTypeAssignment orgTypeAssignment = db.OrgTypeAssignments.Find(id);
            if (orgTypeAssignment == null)
            {
                return HttpNotFound();
            }
            return View(orgTypeAssignment);
        }

        // POST: OrgTypeAssignments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Organization,OrganizationType,Name")] OrgTypeAssignment orgTypeAssignment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(orgTypeAssignment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(orgTypeAssignment);
        }

        // GET: OrgTypeAssignments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrgTypeAssignment orgTypeAssignment = db.OrgTypeAssignments.Find(id);
            if (orgTypeAssignment == null)
            {
                return HttpNotFound();
            }
            return View(orgTypeAssignment);
        }

        // POST: OrgTypeAssignments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OrgTypeAssignment orgTypeAssignment = db.OrgTypeAssignments.Find(id);
            db.OrgTypeAssignments.Remove(orgTypeAssignment);
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
