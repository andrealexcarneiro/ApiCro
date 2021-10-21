using ApiSistema.Models;
using ApiSistema.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSistema.Persistence.Repositories
{
    public class CidadeRepository : BaseRepository, ICidadeRepository
    {
        public CidadeRepository(AppDbContext context) : base(context)
        { }

        public async Task AddAsync(Cidades cidade)
        {
            using (var ctx = new AppDbContext())
            {

                ctx.cidade.AddAsync(cidade);
                ctx.SaveChanges();
            }

            await _context.cidade.ToListAsync();
        }

        public async Task<Cidades> FindByIdAsync(int id)
        {
            return await _context.cidade.FindAsync(id);
        }

        public async Task<IEnumerable<Cidades>> ListAsync()
        {
            return await _context.cidade.ToListAsync();
        }

        public async Task<IEnumerable<Cidades>> ListNomes(string name)
        {
            return await _context.cidade.ToListAsync();
        }

        public Task<IEnumerable<Cidades>> ListNomesID(int Id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Cidades cidade)
        {
            _context.cidade.Remove(cidade);
            _context.SaveChanges();
        }

        public void Update(Cidades cidade)
        {
            using (var ctx = new AppDbContext())
            {
                ctx.cidade.Update(cidade);
                ctx.SaveChanges();
            }
        }
    }
}
