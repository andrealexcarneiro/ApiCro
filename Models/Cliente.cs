using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiSistema.Models
{
    [Table("tCliente")]
    public class Cliente
    {
       [Key]
        public int Codigo { get; set; }
        public string CPFCNPJ { get; set; }
        public int tEmpresa_Codigo { get; set; }
       
        public string tCidade_CodIBGE { get; set; }
        public string tCidade_CodIBGEComercial { get; set; }
        public int tCNAE_ID { get; set; }
        public Int16 tTipoCliente_ID { get; set; }
        public Int16 tTipoLogradouroRes { get; set; }
        public Int16 tTipoBairroRes { get; set; }
        public Int16 tTipoLogradouroCom { get; set; }
        public Int16 tTipoBairroCom { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public bool Cobranca { get; set; }
        public string NomeEmpresa { get; set; }
        public string EnderecoComercial { get; set; }
        public string NumeroComercial { get; set; }
        public string BairroComercial { get; set; }
        public string CEPComercial { get; set; }
        public string TelefoneComercial1 { get; set; }
        public string TelefoneComercial2 { get; set; }
        public bool CobrancaComercial { get; set; }
        public string InscEstadual { get; set; }
        public string InscMunicipal { get; set; }
        public string CEI { get; set; }
        public string Identidade { get; set; }
        public string OrgaoEmissor { get; set; }
        public bool Inativo { get; set; }
        public Int16 TipoPessoa { get; set; }
        public decimal LimiteCredito { get; set; }
        public Int16 SituacaoSerasa { get; set; }
        public int UsuarioInclusao { get; set; }
        public DateTime DataInclusao { get; set; }
        public int UsuarioAlteracao { get; set; }
        public DateTime DataAlteracao { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool EmissorNFE { get; set; }
    }
}
