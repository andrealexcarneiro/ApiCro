using ApiSistema.Models;
using ApiSistema.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSistema.Domain.Services
{
    public class EmpresaService : IEmpresaService
    {
        private readonly IEmpresaRepository _empresaRepository;
        public EmpresaService(IEmpresaRepository empresaRepository)
        {
            _empresaRepository = empresaRepository;
        }

        public Task AddAsync(Empresa empresa)
        {
            return _empresaRepository.AddAsync(empresa);
        }

        public async Task<Empresa> FindByIdAsync(int id)
        {
            return await _empresaRepository.FindByIdAsync(id);
        }

        public async Task<IEnumerable<Empresa>> ListAsync()
        {
            return await _empresaRepository.ListAsync();
        }

        public async Task<IEnumerable<Empresa>> ListNomes(string name)
        {
            return await _empresaRepository.ListAsync();
        }

        public async Task<IEnumerable<Empresa>> ListNomesID(int Id)
        {
            return await _empresaRepository.ListNomesID(Id);
        }

        public void Remove(Empresa empresa)
        {
            _empresaRepository.Remove(empresa);
        }

        public void Update(Empresa empresa)
        {
            _empresaRepository.Update(empresa);
        }
    }
}
