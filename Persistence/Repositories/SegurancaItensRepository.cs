using ApiSistema.Models;
using ApiSistema.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSistema.Persistence.Repositories
{
    public class SegurancaItensRepository : BaseRepository, ISegurancaItensRepository
    {
        public SegurancaItensRepository(AppDbContext context) : base(context)
        { }
       
        public async Task AddAsync(SegurancaItens segurancaItens)
        {
            using (var ctx = new AppDbContext())
            {

                var SegurancaF = new SegurancaItens
                {
                    tFormularioID = segurancaItens.tFormularioID,
                    tFuncionarioID = segurancaItens.tFuncionarioID,
                    Visualizar = segurancaItens.Visualizar,
                    Gravar = segurancaItens.Gravar,
                    Alterar = segurancaItens.Alterar,
                    Excluir = segurancaItens.Excluir
                    
                };

                ctx.SegurancaItens.AddAsync(segurancaItens);
                ctx.SaveChanges();
            }

            await _context.segurancas.ToListAsync();
        }

        public async Task<SegurancaItens> FindByIdAsync(int id)
        {
            return await _context.SegurancaItens.FindAsync(id);
        }

        public async Task<IEnumerable<SegurancaItens>> ListAsync()
        {
            using (var contexto = new AppDbContext())
            {

                var ListarID = (from Segur in contexto.segurancas
                                join Itens in contexto.SegurancaItens on Segur.id equals Itens.tFormularioID
                                select new SegurancaItens
                                {
                                    Id = Itens.Id,
                                    tFuncionarioID = Itens.tFuncionarioID,
                                    tFormularioID = Itens.tFormularioID,
                                    Visualizar = Itens.Visualizar,
                                    Alterar = Itens.Alterar,
                                    Gravar = Itens.Gravar,
                                    Excluir = Itens.Excluir,

                                }).ToList();

                return (IEnumerable<SegurancaItens>)ListarID;
            }
            //return await _context.SegurancaItens.ToListAsync();
        }

        public async Task<IEnumerable<SegurancaItens>> ListID(int Id, int IdUsu)
        {
            using (var contexto = new AppDbContext())
            {

                var ListarID = (from Segur in contexto.SegurancaItens
                                where Segur.tFormularioID == Id && Segur.tFuncionarioID == IdUsu

                                select new SegurancaItens

                                {
                                    Id = Segur.Id,
                                    tFuncionarioID = Segur.tFormularioID,
                                    tFormularioID = Segur.tFormularioID,
                                    Visualizar = Segur.Visualizar,
                                    Gravar = Segur.Gravar,
                                    Alterar = Segur.Alterar,
                                    Excluir = Segur.Excluir


                                }).ToList();

                return (IEnumerable<SegurancaItens>)ListarID;
            }
        }

        //public async Task<IEnumerable<SegurancaItens>> ListID(int Id, int IdUsu)
        //{
        //    using (var contexto = new AppDbContext())
        //    {

        //        var ListarID = (from Segur in contexto.SegurancaItens
        //                        where Segur.tFormularioID == Id && Segur.tFuncionarioID == IdUsu

        //                        select new SegurancaItens

        //                        {
        //                            Id = Segur.Id,
        //                            tFuncionarioID = Segur.tFormularioID,
        //                            tFormularioID = Segur.tFormularioID,
        //                            Visualizar = Segur.Visualizar,
        //                            Gravar = Segur.Gravar,
        //                            Alterar = Segur.Alterar,
        //                            Excluir = Segur.Excluir


        //                        }).ToList();

        //        return (IEnumerable<SegurancaItens>)ListarID;
        //    }
        //}

        public async Task<IEnumerable<SegurancaItens>> ListNomes(string name)
        {
            return await _context.SegurancaItens.ToListAsync();
        }

        public Task<IEnumerable<SegurancaItens>> ListNomesID(int Id)
        {
            throw new NotImplementedException();
        }

        public void Remove(SegurancaItens segurancaItens)
        {
            _context.SegurancaItens.Remove(segurancaItens);
            _context.SaveChanges();
        }

        public void Update(SegurancaItens segurancaItens)
        {
            using (var ctx = new AppDbContext())
            {

                var Seg = new SegurancaItens
                {
                    Id = segurancaItens.Id,
                    tFormularioID = segurancaItens.tFormularioID,
                    tFuncionarioID = segurancaItens.tFuncionarioID,
                    Visualizar = segurancaItens.Visualizar,
                    Gravar = segurancaItens.Gravar,
                    Alterar = segurancaItens.Alterar,
                    Excluir = segurancaItens.Excluir

                };

                ctx.SegurancaItens.Update(segurancaItens);
                ctx.SaveChanges();
            }
        }

        
        
    }
}
