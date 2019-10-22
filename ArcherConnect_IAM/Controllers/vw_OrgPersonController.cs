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
    public class vw_OrgPersonController : Controller
    {
        private ArcherConnectIAMEntities db = new ArcherConnectIAMEntities();

        // GET: vw_OrgPerson
        public ActionResult Index()
        {
            return View(db.vw_OrgPerson.ToList());
        }

        // GET: vw_OrgPerson/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vw_OrgPerson vw_OrgPerson = db.vw_OrgPerson.Find(id);
            if (vw_OrgPerson == null)
            {
                return HttpNotFound();
            }
            return View(vw_OrgPerson);
        }

        // GET: vw_OrgPerson/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: vw_OrgPerson/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PersonID,FirstName,LastName,Email,OrgTypeAssignmentID,OrgPersonID,OrganizationName,OrganizationType")] vw_OrgPerson vw_OrgPerson)
        {
            if (ModelState.IsValid)
            {
                db.vw_OrgPerson.Add(vw_OrgPerson);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vw_OrgPerson);
        }

        // GET: vw_OrgPerson/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vw_OrgPerson vw_OrgPerson = db.vw_OrgPerson.Find(id);
            if (vw_OrgPerson == null)
            {
                return HttpNotFound();
            }
            return View(vw_OrgPerson);
        }

        // POST: vw_OrgPerson/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PersonID,FirstName,LastName,Email,OrgTypeAssignmentID,OrgPersonID,OrganizationName,OrganizationType")] vw_OrgPerson vw_OrgPerson)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vw_OrgPerson).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vw_OrgPerson);
        }

        // GET: vw_OrgPerson/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vw_OrgPerson vw_OrgPerson = db.vw_OrgPerson.Find(id);
            if (vw_OrgPerson == null)
            {
                return HttpNotFound();
            }
            return View(vw_OrgPerson);
        }

        // POST: vw_OrgPerson/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            vw_OrgPerson vw_OrgPerson = db.vw_OrgPerson.Find(id);
            db.vw_OrgPerson.Remove(vw_OrgPerson);
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
