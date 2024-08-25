using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos
{
    public class DespesaDto
    {
        public int Id { get; set; }

        [Required]
        public int IdTipoGasto { get; set; }

        [Required]
        public DateTime DataLancamento { get; set; }

        [Required]
        public string Observacao { get; set; }

        [Required]
        public decimal ValorLancamento { get; set; }
    }
}
