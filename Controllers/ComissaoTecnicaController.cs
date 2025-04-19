using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Liga_Futebol.BancoDados;
using Liga_Futebol.Models;

namespace Liga_Futebol.Controllers
{
    public class ComissaoTecnicaController : Controller
    {
        private LigaFutebolContext db = new LigaFutebolContext();

        // GET: ComissaoTecnica
        public ActionResult Index(String searchNome, Cargo? searchCargo)
        {
            var comissoesTecnicas = db.ComissoesTecnicas
                .Include(ct => ct.Time)
                .AsQueryable();

            if (!String.IsNullOrEmpty(searchNome))
            {
                comissoesTecnicas = comissoesTecnicas.Where(ct => ct.Nome.Contains(searchNome));
            }
            if (searchCargo.HasValue)
            {
                comissoesTecnicas = comissoesTecnicas.Where(ct => ct.Cargo == searchCargo.Value);
            }
            return View(comissoesTecnicas.ToList());
        }

        // GET: ComissaoTecnica/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ComissaoTecnica comissaoTecnica = db.ComissoesTecnicas
                .Include(ct => ct.Time)
                .FirstOrDefault(ct => ct.Id == id);
            if (comissaoTecnica == null)
            {
                return HttpNotFound();
            }
            return View(comissaoTecnica);
        }

        // GET: ComissaoTecnica/Create
        public ActionResult Create()
        {
            ViewBag.TimeId = new SelectList(db.Times, "Id", "Nome");
            return View();
        }

        // POST: ComissaoTecnica/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome,DataNascimento,Cargo,TimeId")] ComissaoTecnica comissaoTecnica)
        {
            if (ModelState.IsValid)
            {
                db.ComissoesTecnicas.Add(comissaoTecnica);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TimeId = new SelectList(db.Times, "Id", "Nome", comissaoTecnica.TimeId);
            return View(comissaoTecnica);
        }

        // GET: ComissaoTecnica/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ComissaoTecnica comissaoTecnica = db.ComissoesTecnicas.Find(id);
            if (comissaoTecnica == null)
            {
                return HttpNotFound();
            }
            ViewBag.TimeId = new SelectList(db.Times, "Id", "Nome", comissaoTecnica.TimeId);
            return View(comissaoTecnica);
        }

        // POST: ComissaoTecnica/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,DataNascimento,Cargo,TimeId")] ComissaoTecnica comissaoTecnica)
        {
            if (ModelState.IsValid)
            {
                db.Entry(comissaoTecnica).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TimeId = new SelectList(db.Times, "Id", "Nome", comissaoTecnica.TimeId);
            return View(comissaoTecnica);
        }

        // GET: ComissaoTecnica/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ComissaoTecnica comissaoTecnica = db.ComissoesTecnicas.Find(id);
            if (comissaoTecnica == null)
            {
                return HttpNotFound();
            }
            return View(comissaoTecnica);
        }

        // POST: ComissaoTecnica/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ComissaoTecnica comissaoTecnica = db.ComissoesTecnicas.Find(id);
            db.ComissoesTecnicas.Remove(comissaoTecnica);
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
