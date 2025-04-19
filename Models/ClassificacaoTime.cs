using Liga_Futebol.Models;

namespace Liga_Futebol.Controllers
{
    internal class ClassificacaoTime : HomeViewModel
    {
        public string NomeTime { get; set; }
        //public int Pontos { get; set; }
        public int Vitorias { get; set; }
        public int Empates { get; set; }
        public int Derrotas { get; set; }
        //public int GolsPro { get; set; }
        public int GolsContra { get; set; }
        //public int SaldoGols { get; set; }
    }
}