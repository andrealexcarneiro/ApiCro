using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiSistema.Models
{
    [Table("tCidade")]
    public class Cidades
    {
        [Key]
        public string CodIBGE { get; set; }
        public string tUFs_Sigla { get; set; }
        public string Municipio { get; set; }
        public string CEPIni { get; set; }
        public string CEPFim { get; set; }
        public int UsuarioInclusao { get; set; }
        public DateTime DataInclusao { get; set; }
        public int UsuarioAlteracao { get; set; }
        public DateTime DataAlteracao { get; set; }
    }
}
