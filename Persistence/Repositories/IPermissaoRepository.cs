using ApiCro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCro.Persistence.Repositories
{
    public interface IPermissaoRepository
    {
        Task<IEnumerable<Permissoes>> ListAsync();
        Task<IEnumerable<Permissoes>> ListNomes(string name);
        Task<IEnumerable<Permissoes>> ListNomesID(int Id);
        Task AddAsync(Permissoes permissao);
        Task<Permissoes> FindByIdAsync(int id);
        void Update(Permissoes permissao);
        void Remove(Permissoes permissao);
    }
}
