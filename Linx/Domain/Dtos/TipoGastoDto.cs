using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos
{
    public class TipoGastoDto
    {
        public int Codigo { get; set; }
        public string NomeGasto { get; set; }
    }
}
