using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiSistema.Models
{
    [Table("tNotaFiscalSaida")]
    public class NfSaida
    {
        [Key]
        public int ID { get; set; }
        public string Chave { get; set; }
        public int tEmpresa_Codigo { get; set; }
        public int tCliente_Codigo { get; set; }
        public string tFornecedor_CNPJ { get; set; }
        public string tFavorecido_CNPJ { get; set; }
        public string tCidade_CodIBGECliente { get; set; }
        public int tTipoEmissaoNF_ID { get; set; }
        public int tTipoCliente_ID { get; set; }
        public int tTipoOperacao_ID { get; set; }
        public int tTipoVenda_ID { get; set; }
        public int tFuncionario_IDVenda { get; set; }
        public int tEmpresa_CodigoVenda { get; set; }
        public int tFinalidadeNFe_ID { get; set; }
        public int tProcEmissao_ID { get; set; }
        public int tModeloVeiculo { get; set; }
        public string tModeloDocumento_Codigo { get; set; }
        public int TipoNF { get; set; }
        public string NomeCliente { get; set; }
        public string EnderecoCliente { get; set; }
        public DateTime DataSaida { get; set; }
        public DateTime DataEmissao { get; set; }
        public int NumeroMovCaixaDevolvida { get; set; }
        public int NumeroMovCaixaVenda { get; set; }
        public int NumeroNF { get; set; }
        public string SerieNF { get; set; }
        public int NumeroCupom { get; set; }
        public string SerieCupom { get; set; }
        public int NumeroRPS { get; set; }
        public int NumeroNFDevolvida { get; set; }
        public string SerieNFDevolvida { get; set; }
        public int NumeroCupomDevolvido { get; set; }
        public string SerieCupomDevolvido { get; set; }
        public Boolean ISSQNRetido { get; set; }
        public int CodigoECF { get; set; }
        public Boolean ReusoValvulas { get; set; }
        public string Observacoes { get; set; }
        public Boolean ExportadaNFe { get; set; }
        public string VersaoLeauteNFe { get; set; }
        public string AmbienteNFe { get; set; }
        public DateTime DataRecebimento { get; set; }
        public string NumeroReciboNFe { get; set; }
        public string Protocolo { get; set; }
        public int Status { get; set; }
        public int CodigoLoteNFe { get; set; }
        public DateTime DataCancelamentoNFe { get; set; }
        public string ProtocoloCancelamentoNFe { get; set; }
        public string DigestValueNFe { get; set; }
        public string NotaXML { get; set; }
        public int Orcamento { get; set; }
        public string PlacaVeiculo { get; set; }
        public string CondicaoPgm { get; set; }
        public int QtdIprOSReq { get; set; }
        public int Km { get; set; }
        public Boolean EmissaoContingencia { get; set; }
        public string Historico { get; set; }
        public DateTime DataInclusao { get; set; }
        public int UsuarioInclusao { get; set; }
        public int Venda { get; set; }
        public decimal ValorEntrada { get; set; }
    }
}
