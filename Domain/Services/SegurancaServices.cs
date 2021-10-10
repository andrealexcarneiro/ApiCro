using ApiCro.Models;
using ApiCro.Persistence.Repositories;
using ApiCro.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCro.Domain.Services
{
    public class SegurancaServices :ISegurancaService
    {
        private readonly ISegurancaRepository _segurancaRepository;
        public SegurancaServices(ISegurancaRepository segurancaRepository)
        {
            _segurancaRepository = segurancaRepository;
        }

        public Task AddAsync(Seguranca seguranca)
        {
            return _segurancaRepository.AddAsync(seguranca);
        }

        public async Task<Seguranca> FindByIdAsync(int id)
        {
            return await _segurancaRepository.FindByIdAsync(id);
        }
        //public async Task<Seguranca> FindByNomeAsync(string nome)
        //{
        //    //return await _seguancaRepository.FindByNomeAsync(nome);
        //}

        public async Task<IEnumerable<Seguranca>> ListAsync()
        {
            return await _segurancaRepository.ListAsync();
        }

        public async  Task<IEnumerable<Seguranca>> ListNomes(string name)
        {
            return await _segurancaRepository.ListAsync();
        }

        public async Task<IEnumerable<Seguranca>> ListNomesID(int Id)
        {
            return await _segurancaRepository.ListNomesID(Id);
        }
        //public async Task<IEnumerable<CaixaCab>> ListNomes(string name)
        //{
        //    return await _segurancaRepository.ListNomes(name);
        //}
        public void Remove(Seguranca seguranca)
        {
            _segurancaRepository.Remove(seguranca);
        }

        public void Update(Seguranca seguranca)
        {
            _segurancaRepository.Update(seguranca);
        }
    }
}
