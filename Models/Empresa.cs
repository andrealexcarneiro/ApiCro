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
        public int tTipoEmpresa_ID { get; set; }
        public int tPorteEmpresa_ID { get; set; }
        public int tTipoNaturezaPJ_Codigo { get; set; }
        public string tInscJunta_ID { get; set; }
        public int tRegimeTrib_ID { get; set; }
        public string tCidade_CodIBGE { get; set; }
        public int tTipoLogradouro { get; set; }
        public int tTipoBairro { get; set; }
        public int Filial { get; set; }
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
        public string Fax { get; set; }
        public string Email { get; set; }
        public bool Inativa { get; set; }
        public byte[] LogoEmpresa { get; set; }
        public byte[] LogoMunicipio { get; set; }
        public bool EmpresaLocal { get; set; }
        public bool EmpresaGrupo { get; set; }
        public bool Selecionada { get; set; }
        public bool Administradora { get; set; }
        public int UsuarioInclusao { get; set; }
        public DateTime DataInclusao { get; set; }
        public int UsuarioAlteracao { get; set; }
        public DateTime DataAlteracao { get; set; }
        public int tPlanoConta_CRDebito { get; set; }
        public int tPlanoConta_CRCredito { get; set; }
        public string tQualiPJ { get; set; }
        public string tFormaTribut { get; set; }
        public string tFormaApur { get; set; }
        public string tTipoEscrituracao { get; set; }
        public string tTipoPessoaImune { get; set; }
        public string tTipoApurIRPJImune { get; set; }
        public string tTipoApurCSLLImune { get; set; }
        public int tPlanodeContas_ID { get; set; }
        public string tAtivEmpresa_Codigo { get; set; }
        public string tAtivEmpresa_Desc { get; set; }
    }
}
