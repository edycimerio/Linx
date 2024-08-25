using System.ComponentModel;

namespace WebApp.Models
{
    public class TipoGastoModel
    {
        [DisplayName("Id")]
        public int Codigo { get; set; }
        
        [DisplayName("Tipo de Despesa")]
        public string NomeGasto { get; set; }
    }
}
