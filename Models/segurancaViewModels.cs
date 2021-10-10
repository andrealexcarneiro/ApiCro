using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCro.Models
{
    public class segurancaViewModels
    {
        public Usuario FUsuarios { get; set; }
        public Seguranca FSeguranca { get; set; }

        public SegurancaItens fSegurancaItens { get; set; }


        public List<Usuario> FListUsuarios { get; set; }
        public List<Seguranca> FListSegurancas { get; set; }
        public List<SegurancaItens> FListSegurancasItens { get; set; }
    }
}
