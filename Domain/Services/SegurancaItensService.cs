using ApiCro.Models;
using ApiCro.Persistence.Repositories;
using ApiCro.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCro.Domain.Services
{
    public class SegurancaItensService : ISegurancaItensService
    {
        private readonly ISegurancaItensRepository _segurancaItensRepository;
        public SegurancaItensService(ISegurancaItensRepository segurancaItensRepository)
        {
            _segurancaItensRepository = segurancaItensRepository;
        }

        public Task AddAsync(SegurancaItens segurancaItens)
        {
            return _segurancaItensRepository.AddAsync(segurancaItens);
        }

        public async  Task<SegurancaItens> FindByIdAsync(int id)
        {
            return await _segurancaItensRepository.FindByIdAsync(id);
        }

        public async Task<IEnumerable<SegurancaItens>> ListAsync()
        {
            return await _segurancaItensRepository.ListAsync();
        }


        public async Task<IEnumerable<SegurancaItens>> ListNomes(string name)
        {
            return await _segurancaItensRepository.ListAsync();
        }

        public async Task<IEnumerable<SegurancaItens>> ListNomesID(int Id)
        {
            return await _segurancaItensRepository.ListNomesID(Id);
        }

        public void Remove(SegurancaItens segurancaItens)
        {
            _segurancaItensRepository.Remove(segurancaItens);
        }

        public void Update(SegurancaItens segurancaItens)
        {
            _segurancaItensRepository.Update(segurancaItens);
        }

        public async Task<IEnumerable<SegurancaItens>> ListID(int Id, int IdUsu)
        {
            return await _segurancaItensRepository.ListID(Id, IdUsu);
        }
    }
}
