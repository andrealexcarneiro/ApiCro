using ApiSistema.Models;
using ApiSistema.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSistema.Persistence.Repositories
{
    public class SegurancaRepository : BaseRepository, ISegurancaRepository
    {
        public SegurancaRepository(AppDbContext context) : base(context)
        { }

        public async Task AddAsync(Seguranca seguranca)
        {
            using (var ctx = new AppDbContext())
            {

                var SegurancaF = new Seguranca
                {
                    Formulario = seguranca.Formulario,
                   
                   
                };

                ctx.segurancas.AddAsync(seguranca);
                ctx.SaveChanges();
            }

            await _context.segurancas.ToListAsync();
        }

        public async Task<Seguranca> FindByIdAsync(int id)
        {
            return await _context.segurancas.FindAsync(id);
        }

        public async Task<IEnumerable<Seguranca>> ListAsync()
        {
            using (var contexto = new AppDbContext())
            {
                var resultado = contexto.segurancas.OrderBy(m => m.Formulario).ToList();

                //return  (resultado).ToList();
                return await contexto.segurancas.ToListAsync();
            }
            
        }
        public async Task<IEnumerable<Seguranca>> ListNomes()
        {
            return await _context.segurancas.ToListAsync();
        }

        public async Task<IEnumerable<Seguranca>> ListNomes(string name)
        {
            using (var contexto = new AppDbContext())
            {
                var resultado = contexto.segurancas
                                         .Where(m => EF.Functions.Like(m.Formulario, "%" + name + "%"))
                                         .ToList();

                return (IEnumerable<Seguranca>)resultado;
            }
        }

        public Task<IEnumerable<Seguranca>> ListNomesID(int Id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Seguranca seguranca)
        {
            _context.segurancas.Remove(seguranca);
            _context.SaveChanges();
        }

        public void Update(Seguranca seguranca)
        {
            using (var ctx = new AppDbContext())
            {

                var Seg = new Seguranca
                {
                    id = seguranca.id,
                    Formulario = seguranca.Formulario,
                  
                };

                ctx.segurancas.Update(seguranca);
                ctx.SaveChanges();
            }
        }
    }
}
