using ApiSistema.Models;
using ApiSistema.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSistema.Persistence.Repositories
{
    public class CnaeRepository : BaseRepository, ICnaeRepository
    {
        public CnaeRepository(AppDbContext context) : base(context)
        { }

        public async Task AddAsync(Cnae canes)
        {
            using (var ctx = new AppDbContext())
            {

                ctx.cnaes.AddAsync(canes);
                ctx.SaveChanges();
            }

            await _context.cnaes.ToListAsync();
        }

        public async Task<Cnae> FindByIdAsync(int id)
        {
            return await _context.cnaes.FindAsync(id);
        }

        public async Task<IEnumerable<Cnae>> ListAsync()
        {
            return await _context.cnaes.ToListAsync();
        }

        public async Task<IEnumerable<Cnae>> ListNomes(string name)
        {
            return await _context.cnaes.ToListAsync();
        }

        public Task<IEnumerable<Cnae>> ListNomesID(int Id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Cnae cnaes)
        {
            _context.cnaes.Remove(cnaes);
            _context.SaveChanges();
        }

        public void Update(Cnae cnaes)
        {
            using (var ctx = new AppDbContext())
            {
                ctx.cnaes.Update(cnaes);
                ctx.SaveChanges();
            }
        }
    }
}
