using ApiCro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCro.Persistence.Repositories
{
   public interface ICadastroBIRepository
    {
        Task<IEnumerable<CadastroBI>> ListAsync();
        Task<IEnumerable<CadastroBI>> ListNomes(string name);
        Task<IEnumerable<CadastroBI>> ListNomesID(int Id);
        Task AddAsync(CadastroBI cadastroBI);
        Task<CadastroBI> FindByIdAsync(int id);
        void Update(CadastroBI cadastroBI);
        void Remove(CadastroBI cadastroBI);
        Task<IEnumerable<CadastroBI>> ListID(int Id);
    }
}
