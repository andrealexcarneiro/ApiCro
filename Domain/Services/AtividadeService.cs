using ApiSistema.Models;
using ApiSistema.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSistema.Domain.Services
{
    public class AtividadeService :IAtividadeService
    {
        private readonly IAtividadeRepository _atividadeRepository;
        public AtividadeService(IAtividadeRepository atividadeRepository)
        {
            _atividadeRepository = atividadeRepository;
        }

        public Task AddAsync(AtividadeEmpresa atividades)
        {
            return _atividadeRepository.AddAsync(atividades);
        }

        public async  Task<AtividadeEmpresa> FindByIdAsync(int id)
        {
            return await _atividadeRepository.FindByIdAsync(id);
        }

        public async Task<IEnumerable<AtividadeEmpresa>> ListAsync()
        {
            return await _atividadeRepository.ListAsync();
        }

        public async Task<IEnumerable<AtividadeEmpresa>> ListNomes(string name)
        {
            return await _atividadeRepository.ListAsync();
        }

        public async Task<IEnumerable<AtividadeEmpresa>> ListNomesID(int Id)
        {
            return await _atividadeRepository.ListNomesID(Id);
        }

        public void Remove(AtividadeEmpresa atividades)
        {
            _atividadeRepository.Remove(atividades);
        }

        public void Update(AtividadeEmpresa atividades)
        {
            _atividadeRepository.Update(atividades);
        }
    }
}
