using ApiCro.Models;
using ApiCro.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCro.Domain.Services
{
    public class CaixaCabService : ICaixaCabService
    {
        private readonly ICaixaCabRepository _caixaCabRepository;
        public CaixaCabService(ICaixaCabRepository caixaCabRepository)
        {
            _caixaCabRepository = caixaCabRepository;
        }
        public Task AddAsync(CaixaCab caixaCab)
        {
            return  _caixaCabRepository.AddAsync(caixaCab);
        }

        public async Task<CaixaCab> FindByIdAsync(int id)
        {
            return await _caixaCabRepository.FindByIdAsync(id);
        }

        public async Task<CaixaCab> FindByNomeAsync(string nome)
        {
            return await _caixaCabRepository.FindByNomeAsync(nome);
        }

        //public Task<CaixaCab> FindByIdAsync(int id)
        //{
        //    return _caixaCabRepository.FindByIdAsync(id);
        //}

        public async Task<IEnumerable<CaixaCab>> ListAsync()
        {
            return await _caixaCabRepository.ListAsync();
        }

       

        public async Task<IEnumerable<CaixaCab>> ListNomes()
        {
            return await _caixaCabRepository.ListAsync();
        }

        public async Task<IEnumerable<CaixaCab>> ListNomes(string name)
        {
            return await _caixaCabRepository.ListNomes(name);
        }

        public async Task<IEnumerable<CaixaCab>> ListNomesID(int Id)
        {
            return await _caixaCabRepository.ListNomesID(Id);
        }

        public void Remove(CaixaCab caixaCab)
        {
             _caixaCabRepository.Remove(caixaCab);
        }

        public void Update(CaixaCab caixaCab)
        {
              _caixaCabRepository.Update(caixaCab);
        }
    }
}
