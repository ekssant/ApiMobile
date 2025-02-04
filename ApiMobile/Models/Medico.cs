﻿using System.ComponentModel.DataAnnotations;

namespace ApiMobile.Models
{
    public class Medico
    {
        [Key]
        public int IdMedico { get; set; }
        public string Nome { get; set; }
        public string NumeroCrm { get; set; }
        public string UfCrm { get; set; }
        public string SituacaoCrm { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
