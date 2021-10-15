using ApiSistema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSistema.Domain.Services
{
    public interface IAtividadeService
    {
        Task<IEnumerable<AtividadeEmpresa>> ListAsync();
        Task<IEnumerable<AtividadeEmpresa>> ListNomes(string name);
        Task<IEnumerable<AtividadeEmpresa>> ListNomesID(int Id);
        Task AddAsync(AtividadeEmpresa atividades);
        Task<AtividadeEmpresa> FindByIdAsync(int id);
        void Update(AtividadeEmpresa atividades);
        void Remove(AtividadeEmpresa atividades);
    }
}
