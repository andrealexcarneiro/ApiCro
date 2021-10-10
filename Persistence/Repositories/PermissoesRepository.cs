using ApiCro.Models;
using ApiCro.Persistence.Context;
using ApiCro.Repositories;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCro.Persistence.Repositories
{
    public class PermissoesRepository : BaseRepository, IPermissaoRepository
    {
        public PermissoesRepository(AppDbContext context) : base(context)
        { }

        public async Task AddAsync(Permissoes permissao)
        {
            using (var ctx = new AppDbContext())
            {

                var PermissoesF = new Permissoes
                {
                    tFuncionario_ID = permissao.tFuncionario_ID,
                    Permissao = permissao.Permissao,
                    tCadastroBI_ID = permissao.tCadastroBI_ID
                   
                };

                ctx.permissao.AddAsync(permissao);
                ctx.SaveChanges();
            }

            await _context.permissao.ToListAsync();
        }
        public async Task<IEnumerable<Permissoes>> ListNomes()
        {
            
            return await _context.permissao.ToListAsync();
        }
        public async Task<Permissoes> FindByIdAsync(int id)
        {
            return await _context.permissao.FindAsync(id);
        }

        public async Task<IEnumerable<Permissoes>> ListAsync()
        {
            return await _context.permissao.ToListAsync();
        }

        public Task<IEnumerable<Permissoes>> ListNomes(string name)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Permissoes>> ListNomesID(int Id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Permissoes permissao)
        {
            _context.permissao.Remove(permissao);
            _context.SaveChanges();
        }

        public void Update(Permissoes permissao)
        {
            using (var ctx = new AppDbContext())
            {

                var Permi = new Permissoes
                {
                    ID = permissao.ID,
                    tFuncionario_ID = permissao.tFuncionario_ID,
                    Permissao = permissao.Permissao,
                    tCadastroBI_ID = permissao.tCadastroBI_ID
                };

                ctx.permissao.Update(Permi);
                ctx.SaveChanges();
            }
        }
    }
}
