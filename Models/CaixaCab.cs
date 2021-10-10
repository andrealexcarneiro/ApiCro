
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ApiCro.Models
{
    [Table("tCaixaCab")]
    public class CaixaCab
    {
        [Key]
       public int IdCaixaCab { get; set; }
        public int tUsuarioId { get; set; }
        public string NomeCaixa { get; set; }
        public DateTime DataCaixa { get; set; }
        public int Status { get; set; }
        public decimal Valor { get; set; }


    }
}
