using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Liga_Futebol.Models
{
    public enum Cargo
    {
        Treinador,
        PreparadorFisico,
        Massagista,
        Medico,
        AnalistaDeDesempenho,
        TreinadorDeGoleiros,
        Fisioterapeuta,
        Auxiliar
    }

    public class ComissaoTecnica
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",
        ApplyFormatInEditMode = true)]
        public DateTime DataNascimento { get; set; }
        //public string Nacionalidade { get; set; }
        //public string CPF { get; set; }
        //public string RG { get; set; }
        //public string Telefone { get; set; }
        //public string Email { get; set; }
        public Cargo Cargo { get; set; }


        // Chave estrangeira
        public int TimeId { get; set; }
        public Time Time { get; set; }
        // Construtor
        public ComissaoTecnica()
        {
            // Inicialização de propriedades, se necessário
        }
    }
}