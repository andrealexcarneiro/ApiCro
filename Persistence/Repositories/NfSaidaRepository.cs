using ApiSistema.Models;
using ApiSistema.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSistema.Persistence.Repositories
{
    public class NfSaidaRepository : BaseRepository, INfsaidaRepository
    {
        public NfSaidaRepository(AppDbContext context) : base(context)
        { }

        public async Task AddAsync(NfSaida nfs)
        {
            using (var ctx = new AppDbContext())
            {

                ctx.nfSaidas.AddAsync(nfs);
                ctx.SaveChanges();
            }

            await _context.nfSaidas.ToListAsync();
        }

        public async Task<NfSaida> FindByIdAsync(int id)
        {
            return await _context.nfSaidas.FindAsync(id);
        }

        public async Task<IEnumerable<NfSaida>> ListAsync()
        {
            return await _context.nfSaidas.ToListAsync();
        }

        public async Task<IEnumerable<NfSaida>> ListNomes(string name)
        {
            return await _context.nfSaidas.ToListAsync();
        }

        public Task<IEnumerable<NfSaida>> ListNomesID(int Id)
        {
            throw new NotImplementedException();
        }

        public void Remove(NfSaida nfs)
        {
            _context.nfSaidas.Remove(nfs);
            _context.SaveChanges();
        }

        public void Update(NfSaida nfs)
        {
            using (var ctx = new AppDbContext())
            {
                var Ativ = new NfSaida
                {

                    //tCNAE_ID = atividades.tCNAE_ID,
                    //tContrato_ID = atividades.tContrato_ID,
                    //Principal = atividades.Principal,
                    //Servico = atividades.Servico,
                    //DataAlteracao = atividades.DataAlteracao,
                    //UsuarioAlteracao = atividades.UsuarioAlteracao

                };

                ctx.nfSaidas.Update(nfs);
                ctx.SaveChanges();
            }
        }
    }
}
