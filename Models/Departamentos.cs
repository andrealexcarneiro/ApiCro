
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ApiCro.Models
{
    [Table("tDepartamento")]
    public class Departamentos
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Departamento { get; set; }

        //public virtual Usuario Usuario { get; set; }

    }
}
