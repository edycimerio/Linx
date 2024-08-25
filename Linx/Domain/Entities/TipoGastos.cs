using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class TipoGastos
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Descricao { get; set; }
    }
}
