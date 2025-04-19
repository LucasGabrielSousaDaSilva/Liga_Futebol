using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Liga_Futebol.Models
{
    public class Time
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Status { get; set; }
        public string CorUniformesPrimaria { get; set; }
        public string CorUniformesSecundaria { get; set; }
        public int DataFundacao { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string EstadioTime { get; set; }
        public int CapacidadeEstagio { get; set; }
        //public int Vitorias { get; set; }
        //public int Empates { get; set; }
        //public int Derrotas { get; set; }
        //public int GolsMarcados { get; set; }
        //public int GolsSofridos { get; set; }

        // Navegação
        public virtual ICollection<Jogador> Jogadores { get; set; }
        public virtual ICollection<ComissaoTecnica> ComissaoTecnica { get; set; }
        public virtual ICollection<EstatisticaPartida> Estatisticas { get; set; }

        public virtual ICollection<Partida> PartidaCasa { get; set; }
        public virtual ICollection<Partida> PartidaFora { get; set; }

        // Construtor
        public Time()
        {
            Jogadores = new HashSet<Jogador>();
            //Vitorias = 0;
            //Empates = 0;
            //Derrotas = 0;
            //GolsMarcados = 0;
            //GolsSofridos = 0;
        }
    }
}