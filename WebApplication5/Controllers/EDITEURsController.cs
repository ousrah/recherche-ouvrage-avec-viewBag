using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication5;

namespace WebApplication5.Controllers
{
    public class EDITEURsController : Controller
    {
        private librairieEntities db = new librairieEntities();

        public ActionResult getListe(string mot)
        {
            var editeurs = db.EDITEUR.Where(e=>e.NOMED.Contains(mot)).ToList();
            return PartialView("~/Views/Editeurs/ListeEditeurs2.cshtml", editeurs);
        }


        // GET: EDITEURs
        public ActionResult Index()
        {
            return View(db.EDITEUR.ToList());
        }

        // GET: EDITEURs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EDITEUR eDITEUR = db.EDITEUR.Find(id);
            if (eDITEUR == null)
            {
                return HttpNotFound();
            }
            return View(eDITEUR);
        }

        // GET: EDITEURs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EDITEURs/Create
        // Pour vous protéger des attaques par survalidation, activez les propriétés spécifiques auxquelles vous souhaitez vous lier. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NOMED,ADRED,CPED,VILLEED,TELED")] EDITEUR eDITEUR)
        {
            if (ModelState.IsValid)
            {
                db.EDITEUR.Add(eDITEUR);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(eDITEUR);
        }

        // GET: EDITEURs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EDITEUR eDITEUR = db.EDITEUR.Find(id);
            if (eDITEUR == null)
            {
                return HttpNotFound();
            }
            return View(eDITEUR);
        }

        // POST: EDITEURs/Edit/5
        // Pour vous protéger des attaques par survalidation, activez les propriétés spécifiques auxquelles vous souhaitez vous lier. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NOMED,ADRED,CPED,VILLEED,TELED")] EDITEUR eDITEUR)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eDITEUR).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(eDITEUR);
        }

        // GET: EDITEURs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EDITEUR eDITEUR = db.EDITEUR.Find(id);
            if (eDITEUR == null)
            {
                return HttpNotFound();
            }
            return View(eDITEUR);
        }

        // POST: EDITEURs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            EDITEUR eDITEUR = db.EDITEUR.Find(id);
            db.EDITEUR.Remove(eDITEUR);
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
