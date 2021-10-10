using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCro.Models
{
    [Table("tSegurancaItens")]
    public class SegurancaItens
    {
        [Key]
        
        public int Id { get; set; }
        public int tFormularioID { get; set; }
        public int tFuncionarioID { get; set; }
        public bool Visualizar { get; set; }
        public bool Gravar { get; set; }
        public bool Alterar { get; set; }
        public bool Excluir { get; set; }
    }
}
