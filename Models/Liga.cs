using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Liga_Futebol.Models
{
    public class Liga
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",
        ApplyFormatInEditMode = true)]
        public DateTime DataInicio { get; set; }
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",
        ApplyFormatInEditMode = true)]
        public DateTime DataFim { get; set; }
        public string Localizacao { get; set; }
        public int NumeroTimes { get; set; }
        public int Rodadas { get; set; }
        public int PartidasPorRodada { get; set; }
        public string TipoCompeticao { get; set; } // Ex: "Pontos Corridos", "Eliminatória"
        public bool Status { get; set; } // Ativa ou Inativa
        // Navegação
        public virtual ICollection<Time> Times { get; set; }
        // Construtor
        public Liga()
        {
            Times = new HashSet<Time>();
            DataInicio = DateTime.Now;
            DataFim = DateTime.Now.AddMonths(6); // Exemplo de duração de 6 meses
            Status = true;
        }
    }
}