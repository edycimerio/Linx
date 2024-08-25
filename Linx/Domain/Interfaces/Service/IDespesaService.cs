using Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Service
{
    public interface IDespesaService
    {
        Task<DespesaDto> Consultar(int? id);
        Task<bool> Create(DespesaDto produto);
        Task<bool> Edit(DespesaDto produto);
        Task<bool> Delete(int id);
        Task<IList<ListaDespesaDto>> ListDespesas();
    }
}
