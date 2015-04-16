using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _411_University.Models;
using _411_University.DAL;

namespace _411_University.Controllers
{
    public class ProfessorController : Controller
    {
        private SchoolContext db = new SchoolContext();

        //
        // GET: /Professor/

        public ActionResult Index()
        {
            return View(db.Professors.ToList());
        }

        //
        // GET: /Professor/Details/5

        public ActionResult Details(int id = 0)
        {
            Professor professor = db.Professors.Find(id);
            if (professor == null)
            {
                return HttpNotFound();
            }
            return View(professor);
        }

        //
        // GET: /Professor/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Professor/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Professor professor)
        {
            if (ModelState.IsValid)
            {
                db.Professors.Add(professor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(professor);
        }

        //
        // GET: /Professor/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Professor professor = db.Professors.Find(id);
            if (professor == null)
            {
                return HttpNotFound();
            }
            return View(professor);
        }

        //
        // POST: /Professor/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Professor professor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(professor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(professor);
        }

        //
        // GET: /Professor/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Professor professor = db.Professors.Find(id);
            if (professor == null)
            {
                return HttpNotFound();
            }
            return View(professor);
        }

        //
        // POST: /Professor/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Professor professor = db.Professors.Find(id);
            db.Professors.Remove(professor);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}