using ApiCro.Models;
using ApiCro.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCro.Persistence.Repositories
{
    public class DepartamentoRepository : BaseRepository, IDepartamentoRepository
    {
        public DepartamentoRepository(AppDbContext context) : base(context)
        { }
        public async Task AddAsync(Departamentos departamento)
        {
            using (var ctx = new AppDbContext())
            {

                var departamentoF = new Departamentos
                {
                    ID = departamento.ID,
                    Departamento = departamento.Departamento
                };

                ctx.departamento.AddAsync(departamento);
                ctx.SaveChanges();
            }

            await _context.departamento.ToListAsync();
        }
        public async Task<IEnumerable<Departamentos>> ListNomes()
        {
            using (var contexto = new AppDbContext())
            {

                var ListarDepartamentos = (from dep in contexto.departamento
                                             orderby dep.Departamento
                                          select new Departamentos
                                          {
                                              ID = dep.ID,
                                              Departamento = dep.Departamento
                                          }).ToList();

                return (IEnumerable<Departamentos>)ListarDepartamentos;
            }
        }

        public async Task<Departamentos> FindByIdAsync(int id)
        {
            return await _context.departamento.FindAsync(id);
        }

        public async Task<Departamentos> FindByNomeAsync(string nome)
        {
            return await _context.departamento.FindAsync(nome);
        }

        public async Task<IEnumerable<Departamentos>> ListAsync()
        {
            using (var contexto = new AppDbContext())
            {

                var ListarDepartamentos = (from dep in contexto.departamento
                                           orderby dep.Departamento
                                           select new Departamentos
                                           {
                                               ID = dep.ID,
                                               Departamento = dep.Departamento
                                           }).ToList();

                return (IEnumerable<Departamentos>)ListarDepartamentos;
            }
        }

        public async Task<IEnumerable<Departamentos>> ListNomes(string name)
        {
            using (var contexto = new AppDbContext())
            {
                var resultado = contexto.departamento
                                         .Where(m => EF.Functions.Like(m.Departamento, "%" + name + "%"))
                                         .ToList();

                return (IEnumerable<Departamentos>)resultado;
            }
        }

        public Task<IEnumerable<Departamentos>> ListNomesID(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Departamentos departamento)
        {
            _context.departamento.Remove(departamento);
            _context.SaveChanges();
        }

        public void Update(Departamentos departamento)
        {
            using (var ctx = new AppDbContext())
            {

                var Dep = new Departamentos
                {
                    ID = departamento.ID,
                    Departamento = departamento.Departamento
                };

                ctx.departamento.Update(Dep);
                ctx.SaveChanges();
            }
        }
    }
}
