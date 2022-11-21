using System;
using System.Collections.Generic;
using System.Text;

namespace projetoFinanceira.Entidades
{
    class ContratoPessoaFisica : Contrato
    {
        public int Cpf { get; set; }
        public DateTime DataNasc { get; set; }
        public DateTime DataAtual { get; set; }

        public ContratoPessoaFisica() { }

        public ContratoPessoaFisica(int numero, string contratante, double valor, int prazo, int cpf, DateTime dataNasc, DateTime dataAtual)
        {

        }

        public override double calcularPrestacao()
        {
            
            if ()
        }
    }
}
