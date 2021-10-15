using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiSistema.Models
{
    [Table("tAtivEmpresa")]
    public class AtividadeEmpresa
    {
        [Key]
        public int ID { get; set; }
        public int tContrato_ID { get; set; }
        public int tCNAE_ID { get; set; }
        public bool Principal { get; set; }
        public bool Servico { get; set; }
        public int UsuarioInclusao { get; set; }
        public DateTime DataInclusao { get; set; }
        public int UsuarioAlteracao { get; set; }
        public DateTime DataAlteracao { get; set; }
    }
}
