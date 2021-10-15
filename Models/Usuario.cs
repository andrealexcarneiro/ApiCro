using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ApiSistema.Models
{
    [Table("tUsuario")]
    public class Usuario
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Senha { get; set; }
        [Required]
        public string Email { get; set; }
        public bool Master { get; set; }
        public int DeptoID { get; set; }
        public bool Inativo { get; set; }
       //public string Departamentos { get; set; }

        //public Departamentos Departamento { get; set; }
        //public CaixaCab caixaCabs { get; set; }
        //public virtual ICollection<Departamentos> Departamentos { get; set; }
        //public IList<CaixaCab> caixaCabs { get; set; } = new List<CaixaCab>();

    }
}
