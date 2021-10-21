using ApiSistema.Models;
using ApiSistema.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSistema.Domain.Services
{
    public class NfSaidaService :INfSaidaService
    {
        private readonly INfsaidaRepository _NfsaidaRepository;
        public NfSaidaService(INfsaidaRepository nfsaidaRepository)
        {
            _NfsaidaRepository = nfsaidaRepository;
        }

        public Task AddAsync(NfSaida nfs)
        {
            return _NfsaidaRepository.AddAsync(nfs);
        }

        public async Task<NfSaida> FindByIdAsync(int id)
        {
            return await _NfsaidaRepository.FindByIdAsync(id);
        }

        public async Task<IEnumerable<NfSaida>> ListAsync()
        {
            return await _NfsaidaRepository.ListAsync();
        }

        public async Task<IEnumerable<NfSaida>> ListNomes(string name)
        {
            return await _NfsaidaRepository.ListAsync();
        }

        public async Task<IEnumerable<NfSaida>> ListNomesID(int Id)
        {
            return await _NfsaidaRepository.ListNomesID(Id);
        }

        public void Remove(NfSaida nfs)
        {
            _NfsaidaRepository.Remove(nfs);
        }

        public void Update(NfSaida nfs)
        {
            _NfsaidaRepository.Update(nfs);
        }
    }
}
