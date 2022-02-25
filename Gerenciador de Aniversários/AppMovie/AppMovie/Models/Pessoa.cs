using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppMovie.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        [DataType(DataType.Date)]
        public DateTime Nascimento { get; set; }
        public int DiasParaNiver(DateTime aniversario)
        {
            DateTime dataAtual = DateTime.Today;
            DateTime proximaData = aniversario.AddYears(dataAtual.Year - aniversario.Year);

            if (proximaData < dataAtual)
                proximaData = proximaData.AddYears(1);

            int numeroDias = (proximaData - dataAtual).Days;

            return numeroDias;
        }
    }
}
