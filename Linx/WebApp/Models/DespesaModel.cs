using System.ComponentModel;

namespace WebApp.Models
{
    public class DespesaModel
    {
        [DisplayName("Id")]
        public int Id { get; set; }
        [DisplayName("Código Tipo de Despesa")]
        public int CodTipoGasto { get; set; }

        [DisplayName("Valor do Lançamento")]
        public DateTime DataGasto { get; set; }

        [DisplayName("Descrição")]
        public string DescricaoGeral { get; set; }

        [DisplayName("Valor do Lançamento")]
        public decimal ValorGasto { get; set; }
    }
}
