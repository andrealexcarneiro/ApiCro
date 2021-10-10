using ApiCro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCro.Persistence.Repositories
{
   public interface IConfiguracoesRepository
    {
        Task<IEnumerable<Configuracoes>> ListAsync();
        Task<IEnumerable<Configuracoes>> ListNomes(string name);
        Task<IEnumerable<Configuracoes>> ListNomesID(int Id);
        Task AddAsync(Configuracoes configuracoes);
        Task<Configuracoes> FindByIdAsync(int id);
        void Update(Configuracoes configuracoes);
        void Remove(Configuracoes configuracoes);
    }
}
