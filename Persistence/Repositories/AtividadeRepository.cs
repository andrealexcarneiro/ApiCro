using ApiSistema.Models;
using ApiSistema.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSistema.Persistence.Repositories
{
    public class AtividadeRepository : BaseRepository, IAtividadeRepository
    {
        public AtividadeRepository(AppDbContext context) : base(context)
        { }

        public async Task AddAsync(AtividadeEmpresa atividades)
        {
            using (var ctx = new AppDbContext())
            {

                ctx.atividades.AddAsync(atividades);
                ctx.SaveChanges();
            }

            await _context.atividades.ToListAsync();
        }

        public async Task<AtividadeEmpresa> FindByIdAsync(int id)
        {
            return await _context.atividades.FindAsync(id);
        }

        public async  Task<IEnumerable<AtividadeEmpresa>> ListAsync()
        {
            return await _context.atividades.ToListAsync();
        }

        public async Task<IEnumerable<AtividadeEmpresa>> ListNomes(string name)
        {
            return await _context.atividades.ToListAsync();
        }

        public Task<IEnumerable<AtividadeEmpresa>> ListNomesID(int Id)
        {
            throw new NotImplementedException();
        }

        public void Remove(AtividadeEmpresa atividades)
        {
            _context.atividades.Remove(atividades);
            _context.SaveChanges();
        }

        public void Update(AtividadeEmpresa atividades)
        {
            using (var ctx = new AppDbContext())
            {
                var Ativ = new AtividadeEmpresa
                {
                    
                    tCNAE_ID = atividades.tCNAE_ID,
                    tContrato_ID = atividades.tContrato_ID,
                    Principal = atividades.Principal,
                    Servico = atividades.Servico,
                    DataAlteracao = atividades.DataAlteracao,
                    UsuarioAlteracao = atividades.UsuarioAlteracao

                };

                ctx.atividades.Update(atividades);
                ctx.SaveChanges();
            }
        }
    }
}
