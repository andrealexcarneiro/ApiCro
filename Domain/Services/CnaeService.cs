using ApiSistema.Models;
using ApiSistema.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSistema.Domain.Services
{
    public class CnaeService :ICnaeService
    {
        private readonly ICnaeRepository _cnaeRepository;
        public CnaeService(ICnaeRepository cnaeRepository)
        {
            _cnaeRepository = cnaeRepository;
        }

        public Task AddAsync(Cnae cnaes)
        {
            return _cnaeRepository.AddAsync(cnaes);
        }

        public async Task<Cnae> FindByIdAsync(int id)
        {
            return await _cnaeRepository.FindByIdAsync(id);
        }

        public async Task<IEnumerable<Cnae>> ListAsync()
        {
            return await _cnaeRepository.ListAsync();
        }

        public async Task<IEnumerable<Cnae>> ListNomes(string name)
        {
            return await _cnaeRepository.ListAsync();
        }

        public async Task<IEnumerable<Cnae>> ListNomesID(int Id)
        {
            return await _cnaeRepository.ListNomesID(Id);
        }

        public void Remove(Cnae cnaes)
        {
            _cnaeRepository.Remove(cnaes);
        }

        public void Update(Cnae cnaes)
        {
            _cnaeRepository.Update(cnaes);
        }
    }
}
