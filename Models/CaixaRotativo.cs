using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCro.Models
{
    [Table("tCaixaRotativo")]
    public class CaixaRotativo
    {
        [Key]
        public int IdCaixaRotativo { get; set; }
        public string Obra { get; set; }
        [Required]
        public string Insumo { get; set; }
        [Required]
        public string TipoInsumo { get; set; }
        [Required]
        public decimal ValorDespesa { get; set; }
        [Required]
        public DateTime DataDespesa { get; set; }
        [Required]
        public string Nominal { get; set; }
        [Required]
        public string Fornecedor { get; set; }
        [Required]
        public string CpfCnpjNominal { get; set; }
        public string CpfCnpjFornecedor { get; set; }
        
        public string Obs { get; set; }
        public int tUsuarioID { get; set; }

        public string ImagemTitulo { get; set; }
        public byte[] ImagemDados { get; set; }

        public int  tCaixaCabId { get; set; }
    }
}
