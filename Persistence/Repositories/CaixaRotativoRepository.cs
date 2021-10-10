using ApiCro.Models;
using ApiCro.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCro.Persistence.Repositories
{
    public class CaixaRotativoRepository : BaseRepository, ICaixaRotativoRepository
    {
        public CaixaRotativoRepository(AppDbContext context) : base(context)
        { }
        public async Task AddAsync(CaixaRotativo caixaRotativo)
        {
            using (var ctx = new AppDbContext())
            {

                //var Caixa = new CaixaRotativo
                //{
                    
                //    Obra = caixaRotativo.Obra,
                //    Insumo = caixaRotativo.Insumo,
                //    TipoInsumo = caixaRotativo.TipoInsumo,
                //    ValorDespesa = caixaRotativo.ValorDespesa,
                //    DataDespesa = caixaRotativo.DataDespesa,
                //    Nominal = caixaRotativo.Nominal,
                //    Fornecedor = caixaRotativo.Fornecedor,
                //    CpfCnpjNominal = caixaRotativo.CpfCnpjNominal,
                //    CpfCnpjFornecedor = caixaRotativo.CpfCnpjFornecedor,
                //    tUsuarioID = caixaRotativo.tUsuarioID,
                //    Obs = caixaRotativo.Obs,
                //    ImagemTitulo = caixaRotativo.ImagemTitulo,
                //    ImagemDados = caixaRotativo.ImagemDados,
                //    tCaixaCabId = caixaRotativo.tCaixaCabId
                //};

                ctx.caixaRotativo.AddAsync(caixaRotativo);
                ctx.SaveChanges();
            }
        }
        public async Task<CaixaRotativo> FindByIdAsync(int id)
        {
            return await _context.caixaRotativo.FindAsync(id);
        }

        public async Task<IEnumerable<CaixaRotativo>> ListAsync()
        {
            return await _context.caixaRotativo.ToListAsync();
        }

        public async Task<IEnumerable<CaixaRotativo>> ListID(int Id)
        {
            using (var contexto = new AppDbContext())
            {
                var resultado = contexto.caixaRotativo
                                         .Where(m => m.tCaixaCabId == Id)
                                         .ToList();

                return (IEnumerable<CaixaRotativo>)resultado;
            }
        }

        public async Task<IEnumerable<CaixaRotativo>> ListNomes()
        {
            return await _context.caixaRotativo.ToListAsync();
        }

        public async Task<IEnumerable<CaixaRotativo>> ListNomes(string name)
        {
            using (var contexto = new AppDbContext())
            {
                var resultado = contexto.caixaRotativo
                                         .Where(m => EF.Functions.Like(m.Insumo, "%" + name + "%"))
                                         .ToList();

                return (IEnumerable<CaixaRotativo>)resultado;
            }
        }

        public Task<IEnumerable<CaixaRotativo>> ListNomesID(int id)
        {
            throw new NotImplementedException();
        }

        public  async Task<IEnumerable<CaixaRotativo>> ListSomaID(int Id)
        {
            using (var contexto = new AppDbContext())

            {



              



                var resultado = contexto.caixaRotativo
                                            .Where(m => m.tUsuarioID == Id)
                                            .GroupBy(m => m.tCaixaCabId)

                                            .Select(m => new CaixaRotativo
                                            {
                                                IdCaixaRotativo = m.Key,
                                               
                                               
                                                ValorDespesa = m.Sum(m => m.ValorDespesa)

                                            }
                                        ).ToList();

                
                return (IEnumerable<CaixaRotativo>)resultado;
            }
        }

        public void Remove(CaixaRotativo caixaRotativo)
        {
            _context.caixaRotativo.Remove(caixaRotativo);
            _context.SaveChanges();
        }
        
        public void Update(CaixaRotativo caixaRotativo)
        {
            using (var ctx = new AppDbContext())
            {

                var Caixa = new CaixaRotativo
                {
                    IdCaixaRotativo = caixaRotativo.IdCaixaRotativo,
                    Obra = caixaRotativo.Obra,
                    Insumo = caixaRotativo.Insumo,
                    TipoInsumo = caixaRotativo.TipoInsumo,
                    ValorDespesa = caixaRotativo.ValorDespesa,
                    DataDespesa = caixaRotativo.DataDespesa,
                    Nominal = caixaRotativo.Nominal,
                    Fornecedor = caixaRotativo.Fornecedor,
                    CpfCnpjNominal = caixaRotativo.CpfCnpjNominal,
                    CpfCnpjFornecedor = caixaRotativo.CpfCnpjFornecedor,
                    tUsuarioID = caixaRotativo.tUsuarioID,
                    Obs = caixaRotativo.Obs,
                    ImagemTitulo = caixaRotativo.ImagemTitulo,
                    ImagemDados = caixaRotativo.ImagemDados,
                    tCaixaCabId = caixaRotativo.tCaixaCabId

                };

                ctx.caixaRotativo.Update(Caixa);
                ctx.SaveChanges();
            }
        }
    }
}
