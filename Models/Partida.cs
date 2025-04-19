using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Liga_Futebol.Models
{
    public enum Resultado
    {
        Vitoria,
        Vitoria_Time_Casa_and_Derrota_Time_Fora,
        Vitoria_Time_Fora_and_Derrota_Time_Casa,
        Empate,
        Derrota,
        Derrota_Time_Casa_and_Vitoria_Time_Fora,
        Derrota_Time_Fora_and_Vitoria_Time_Casa
    }


    public class Partida
    {
        public int Id { get; set; }
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",
        ApplyFormatInEditMode = true)]
        public DateTime Data { get; set; }
        public Time TimeCasa { get; set; }
        public Time TimeFora { get; set; }
        public int TimeCasaId { get; set; }
        public int TimeForaId { get; set; }
        public int GolsTimeCasa { get; set; }
        public int GolsTimeFora { get; set; }
        public string Local { get; set; }
        public Resultado Resultado { get; set; }
        public int Rodada { get; set; }

        public ICollection<EstatisticaPartida> Estatisticas { get; set; }
        public ICollection<EstatisticaPartida> EstatisticasFora { get; set; } // Adicionando a propriedade de navegação para EstatisticaPartida
        public ICollection<Time> Times { get; set; } // Adicionando a propriedade de navegação para Time

        public Partida(int timeCasaId, int timeForaId, DateTime data, string local, int rodada)
        {
            TimeCasaId = timeCasaId;
            TimeForaId = timeForaId;
            Data = data;
            Local = local;
            Rodada = rodada;
            Estatisticas = new List<EstatisticaPartida>();
            EstatisticasFora = new List<EstatisticaPartida>();
        }


        public Partida()
        {
            GolsTimeCasa = 0;
            GolsTimeFora = 0;
        }
    }
}