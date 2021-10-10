using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCro.Models
{
    [Table("tCadastroBI")]
    public class CadastroBI
    {
        [Key]
        public int ID { get; set; }
        public string Caminho { get; set; }
        public string Nome { get; set; }
        public bool Permissao { get; set; }
    }
}
