using ApiSistema.Models;
using ApiSistema.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSistema.Domain.Services
{
    public class UfService :IUFService
    {
        private readonly IUFRepository _ufRepository;
        public UfService(IUFRepository ufRepository)
        {
            _ufRepository = ufRepository;
        }

        public async Task<IEnumerable<UF>> ListAsync()
        {
            return await _ufRepository.ListAsync();
        }

        public async Task<IEnumerable<UF>> ListNomes(string name)
        {
            return await _ufRepository.ListAsync();
        }
    }
}
