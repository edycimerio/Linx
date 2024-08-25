using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos
{
    public class ListaDespesaDto
    {
        public int Id { get; set; }
        public int CodTipoGasto { get; set; }
        public string DescicaoTipoGasto { get; set; }

        public DateTime DataGasto { get; set; }

        public string DescricaoGeral { get; set; }

        public decimal ValorGasto { get; set; }    
    }
}
