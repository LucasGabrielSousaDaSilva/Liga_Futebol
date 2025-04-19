using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Liga_Futebol.Models
{
        public enum Posicao
        {
            Goleiro,
            Zagueiro,
            Lateral,
            MeioCampo,
            Atacante,
            Defensor,
            Volante,
            Meia
    }

        public enum PePreferido
        {
            Direito,
            Esquerdo,
            Ambidestro
        }

        public class Jogador
        {

            public Jogador()
            {
                Estatisticas = new HashSet<EstatisticaPartida>();
            }

            public int Id { get; set; }
            public string Nome { get; set; }

            [Display(Name = "Data de Nascimento")]
            [DataType(DataType.Date)]
            [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",
            ApplyFormatInEditMode = true)]
            public DateTime DataNascimento { get; set; }
            public string Nacionalidade { get; set; }
            public Posicao Posicao { get; set; }
            public int NumCamisa { get; set; }
            [DisplayFormat(DataFormatString = "{0:0.00}")]
            [DataType(DataType.Currency)]
            [Display(Name = "Altura (cm)")]
            public Decimal Altura { get; set; }


            [DisplayFormat(DataFormatString = "{0:0.00}")]
            [DataType(DataType.Currency)]
            [Display(Name = "Peso (kg)")]
            public Decimal Peso { get; set; }
            public PePreferido PePreferido { get; set; }
            public Time Time { get; set; }

            public ICollection<EstatisticaPartida> Estatisticas { get; set; }
            public int TimeId { get; set; } // Chave estrangeira para a tabela Time

    }
}