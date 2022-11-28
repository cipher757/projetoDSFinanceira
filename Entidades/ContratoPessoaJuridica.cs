using System;
using System.Globalization;

namespace projetoFinanceira.Entidades
{
    class ContratoPessoaJuridica : Contrato
    {
        public int CNPJ { get; set; }
        public int InscricaoEstadual { get; set; }

        public ContratoPessoaJuridica()
        {

        }

        public ContratoPessoaJuridica(int numero, string contratante, double valor, int prazo, int cnpj, int inscricaoestadual) : base(numero, contratante, valor, prazo)
        {
            CNPJ = cnpj;
            InscricaoEstadual = inscricaoestadual;
        }

        public override double CalcularPrestacao()
        {
            return Valor / Prazo + 3.00;
        }

        public override string ExibirInfo()
        {
            return "Valor do contrato: "
            + Valor.ToString("F2", CultureInfo.InvariantCulture)
            + "\r\nPrazo do contrato: "
            + Prazo
            + " meses\r\nValor da prestação: "
            + CalcularPrestacao().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
