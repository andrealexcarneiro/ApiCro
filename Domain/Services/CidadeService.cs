using ApiSistema.Models;
using ApiSistema.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSistema.Domain.Services
{
    public class CidadeService :ICidadeService
    {
        private readonly ICidadeRepository _cidadeRepository;
        public CidadeService(ICidadeRepository cidadeRepository)
        {
            _cidadeRepository = cidadeRepository;
        }

        public Task AddAsync(Cidades cidade)
        {
            return _cidadeRepository.AddAsync(cidade);
        }

        public async Task<Cidades> FindByIdAsync(int id)
        {
            return await _cidadeRepository.FindByIdAsync(id);
        }

        public async Task<IEnumerable<Cidades>> ListAsync()
        {
            return await _cidadeRepository.ListAsync();
        }

        public async Task<IEnumerable<Cidades>> ListNomes(string name)
        {
            return await _cidadeRepository.ListAsync();
        }

        public async Task<IEnumerable<Cidades>> ListNomesID(int Id)
        {
            return await _cidadeRepository.ListNomesID(Id);
        }

        public void Remove(Cidades cidade)
        {
            _cidadeRepository.Remove(cidade);
        }

        public void Update(Cidades cidade)
        {
            _cidadeRepository.Update(cidade);
        }
    }
}
