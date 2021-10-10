using ApiCro.Models;
using ApiCro.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCro.Persistence.Repositories
{
    public class ConfiguracoesRepository : BaseRepository, ICaixaRotativoRepository
    {
        public ConfiguracoesRepository(AppDbContext context) : base(context)
        { }
        public Task AddAsync(CaixaRotativo caixaRotativo)
        {
            throw new NotImplementedException();
        }

        public Task<CaixaRotativo> FindByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CaixaRotativo>> ListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CaixaRotativo>> ListID(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CaixaRotativo>> ListNomes(string name)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CaixaRotativo>> ListNomesID(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(CaixaRotativo caixaRotativo)
        {
            throw new NotImplementedException();
        }

        public void Update(CaixaRotativo caixaRotativo)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<CaixaRotativo>> ICaixaRotativoRepository.ListSomaID(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
