using ApiCro.Models;
using ApiCro.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCro.Domain.Services
{
    public class CaixaRotativoService : ICaixaRotativoServices
    {
        private readonly ICaixaRotativoRepository _caixaRotativoRepository;

        public CaixaRotativoService(ICaixaRotativoRepository caixaRotativoRepository)
        {
            _caixaRotativoRepository = caixaRotativoRepository;
        }
        public Task AddAsync(CaixaRotativo caixaRotativo)
        {
            return _caixaRotativoRepository.AddAsync(caixaRotativo);
        }

        public async Task<CaixaRotativo> FindByIdAsync(int id)
        {
            return await _caixaRotativoRepository.FindByIdAsync(id);
        }

        public async Task<IEnumerable<CaixaRotativo>> ListAsync()
        {
            return await _caixaRotativoRepository.ListAsync();
        }

        public async Task<IEnumerable<CaixaRotativo>> ListID(int Id)
        {
            return await _caixaRotativoRepository.ListID(Id);
        }

        //public async Task<IEnumerable<CaixaRotativo>> ListNomes()
        //{
        //    return await _caixaRotativoRepository.ListNomes();
        //}

        public async Task<IEnumerable<CaixaRotativo>> ListNomes(string name)
        {
            return await _caixaRotativoRepository.ListNomes(name);
        }

        public async Task<IEnumerable<CaixaRotativo>> ListNomesID(int Id)
        {
            return await _caixaRotativoRepository.ListNomesID(Id);
        }

        public async Task<IEnumerable<CaixaRotativo>> ListSomaID(int Id)
        {
            return await _caixaRotativoRepository.ListSomaID(Id);
        }

        public void Remove(CaixaRotativo caixaRotativo)
        {
             _caixaRotativoRepository.Remove(caixaRotativo);
        }

        public void Update(CaixaRotativo caixaRotativo)
        {
            _caixaRotativoRepository.Update(caixaRotativo);
        }
    }
}
