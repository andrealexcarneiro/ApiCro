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
    public class CaixaCabRepository : BaseRepository, ICaixaCabRepository
    {
        
        public CaixaCabRepository(AppDbContext context) : base(context)
        { }
        
        public async Task AddAsync(CaixaCab caixaCab)
        {

            using (var ctx = new AppDbContext())
            {

                var CaixaCabF = new CaixaCab
                {
                    tUsuarioId = caixaCab.tUsuarioId,
                    NomeCaixa = caixaCab.NomeCaixa,
                    DataCaixa = caixaCab.DataCaixa,
                    Status = caixaCab.Status,
                    Valor = caixaCab.Valor
                };

                ctx.caixaCabs.AddAsync(caixaCab);
                ctx.SaveChanges();
            }

           
        }

        //public async Task<IEnumerable<CaixaCab>> ListNomesID(int Id)
        //{
        //    //using (var contexto = new AppDbContext())
        //    //{

        //    //    var ListarNomesID = (from caixa in contexto.caixaCabs
        //    //                             join usu in contexto.usuarios on caixa.tUsuarioId equals usu.ID
        //    //                             join Itens in contexto.caixaItens on caixa.tUsuarioId equals Itens.Id
        //    //                             where caixa.Id == Id
        //    //                           select new CaixaCab
        //    //                           {
        //    //                               Id = caixa.Id,
        //    //                               tUsuarioId = caixa.tUsuarioId,
        //    //                               NomeCaixa = caixa.NomeCaixa,
        //    //                               DataCaixa = caixa.DataCaixa,
        //    //                               Status = caixa.Status
        //    //                           }).ToList();

        //    //    return (IEnumerable<CaixaCab>)ListarNomesID;
        //    //}
        //    //return await _context.FindAsync(Id);
        //}

        public async Task<IEnumerable<CaixaCab>> ListAsync()
        {
            return await _context.caixaCabs.ToListAsync();
        }


        public async Task<IEnumerable<CaixaCab>> ListNomes()
        {
            //using (var contexto = new AppDbContext())
            //{

            //    var ListarNomes = (from  caixa in contexto.caixaCabs
            //                       join usu in contexto.usuarios on caixa.tUsuarioId equals usu.ID
                                  


            //                       select new CaixaCab
            //                       {
            //                           Id = caixa.Id,
            //                           tUsuarioId = caixa.tUsuarioId,
            //                           NomeCaixa = caixa.NomeCaixa,
            //                           DataCaixa = caixa.DataCaixa, 
            //                           Status = caixa.Status,
            //                           //};
            //                       }).ToList();


                
            //    return (IEnumerable<CaixaCab>)ListarNomes;
            //}
            return await _context.caixaCabs.ToListAsync();
        }

        public void Remove(CaixaCab caixaCab)
        {
            _context.caixaCabs.Remove(caixaCab);
            _context.SaveChanges();
        }

        public void Update(CaixaCab caixaCab)
        {
            using (var ctx = new AppDbContext())
            {

                var Caixa = new CaixaCab
                {
                    IdCaixaCab = caixaCab.IdCaixaCab,
                    tUsuarioId = caixaCab.tUsuarioId,
                    NomeCaixa = caixaCab.NomeCaixa,
                    DataCaixa = caixaCab.DataCaixa,
                    Valor = caixaCab.Valor,
                    Status = caixaCab.Status,
                    
                };

                ctx.caixaCabs.Update(Caixa);
                ctx.SaveChanges();
            }
        }

        public async Task<CaixaCab> FindByIdAsync(int id)
        {
            
            return await _context.caixaCabs.FindAsync(id);
        }

        public Task<IEnumerable<CaixaCab>> ListNomesID(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<CaixaCab> FindByNomeAsync(string nome)
        {
            return await _context.caixaCabs.FindAsync(nome);
        }

        public async Task<IEnumerable<CaixaCab>> ListNomes(string name)
        {
            using (var contexto = new AppDbContext())
            {
                var resultado = contexto.caixaCabs
                                         .Where(m => EF.Functions.Like(m.NomeCaixa, "%" + name + "%"))
                                         .ToList();

                return (IEnumerable<CaixaCab>)resultado;
            }
        }


        //public async Task<IEnumerable<CaixaCab>> ListNomes(string name)
        //{
        //    return await _context.caixaCabs.ToListAsync();
        //    //return await _context.caixaCabs.ToListAsync();
        //}

        //public  Task<IEnumerable<CaixaCab>> ListNomesID(int id)
        //{
        //    return  _context.caixaCabs.ToListAsync();
        //}
    }
    
    
}
