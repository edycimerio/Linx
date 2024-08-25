using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repository
{
    public interface IDespesaRepository
    {
        Task<Despesa> Consultar(int? id);
        Task Create(Despesa despesa);
        Task Edit(Despesa despesa);
        Task Delete(int id);
        Task<IList<Despesa>> ListDespesas();
    }
}
