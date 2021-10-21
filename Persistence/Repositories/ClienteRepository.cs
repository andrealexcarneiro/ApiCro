using ApiSistema.Models;
using ApiSistema.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSistema.Persistence.Repositories
{
    public class ClienteRepository : BaseRepository, IClienteRepository
    {
        public ClienteRepository(AppDbContext context) : base(context)
        { }

        public async Task AddAsync(Cliente clientes)
        {
            using (var ctx = new AppDbContext())
            {

                ctx.clientes.AddAsync(clientes);
                ctx.SaveChanges();
            }

            await _context.clientes.ToListAsync();
        }

        public async Task<Cliente> FindByIdAsync(int id)
        {
            return await _context.clientes.FindAsync(id);
        }

        public async Task<IEnumerable<Cliente>> ListAsync()
        {

            using (var contexto = new AppDbContext())
            {
                var resultado = contexto.clientes
                                .OrderBy(m => m.Nome)
                                .ToList();

                return (IEnumerable<Cliente>)resultado;
            }


           
        }

        public async Task<IEnumerable<Cliente>> ListNomes(string name)
        {
            using (var contexto = new AppDbContext())
            {
                var resultado = contexto.clientes
                                         .Where(m => EF.Functions.Like(m.Nome, "%" + name + "%"))
                                         .ToList();

                return (IEnumerable<Cliente>)resultado;
            }
        }

        public Task<IEnumerable<Cliente>> ListNomesID(int Id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Cliente clientes)
        {
            _context.clientes.Remove(clientes);
            _context.SaveChanges();
        }

        public void Update(Cliente clientes)
        {
            using (var ctx = new AppDbContext())
            {
                var Ativ = new Cliente
                {

                    //tCNAE_ID = atividades.tCNAE_ID,
                    //tContrato_ID = atividades.tContrato_ID,
                    //Principal = atividades.Principal,
                    //Servico = atividades.Servico,
                    //DataAlteracao = atividades.DataAlteracao,
                    //UsuarioAlteracao = atividades.UsuarioAlteracao

                };

                ctx.clientes.Update(clientes);
                ctx.SaveChanges();
            }
        }
    }
}
