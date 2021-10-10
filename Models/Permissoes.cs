using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCro.Models
{
    [Table("tPermissoes")]
    public class Permissoes
    {
        [Key]
        public int ID { get; set; }
        public int tFuncionario_ID { get; set; }
        public bool Permissao { get; set; }
        public int tCadastroBI_ID { get; set; }
    }
}
