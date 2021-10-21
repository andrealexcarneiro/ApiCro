using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiSistema.Models
{
    [Table("tEmpresa")]
    public class Empresa
    {
        [Key]
        public int Codigo { get; set; }
        public Int16 tTipoEmpresa_ID { get; set; }
        public Int16 tPorteEmpresa_ID { get; set; }
        
        public string tInscJunta_ID { get; set; }
        public Int16 tRegimeTrib_ID { get; set; }
        public string tCidade_CodIBGE { get; set; }
        public Int16 tTipoLogradouro { get; set; }
        public Int16 tTipoBairro { get; set; }
        public Int16 Filial { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string CNPJ { get; set; }
        public string InscEstadual { get; set; }
        public string InscMunicipal { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public bool Inativa { get; set; }
        public byte[] LogoEmpresa { get; set; }
        public byte[] LogoMunicipio { get; set; }
        public bool Administradora { get; set; }
        public int UsuarioInclusao { get; set; }
        public DateTime DataInclusao { get; set; }
        public int UsuarioAlteracao { get; set; }
        public DateTime DataAlteracao { get; set; }
    }
}
