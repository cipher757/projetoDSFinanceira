using System;
using System.Collections.Generic;
using System.Text;
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

        public override double calcularPrestacao()
        {
            return Valor / Prazo + 3.00;
        }

        public override string exibirInfo()
        {
            return "Valor do contrato: "
                + Valor.ToString("F2", CultureInfo.InvariantCulture)
                + "\r\n Prazo do contrato: "
                + Prazo
                + " meses\r\nValor da Prestação "
                + calcularPrestacao().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
