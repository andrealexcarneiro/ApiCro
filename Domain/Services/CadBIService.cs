using ApiCro.Models;
using ApiCro.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCro.Domain.Services
{
   
    public class CadBIService : ICadBIService
    {
        private readonly ICadastroBIRepository _CadBIRepository;

        public CadBIService(ICadastroBIRepository cadastroBIRepository)
        {
            _CadBIRepository = cadastroBIRepository;
        }

        public Task AddAsync(CadastroBI cadastroBI)
        {
            return _CadBIRepository.AddAsync(cadastroBI);
        }
        //public async Task<Departamentos> FindByNomeAsync(string nome)
        //{
        //    return await _CadBIRepository.FindByNomeAsync(nome);
        //}
        public async Task<CadastroBI> FindByIdAsync(int id)
        {
            return await _CadBIRepository.FindByIdAsync(id);
        }

        public async Task<IEnumerable<CadastroBI>> ListAsync()
        {
            return await _CadBIRepository.ListAsync();
        }

        public async Task<IEnumerable<CadastroBI>> ListID(int Id)
        {
            return await _CadBIRepository.ListID(Id);
        }

        public async Task<IEnumerable<CadastroBI>> ListNomes(string name)
        {
            return await _CadBIRepository.ListNomes(name);
        }

        public async Task<IEnumerable<CadastroBI>> ListNomesID(int Id)
        {
            return await _CadBIRepository.ListNomesID(Id);
        }

        public void Remove(CadastroBI cadastroBI)
        {
            _CadBIRepository.Remove(cadastroBI);
        }

        public void Update(CadastroBI cadastroBI)
        {
            _CadBIRepository.Update(cadastroBI);
        }
    }
}
