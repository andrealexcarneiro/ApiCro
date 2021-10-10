using ApiCro.Interfaces;
using ApiCro.Models;
using ApiCro.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCro.Repositories
{
    public class RepositoryGenerics<T> : IGeneric<T> where T : class

    {
        private readonly DbContextOptions<AppDbContext> _OptionsBuilder;

        public RepositoryGenerics()
        {
            _OptionsBuilder = new DbContextOptions<AppDbContext>();
        }

        public async Task Add(T Objeto)
        {
            using (var data = new AppDbContext(_OptionsBuilder))
            {
                await data.Set<T>().AddAsync(Objeto);
                await data.SaveChangesAsync();
            }
        }

        public async Task Delete(T Objeto)
        {
            using (var data = new AppDbContext(_OptionsBuilder))
            {
                data.Set<T>().Remove(Objeto);
                await data.SaveChangesAsync();
            }
        }

        public async Task<T> GetEntityById(int Id)
        {
            using (var data = new AppDbContext(_OptionsBuilder))
            {
                return await data.Set<T>().FindAsync(Id);
            }
        }

        public async Task<List<T>> List()
        {
            using (var data = new AppDbContext(_OptionsBuilder))
            {
                return await data.Set<T>().AsNoTracking().ToListAsync();
            }
        }

        public async Task Update(T Objeto)
        {
            using (var data = new AppDbContext(_OptionsBuilder))
            {
                data.Set<T>().Update(Objeto);
                await data.SaveChangesAsync();
            }
        }
    }
}
