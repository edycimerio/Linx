using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repository
{
    public interface ITipoGastoRepository
    {
        Task<TipoGastos> Consultar(int? id);
        Task<IList<TipoGastos>> ListTipoGastos();
        Task Create(TipoGastos tipo);
    }
}
