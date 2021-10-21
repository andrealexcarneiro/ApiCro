using ApiSistema.Models;
using ApiSistema.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSistema.Persistence.Repositories
{
    public class UfRepository : BaseRepository, IUFRepository
    {
        public UfRepository(AppDbContext context) : base(context)
        { }

        public async Task<IEnumerable<UF>> ListAsync()
        {
            return await _context.uFs.ToListAsync();
        }

        public async Task<IEnumerable<UF>> ListNomes(string name)
        {
            return await _context.uFs.ToListAsync();
        }
    }
}
