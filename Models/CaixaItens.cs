using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCro.Models
{
    [Table("tCaixaItens")]
    public class CaixaItens
    {
        [Key]
        public int Id { get; set; }
        public int tCaixaCabID { get; set; }
        public string NomeCaixa { get; set; }
        public DateTime  DataCaixa {get;set;}
        public int Status { get; set; }

    }
}
