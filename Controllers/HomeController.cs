using Liga_Futebol.BancoDados;
using Liga_Futebol.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace Liga_Futebol.Controllers
{
    public class HomeController : Controller
    {
        private LigaFutebolContext db = new LigaFutebolContext();
        public ActionResult Index()
        {
            var times = db.Times.Include(t => t.Jogadores).Include(t => t.ComissaoTecnica).ToList();
            var partidas = db.Partidas.Include(p => p.TimeCasa).Include(p => p.TimeFora).ToList();
            var classificacao = new List<ClassificacaoDTO>();

            bool ligaApta = VerificarLigaApta(times);

            foreach (var time in times)
            {
                int pontos = 0, vitorias = 0, empates = 0, derrotas = 0, golsPro = 0, golsContra = 0;

                var partidasCasa = partidas.Where(p => p.TimeCasaId == time.Id);
                var partidasFora = partidas.Where(p => p.TimeForaId == time.Id);

                foreach (var partida in partidasCasa)
                {
                    golsPro += partida.GolsTimeCasa;
                    golsContra += partida.GolsTimeFora;

                    if (partida.GolsTimeCasa > partida.GolsTimeFora)
                        vitorias++;
                    else if (partida.GolsTimeCasa == partida.GolsTimeFora)
                        empates++;
                    else
                        derrotas++;
                }

                foreach (var partida in partidasFora)
                {
                    golsPro += partida.GolsTimeFora;
                    golsContra += partida.GolsTimeCasa;

                    if (partida.GolsTimeFora > partida.GolsTimeCasa)
                        vitorias++;
                    else if (partida.GolsTimeFora == partida.GolsTimeCasa)
                        empates++;
                    else
                        derrotas++;
                }

                pontos = (vitorias * 3) + empates;

                classificacao.Add(new ClassificacaoDTO
                {
                    Nome = time.Nome,
                    Pontos = pontos,
                    Vitorias = vitorias,
                    Empates = empates,
                    Derrotas = derrotas,
                    GolsPro = golsPro,
                    GolsContra = golsContra,
                    SaldoGols = Math.Max(0, golsPro - golsContra)
                });
            }

            var classificacaoOrdenada = classificacao
                .OrderByDescending(c => c.Pontos)
                .ThenByDescending(c => c.SaldoGols)
                .ThenByDescending(c => c.GolsPro)
                .ToList();

            var ligaApta = VerificarLigaApta(times);

            var viewModel = new HomeViewModel
            {
                Times = times,
                Classificacao = classificacaoOrdenada,
                Status = ligaApta
            };

            return View(viewModel);
        }

        private bool VerificarLigaApta(List<Time> times)
        {
            if (times.Count < 19)
                return false;

            //foreach (var time in times)
            //{
            //    if (time.Jogadores == null || time.Jogadores.Count < 15)
            //        return false;

            //    if (time.ComissaoTecnica == null || time.ComissaoTecnica.Count < 5)
            //        return false;

            //    var cargosDistintos = time.ComissaoTecnica.Select(c => c.Cargo).Distinct().Count();
            //    if (cargosDistintos < 5)
            //        return false;
            //}

            return true;
        }

        //public ActionResult Classificacao()
        //{
        //    var times = db.Times.ToList();
        //    var partidas = db.Partidas.ToList();

        //    var classificacao = new List<ClassificacaoTime>();

        //    foreach (var time in times)
        //    {
        //        int pontos = 0, vitorias = 0, empates = 0, derrotas = 0, golsPro = 0, golsContra = 0;

        //        var partidasCasa = partidas.Where(p => p.TimeCasaId == time.Id && p.GolsCasa.HasValue && p.GolsFora.HasValue);
        //        var partidasFora = partidas.Where(p => p.TimeForaId == time.Id && p.GolsCasa.HasValue && p.GolsFora.HasValue);

        //        foreach (var partida in partidasCasa)
        //        {
        //            golsPro += partida.GolsCasa.Value;
        //            golsContra += partida.GolsFora.Value;

        //            if (partida.GolsCasa > partida.GolsFora)
        //                vitorias++;
        //            else if (partida.GolsCasa == partida.GolsFora)
        //                empates++;
        //            else
        //                derrotas++;
        //        }

        //        foreach (var partida in partidasFora)
        //        {
        //            golsPro += partida.GolsFora.Value;
        //            golsContra += partida.GolsCasa.Value;

        //            if (partida.GolsFora > partida.GolsCasa)
        //                vitorias++;
        //            else if (partida.GolsFora == partida.GolsCasa)
        //                empates++;
        //            else
        //                derrotas++;
        //        }

        //        pontos = (vitorias * 3) + (empates * 1);

        //        classificacao.Add(new ClassificacaoTime
        //        {
        //            NomeTime = time.Nome,
        //            Pontos = pontos,
        //            Vitorias = vitorias,
        //            Empates = empates,
        //            Derrotas = derrotas,
        //            GolsPro = golsPro,
        //            GolsContra = golsContra,
        //            SaldoGols = golsPro - golsContra
        //        });
        //    }

        //    var classificacaoOrdenada = classificacao
        //        .OrderByDescending(c => c.Pontos)
        //        .ThenByDescending(c => c.SaldoGols)
        //        .ThenByDescending(c => c.GolsPro)
        //        .ToList();

        //    return View(classificacaoOrdenada);
        //}

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}