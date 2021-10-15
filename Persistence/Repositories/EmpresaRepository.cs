using ApiSistema.Persistence.Context;
using ApiSistema.Persistence.Repositories;
using ApiSistema.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSistema.Persistence.Repositories
{
    public class EmpresaRepository : BaseRepository, IEmpresaRepository
    {
        public EmpresaRepository(AppDbContext context) : base(context)
        { }

        public async Task AddAsync(Empresa empresas)
        {
            using (var ctx = new AppDbContext())
            {

                ctx.empresas.AddAsync(empresas);
                ctx.SaveChanges();
            }

            await _context.empresas.ToListAsync();
        }


        public async Task<Empresa> FindByIdAsync(int id)
        {
            return await _context.empresas.FindAsync(id);
        }

        public async Task<IEnumerable<Empresa>> ListAsync()
        {
            return await _context.empresas.ToListAsync();
        }

        public async Task<IEnumerable<Empresa>> ListNomes(string name)
        {
            return await _context.empresas.ToListAsync();
        }

        public Task<IEnumerable<Empresa>> ListNomesID(int Id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Empresa empresa)
        {
            _context.empresas.Remove(empresa);
            _context.SaveChanges();
        }

        public void Update(Empresa empresa)
        {
            using (var ctx = new AppDbContext())
            {
                ctx.empresas.Update(empresa);
                ctx.SaveChanges();
            }
        }
    }
}
