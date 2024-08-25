using System.ComponentModel;

namespace WebApp.Models
{
    public class ListaDespesaModel
    {
        [DisplayName("Id")]
        public int Id { get; set; }
        [DisplayName("Código Tipo de Despesa")]
        public int CodTipoGasto { get; set; }
        
        [DisplayName("Tipo de Gasto")]
        public string DescicaoTipoGasto { get; set; }

        [DisplayName("Valor do Lançamento")]
        public DateTime DataGasto { get; set; }

        [DisplayName("Descrição")]
        public string DescricaoGeral { get; set; }

        [DisplayName("Valor do Lançamento")]
        public decimal ValorGasto { get; set; }
    }
}
