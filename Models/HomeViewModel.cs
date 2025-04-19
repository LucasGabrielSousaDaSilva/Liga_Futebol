using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Liga_Futebol.Models
{
    public class HomeViewModel
    {
        public List<ClassificacaoDTO> Classificacao { get; set; }
        public List<ArtilheiroDTO> Artilheiros { get; set; }
        public List<Time> Times { get; internal set; }
        public bool Status { get; internal set; }
        public object Pontos { get; internal set; }
        public object SaldoGols { get; internal set; }
        public object GolsPro { get; internal set; }
    }

    public class ClassificacaoDTO
    {
        public string Nome { get; set; }
        public int Pontos { get; set; }
        public int PartidasJogadas { get; set; }
        public int Vitorias { get; set; }
        public int Empates { get; set; }
        public int Derrotas { get; set; }
        public int GolsPro { get; set; }
        public int GolsContra { get; set; }
        public int SaldoGols { get; internal set; }
    }

    public class ArtilheiroDTO
    {
        public string Nome { get; set; }
        public string Time { get; set; }
        public int Gols { get; set; }
    }
}