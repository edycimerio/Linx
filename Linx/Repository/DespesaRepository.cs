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
    public class DespesaRepository: IDespesaRepository
    {
        private readonly ApplicationDbContext _context;
        public DespesaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Despesa> Consultar(int? id)
        {
            var despesas = await _context.Despesa
                .FirstOrDefaultAsync(m => m.Id == id);

            return despesas;
        }
        public async Task Create(Despesa despesas)
        {
            _context.Add(despesas);
            await _context.SaveChangesAsync();
        }

        public async Task Edit(Despesa despesas)
        {
            _context.Update(despesas);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var despesas = await _context.Despesa.FindAsync(id);

            _context.Remove(despesas);
            await _context.SaveChangesAsync();
        }

        public async Task<IList<Despesa>> ListDespesas()
        {
            var lista = await _context.Despesa.ToListAsync();

            return lista;
        }
    }
}
