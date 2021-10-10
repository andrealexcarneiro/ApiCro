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
    public class CadBIRepository : BaseRepository, ICadastroBIRepository
    {
        public CadBIRepository(AppDbContext context) : base(context)
        { }

        public async Task AddAsync(CadastroBI cadastroBI)
        {
           

                using (var ctx = new AppDbContext())
                {

                    var cadBIF = new CadastroBI
                    {
                        Caminho = cadastroBI.Caminho,
                        Nome = cadastroBI.Nome,
                        Permissao = cadastroBI.Permissao
                       
                    };

                    ctx.cadastroBIs.AddAsync(cadastroBI);
                    ctx.SaveChanges();
                }

                await _context.caixaCabs.ToListAsync();
            
        }
        public async Task<IEnumerable<CadastroBI>> ListNomes()
        {
            
            return await _context.cadastroBIs.ToListAsync();
        }
        public async Task<CadastroBI> FindByIdAsync(int id)
        {
            return await _context.cadastroBIs.FindAsync(id);
        }

        public async Task<IEnumerable<CadastroBI>> ListAsync()
        {
            return await _context.cadastroBIs.ToListAsync();
        }

        public async Task<IEnumerable<CadastroBI>> ListNomes(string name)
        {
            using (var contexto = new AppDbContext())
            {
                var resultado = contexto.cadastroBIs
                                         .Where(m => EF.Functions.Like(m.Nome, "%" + name + "%"))
                                         .ToList();

                return (IEnumerable<CadastroBI>)resultado;
            }
        }

        public async Task<IEnumerable<CadastroBI>> ListNomesID(int Id)
        {
            using (var contexto = new AppDbContext())
            {

                var ListarID = (from CadBI in contexto.cadastroBIs
                                join Permissoes in contexto.permissao on CadBI.ID equals Permissoes.tCadastroBI_ID
                                select new CadastroBI
                                {
                                    ID = CadBI.ID,
                                    Nome = CadBI.Nome,
                                    Caminho = CadBI.Caminho

                                }).ToList();

                return (IEnumerable<CadastroBI>)ListarID;
            }
        }

        public void Remove(CadastroBI cadastroBI)
        {
            _context.cadastroBIs.Remove(cadastroBI);
            _context.SaveChanges();
        }

        public void Update(CadastroBI cadastroBI)
        {
            using (var ctx = new AppDbContext())
            {
                var CadBi = new CadastroBI
                {
                    ID = cadastroBI.ID,
                    Caminho = cadastroBI.Caminho,
                    Nome = cadastroBI.Nome,
                    Permissao = cadastroBI.Permissao
                };

                ctx.cadastroBIs.Update(cadastroBI);
                ctx.SaveChanges();
            }
        }

        public async Task<IEnumerable<CadastroBI>> ListID(int Id)
        {
           using (var contexto = new AppDbContext())
            {

                var ListarID = (from CadBI in contexto.cadastroBIs
                                join Permissoes in contexto.permissao on CadBI.ID equals Permissoes.tCadastroBI_ID
                                where Permissoes.tFuncionario_ID == Id  

                                select new CadastroBI
                                
                                {
                                    ID = CadBI.ID,
                                    Nome = CadBI.Nome,
                                    Caminho = CadBI.Caminho

                                }).ToList();

                return (IEnumerable<CadastroBI>)ListarID;
            }
        }
    }
}
