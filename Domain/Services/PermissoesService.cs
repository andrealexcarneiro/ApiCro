using ApiCro.Models;
using ApiCro.Persistence.Repositories;
using ApiCro.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCro.Domain.Services
{
    public class PermissoesService : IPermissoesService
    {
        private readonly IPermissaoRepository _permissoesRepository;
        public PermissoesService(IPermissaoRepository permissoesRepository)
        {
            _permissoesRepository = permissoesRepository;
        }

        public Task AddAsync(Permissoes permissao)
        {
            return _permissoesRepository.AddAsync(permissao);
        }

        public async Task<Permissoes> FindByIdAsync(int id)
        {
            return await _permissoesRepository.FindByIdAsync(id);
        }

        public async Task<IEnumerable<Permissoes>> ListAsync()
        {
            return await _permissoesRepository.ListAsync();
        }

        public async Task<IEnumerable<Permissoes>> ListNomes(string name)
        {
            return await _permissoesRepository.ListAsync();
        }

        public async  Task<IEnumerable<Permissoes>> ListNomesID(int Id)
        {
            return await _permissoesRepository.ListNomesID(Id);
        }

        public void Remove(Permissoes permissao)
        {
            _permissoesRepository.Remove(permissao);
        }

        public void Update(Permissoes permissao)
        {
            _permissoesRepository.Update(permissao);
        }
    }
}
