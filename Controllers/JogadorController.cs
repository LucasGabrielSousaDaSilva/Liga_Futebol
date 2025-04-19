using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Futebol.Models;
using Liga_Futebol.BancoDados;
using Liga_Futebol.Models;

namespace Liga_Futebol.Controllers
{
    public class JogadorController : Controller
    {
        private LigaFutebolContext db = new LigaFutebolContext();

        // GET: Jogador
        public ActionResult Index(string searchNome, Posicao? searchPosicao, PePreferido? searchPePreferido)
        {
            var jogadores = db.Jogadores.Include("Time").AsQueryable();

            if (!string.IsNullOrEmpty(searchNome))
            {
                jogadores = jogadores.Where(j => j.Nome.Contains(searchNome));
            }

            if (searchPosicao.HasValue)
            {
                jogadores = jogadores.Where(j => j.Posicao == searchPosicao.Value);
            }

            if (searchPePreferido.HasValue)
            {
                jogadores = jogadores.Where(j => j.PePreferido == searchPePreferido.Value);
            }
            return View(jogadores.ToList());
        }

        // GET: Jogador/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Jogador jogador = db.Jogadores.Include(j => j.Time).FirstOrDefault(j => j.Id == id);
            if (jogador == null)
            {
                return HttpNotFound();
            }
            return View(jogador);
        }

        // GET: Jogador/Create
        public ActionResult Create()
        {
            ViewBag.TimeId = new SelectList(db.Times, "Id", "Nome");
            return View();
        }

        // POST: Jogador/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome,DataNascimento,Nacionalidade,Posicao,NumCamisa,Altura,Peso,PePreferido,TimeId")] Jogador jogador)
        {
            if (ModelState.IsValid)
            {
                db.Jogadores.Add(jogador);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TimeId = new SelectList(db.Times, "Id", "Nome", jogador.TimeId);
            return View(jogador);
        }

        // GET: Jogador/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Jogador jogador = db.Jogadores.Find(id);
            if (jogador == null)
            {
                return HttpNotFound();
            }
            ViewBag.TimeId = new SelectList(db.Times, "Id", "Nome", jogador.TimeId);
            return View(jogador);
        }

        // POST: Jogador/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,DataNascimento,Nacionalidade,Posicao,NumCamisa,Altura,Peso,PePreferido,TimeId")] Jogador jogador)
        {
            if (ModelState.IsValid)
            {
                db.Entry(jogador).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TimeId = new SelectList(db.Times, "Id", "Nome", jogador.TimeId);
            return View(jogador);
        }

        // GET: Jogador/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Jogador jogador = db.Jogadores.Find(id);
            if (jogador == null)
            {
                return HttpNotFound();
            }
            return View(jogador);
        }

        // POST: Jogador/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Jogador jogador = db.Jogadores.Find(id);
            db.Jogadores.Remove(jogador);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult RankingArtilheiros()
        {
            var jogadores = db.Jogadores.ToList();
            var estatisticas = db.EstatisticasPartidas.ToList();

            var ranking = jogadores
                .Select(j => new RankingArtilheiroViewModel
                {
                    JogadorNome = j.Nome,
                    TimeNome = db.Times.FirstOrDefault(t => t.Id == j.TimeId)?.Nome ?? "Sem Time",
                    TotalGols = estatisticas.Where(e => e.JogadorId == j.Id).Sum(e => e.GolsMarcados)
                })
                .OrderByDescending(x => x.TotalGols)
                .ThenBy(x => x.JogadorNome)
                .ToList();

            return View(ranking);
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
