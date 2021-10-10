using ApiCro.Models;
using ApiCro.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCro.Domain.Services
{
    public class DepartamentoServices : IDepartamentoService
    {
        private readonly IDepartamentoRepository _DepartamentoRepository;

        public DepartamentoServices(IDepartamentoRepository departamentoRepository)
        {
            _DepartamentoRepository = departamentoRepository;
        }
        public Task AddAsync(Departamentos departamento)
        {
            return _DepartamentoRepository.AddAsync(departamento);
        }

        public async Task<Departamentos> FindByNomeAsync(string nome)
        {
            return await _DepartamentoRepository.FindByNomeAsync(nome);
        }
        public async Task<Departamentos> FindByIdAsync(int id)
        {
            return await _DepartamentoRepository.FindByIdAsync(id);
        }

        public async Task<IEnumerable<Departamentos>> ListAsync()
        {
            return await _DepartamentoRepository.ListAsync();
        }

        public async Task<IEnumerable<Departamentos>> ListNomes(string name)
        {
            return await _DepartamentoRepository.ListNomes(name);
        }

        public async Task<IEnumerable<Departamentos>> ListNomesID(int Id)
        {
            return await _DepartamentoRepository.ListNomesID(Id);
        }

        public void Remove(Departamentos departamento)
        {
            _DepartamentoRepository.Remove(departamento);
        }

        public void Update(Departamentos departamento)
        {
            _DepartamentoRepository.Update(departamento);
        }
    }
}
