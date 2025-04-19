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
    public class PartidaController : Controller
    {
        private LigaFutebolContext db = new LigaFutebolContext();

        // GET: Partida
        public ActionResult Index()
        {
            var partidas = db.Partidas.Include(p => p.TimeCasa).Include(p => p.TimeFora);
            return View(partidas.ToList());
        }


        // GET: Partida/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Partida partida = db.Partidas
                .Include(p => p.TimeCasa)
                .Include(p => p.TimeFora)
                .Include(p => p.Estatisticas.Select(e => e.Jogador))
                .Include(p => p.Estatisticas.Select(e => e.Time))
                .Include(p => p.EstatisticasFora.Select(e => e.Jogador))
                .Include(p => p.EstatisticasFora.Select(e => e.Time))
                .FirstOrDefault(p => p.Id == id);
            if (partida == null)
            {
                return HttpNotFound();
            }
            return View(partida);
        }
        public ActionResult GerarPartidas()
        {
            db.EstatisticasPartidas.RemoveRange(db.EstatisticasPartidas);
            db.Partidas.RemoveRange(db.Partidas);
            db.SaveChanges();

            var times = db.Times.Where(t => t.Status == true).ToList();

            if (times.Count < 20)
            {
                TempData["Erro"] = "É necessário ter exatamente 20 times aptos para gerar o campeonato.";
                return RedirectToAction("Index");
            }

            var random = new Random();
            var totalTimes = times.Count;
            var rodadasTurno = new List<List<Tuple<Time, Time>>>();

            // Gerar calendário circular (round-robin) – 1º turno
            for (int rodada = 0; rodada < totalTimes - 1; rodada++)
            {
                var rodadaAtual = new List<Tuple<Time, Time>>();
                for (int i = 0; i < totalTimes / 2; i++)
                {
                    int mandanteIndex = (rodada + i) % (totalTimes - 1);
                    int visitanteIndex = (totalTimes - 1 - i + rodada) % (totalTimes - 1);

                    if (i == 0)
                        visitanteIndex = totalTimes - 1;

                    var timeCasa = times[mandanteIndex];
                    var timeFora = times[visitanteIndex];

                    rodadaAtual.Add(Tuple.Create(timeCasa, timeFora));
                }
                rodadasTurno.Add(rodadaAtual);
            }

            var dataInicial = new DateTime(2025, 1, 1);

            // Gerar partidas do 1º turno (rodadas 1 a 19)
            for (int r = 0; r < rodadasTurno.Count; r++)
            {
                foreach (var confronto in rodadasTurno[r])
                {
                    GerarPartidaEEstatisticas(confronto.Item1, confronto.Item2, dataInicial.AddDays(r * 7), r + 1, random);
                }
            }

            // Gerar partidas do 2º turno (rodadas 20 a 38) – invertendo mando de campo
            for (int r = 0; r < rodadasTurno.Count; r++)
            {
                foreach (var confronto in rodadasTurno[r])
                {
                    GerarPartidaEEstatisticas(confronto.Item2, confronto.Item1, dataInicial.AddDays((r + 19) * 7), r + 20, random);
                }
            }

            TempData["Sucesso"] = "Campeonato gerado com sucesso com 38 rodadas!";
            return RedirectToAction("Index");
        }

        private void GerarPartidaEEstatisticas(Time timeCasa, Time timeFora, DateTime data, int rodada, Random random)
        {
            int golsCasa = random.Next(0, 6);
            int golsFora = random.Next(0, 6);

            Resultado resultado;
            if (golsCasa > golsFora) resultado = Resultado.Vitoria_Time_Casa_and_Derrota_Time_Fora;
            else if (golsCasa < golsFora) resultado = Resultado.Vitoria_Time_Fora_and_Derrota_Time_Casa;
            else resultado = Resultado.Empate;

            var partida = new Partida
            {
                TimeCasaId = timeCasa.Id,
                TimeForaId = timeFora.Id,
                Data = data,
                Local = "Estádio " + timeCasa.Nome,
                GolsTimeCasa = golsCasa,
                GolsTimeFora = golsFora,
                Resultado = resultado,
                Rodada = rodada
            };

            db.Partidas.Add(partida);
            db.SaveChanges();

            var jogadoresCasa = db.Jogadores.Where(j => j.TimeId == timeCasa.Id).ToList();
            var jogadoresFora = db.Jogadores.Where(j => j.TimeId == timeFora.Id).ToList();

            for (int i = 0; i < golsCasa; i++)
            {
                if (jogadoresCasa.Any())
                {
                    var jogador = jogadoresCasa[random.Next(jogadoresCasa.Count)];
                    db.EstatisticasPartidas.Add(new EstatisticaPartida
                    {
                        JogadorId = jogador.Id,
                        PartidaId = partida.Id,
                        TimeId = timeCasa.Id,
                        GolsMarcados = 1,
                        GolsSofridos = golsFora,
                        Asistencias = 1,
                        CartoesAmarelos = random.Next(0, 2),
                        CartoesVermelhos = random.Next(0, 2)
                    });
                }
            }

            for (int i = 0; i < golsFora; i++)
            {
                if (jogadoresFora.Any())
                {
                    var jogador = jogadoresFora[random.Next(jogadoresFora.Count)];
                    db.EstatisticasPartidas.Add(new EstatisticaPartida
                    {
                        JogadorId = jogador.Id,
                        PartidaId = partida.Id,
                        TimeId = timeFora.Id,
                        GolsMarcados = 1,
                        GolsSofridos = golsCasa,
                        Asistencias = 1,
                        CartoesAmarelos = random.Next(0, 2),
                        CartoesVermelhos = random.Next(0, 2)
                    });
                }
            }

            db.SaveChanges();
        }


        // GET: Partida/Create
        public ActionResult Create()
        {
            ViewBag.TimeCasaId = new SelectList(db.Times, "Id", "Nome");
            ViewBag.TimeForaId = new SelectList(db.Times, "Id", "Nome");
            return View();
        }

        // POST: Partida/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Data,TimeCasaId,TimeForaId,GolsTimeCasa,GolsTimeFora,Local,Resultado,Rodada")] Partida partida)
        {
            if (ModelState.IsValid)
            {
                db.Partidas.Add(partida);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TimeCasaId = new SelectList(db.Times, "Id", "Nome", partida.TimeCasaId);
            ViewBag.TimeForaId = new SelectList(db.Times, "Id", "Nome", partida.TimeForaId);
            return View(partida);
        }

        // GET: Partida/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Partida partida = db.Partidas.Find(id);
            if (partida == null)
            {
                return HttpNotFound();
            }
            ViewBag.TimeCasaId = new SelectList(db.Times, "Id", "Nome", partida.TimeCasaId);
            ViewBag.TimeForaId = new SelectList(db.Times, "Id", "Nome", partida.TimeForaId);
            return View(partida);
        }

        // POST: Partida/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Data,TimeCasaId,TimeForaId,GolsTimeCasa,GolsTimeFora,Local,Resultado,Rodada")] Partida partida)
        {
            if (ModelState.IsValid)
            {
                db.Entry(partida).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TimeCasaId = new SelectList(db.Times, "Id", "Nome", partida.TimeCasaId);
            ViewBag.TimeForaId = new SelectList(db.Times, "Id", "Nome", partida.TimeForaId);
            return View(partida);
        }

        // GET: Partida/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Partida partida = db.Partidas
                .Include(p => p.TimeCasa)
                .Include(p => p.TimeFora)
                .FirstOrDefault(p => p.Id == id);
            ;
            if (partida == null)
            {
                return HttpNotFound();
            }
            return View(partida);
        }

        // POST: Partida/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Partida partida = db.Partidas.Find(id);
            db.Partidas.Remove(partida);
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
