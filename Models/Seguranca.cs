using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiSistema.Models
{
   [Table("tSeguranca")]
    public class Seguranca
    {
        [Key]
        public int id { get; set; }
        public string Formulario { get; set; }

    }
}
