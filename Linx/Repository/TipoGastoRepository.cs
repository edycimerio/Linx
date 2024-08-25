using Domain.Entities;
using Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class TipoGastoRepository: ITipoGastoRepository
    {
        private readonly ApplicationDbContext _context;
        public TipoGastoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<TipoGastos> Consultar(int? id)
        {
            var tipoGasto = await _context.TipoGasto.FirstOrDefaultAsync(m => m.Id == id);

            return tipoGasto;
        }
        public async Task<IList<TipoGastos>> ListTipoGastos()
        {
            var lista = await _context.TipoGasto.ToListAsync();

            return lista;
        }

        public async Task Create(TipoGastos tipo)
        {
            _context.Add(tipo);
            await _context.SaveChangesAsync();
        }
    }
}
