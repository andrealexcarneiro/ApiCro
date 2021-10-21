using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiSistema.Models
{
    [Table("tUF")]
    public class UF
    {
        [Key]
        public string Sigla { get; set; }
        public Int16 Codigo { get; set; }
        public string Nome { get; set; }
        public Int16 CODIBGE { get; set; }
    }
}
