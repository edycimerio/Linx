using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    
    public class Despesa
    {
        public int Id { get; set; }

        [Required]        
        public int TipoGasto { get; set; }

        [Required]
        public DateTime Data { get; set; }

        [Required]
        public string Descricao { get; set; }

        [Required]        
        public decimal Valor { get; set; }

       

    }
}
