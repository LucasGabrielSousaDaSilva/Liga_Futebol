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
    public class EstatisticaPartidaController : Controller
    {
        private LigaFutebolContext db = new LigaFutebolContext();

        // GET: EstatisticaPartida
        public ActionResult Index()
        {
            var estatisticasPartidas = db.EstatisticasPartidas.Include(e => e.Jogador).Include(e => e.Partida).Include(e => e.Time);
            return View(estatisticasPartidas.ToList());
        }

        // GET: EstatisticaPartida/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EstatisticaPartida estatisticaPartida = db.EstatisticasPartidas
                .Include(e => e.Jogador)
                .Include(e => e.Partida)
                .Include(e => e.Time)
                .FirstOrDefault(e => e.Id == id);
            if (estatisticaPartida == null)
            {
                return HttpNotFound();
            }
            return View(estatisticaPartida);
        }

        // GET: EstatisticaPartida/Create
        public ActionResult Create()
        {
            ViewBag.JogadorId = new SelectList(db.Jogadores, "Id", "Nome");
            ViewBag.PartidaId = new SelectList(db.Partidas, "Id", "Local");
            return View();
        }

        // POST: EstatisticaPartida/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,PartidaId,JogadorId,TimeId,GolsMarcados,GolsSofridos,Asistencias,CartoesAmarelos,CartoesVermelhos")] EstatisticaPartida estatisticaPartida)
        {
            if (ModelState.IsValid)
            {
                db.EstatisticasPartidas.Add(estatisticaPartida);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.JogadorId = new SelectList(db.Jogadores, "Id", "Nome", estatisticaPartida.JogadorId);
            ViewBag.PartidaId = new SelectList(db.Partidas, "Id", "Local", estatisticaPartida.PartidaId);
            return View(estatisticaPartida);
        }

        // GET: EstatisticaPartida/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EstatisticaPartida estatisticaPartida = db.EstatisticasPartidas.Find(id);
            if (estatisticaPartida == null)
            {
                return HttpNotFound();
            }
            ViewBag.JogadorId = new SelectList(db.Jogadores, "Id", "Nome", estatisticaPartida.JogadorId);
            ViewBag.PartidaId = new SelectList(db.Partidas, "Id", "Local", estatisticaPartida.PartidaId);
            return View(estatisticaPartida);
        }

        // POST: EstatisticaPartida/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,PartidaId,JogadorId,TimeId,GolsMarcados,GolsSofridos,Asistencias,CartoesAmarelos,CartoesVermelhos")] EstatisticaPartida estatisticaPartida)
        {
            if (ModelState.IsValid)
            {
                db.Entry(estatisticaPartida).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.JogadorId = new SelectList(db.Jogadores, "Id", "Nome", estatisticaPartida.JogadorId);
            ViewBag.PartidaId = new SelectList(db.Partidas, "Id", "Local", estatisticaPartida.PartidaId);
            return View(estatisticaPartida);
        }

        // GET: EstatisticaPartida/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EstatisticaPartida estatisticaPartida = db.EstatisticasPartidas.Find(id);
            if (estatisticaPartida == null)
            {
                return HttpNotFound();
            }
            return View(estatisticaPartida);
        }

        // POST: EstatisticaPartida/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EstatisticaPartida estatisticaPartida = db.EstatisticasPartidas.Find(id);
            db.EstatisticasPartidas.Remove(estatisticaPartida);
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