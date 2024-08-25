using Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Service
{
    public interface ITipoGastoService
    {
        Task<TipoGastoDto> Consultar(int? id);
        Task<IList<TipoGastoDto>> ListTipoGastos();
        Task<bool> Create(TipoGastoDto tipo);
    }
}
