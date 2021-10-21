using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiSistema.Models
{
    [Table("tCNAE")]
    public class Cnae
    {
        [Key]
        public int ID { get; set; }
        public string Secao { get; set; }
        public string Divisao { get; set; }
        public string Grupo { get; set; }
        public string Classe { get; set; }
        public string Subclasse { get; set; }
        public string Denominacao { get; set; }
    }
}
