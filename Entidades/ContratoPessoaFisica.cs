using System;
using System.Globalization;

namespace projetoFinanceira.Entidades
{
    class ContratoPessoaFisica : Contrato
    {
        public int Cpf { get; set; }
        public DateTime DataNasc { get; set; }
        public DateTime DataAtual { get; set; }

        public ContratoPessoaFisica() { }

        public ContratoPessoaFisica(int numero, string contratante, double valor, int prazo, int cpf, DateTime dataNasc, DateTime dataAtual) : base(numero, contratante, valor, prazo)
        {
            Cpf = cpf;
            DataNasc = dataNasc;
            DataAtual = dataAtual;
        }

        public int CalcularIdade()
        {
            TimeSpan idade = DataAtual - DataNasc;
            return (idade.Days) / 30 / 12;
        }

        public override double CalcularPrestacao()
        {
            if (CalcularIdade() <= 30)
            {
                return (Valor / Prazo) + 1.00;
            }
            else if (CalcularIdade() <= 40)
            {
                return (Valor / Prazo) + 2.00;
            }
            else if (CalcularIdade() <= 50)
            {
                return (Valor / Prazo) + 3.00;
            }
            else
            {
                return (Valor / Prazo) + 4.00;
            }
        }

        public override string ExibirInfo()
        {
            return "Valor do contrato: "
            + Valor.ToString("F2", CultureInfo.InvariantCulture)
            + "\r\nPrazo do contrato: "
            + Prazo
            + " meses\r\nValor da prestação: "
            + CalcularPrestacao().ToString("F2", CultureInfo.InvariantCulture)
            + "\r\nIdade do contratante: "
            + CalcularIdade();
        }
    }
}
