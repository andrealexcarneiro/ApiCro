using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCro.Models
{
    [Table("tStatus")]
    public class Status
    {
        [Key]
        public int Id { get; set; }
        public string StatusCaixa { get; set; }
    }
}
