using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Hospital.SaoJose.Negocios;

namespace Hospital.SaoJose.Front.Controllers
{
    public class ProfissionalSaudeController : Controller
    {
        private DBContext db = new DBContext();

        // GET: /Default1/
        public ActionResult Index()
        {
            return View(db.ProfissionalSaude.ToList());
        }

        // GET: /Default1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProfissionalSaude profissionalsaude = db.ProfissionalSaude.Find(id);
            if (profissionalsaude == null)
            {
                return HttpNotFound();
            }
            return View(profissionalsaude);
        }

        // GET: /Default1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Default1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,Nome,Formacao")] ProfissionalSaude profissionalsaude)
        {
            if (ModelState.IsValid)
            {
                db.ProfissionalSaude.Add(profissionalsaude);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(profissionalsaude);
        }

        // GET: /Default1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProfissionalSaude profissionalsaude = db.ProfissionalSaude.Find(id);
            if (profissionalsaude == null)
            {
                return HttpNotFound();
            }
            return View(profissionalsaude);
        }

        // POST: /Default1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,Nome,Formacao")] ProfissionalSaude profissionalsaude)
        {
            if (ModelState.IsValid)
            {
                db.Entry(profissionalsaude).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(profissionalsaude);
        }

        // GET: /Default1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProfissionalSaude profissionalsaude = db.ProfissionalSaude.Find(id);
            if (profissionalsaude == null)
            {
                return HttpNotFound();
            }
            return View(profissionalsaude);
        }

        // POST: /Default1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ProfissionalSaude profissionalsaude = db.ProfissionalSaude.Find(id);
            db.ProfissionalSaude.Remove(profissionalsaude);
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
