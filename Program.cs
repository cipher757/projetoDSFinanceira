using System;
using System.Globalization;
using System.Collections.Generic;

namespace projetoFinanceira
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Entidades.Contrato> list = new List<Entidades.Contrato>();

            Console.Write("Digite a quantidade de contratos que deseja fazer: ");
            int q = int.Parse(Console.ReadLine());

            for (int i = 1; i <= q; i++)
            {
                Console.WriteLine($"Dados do {i}º contrato");
                Console.Write("Você deseja fazer o contrato de pessoa física ou jurídica (F / J)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Número do contrato: ");
                int numero = int.Parse(Console.ReadLine());
                Console.Write("Nome do contratante: ");
                string contratante = Console.ReadLine();
                Console.Write("Valor do contrato: ");
                double valor = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));
                Console.Write("Prazo do contrato: ");
                int prazo = int.Parse(Console.ReadLine());

                if (ch == 'f')
                {
                    Console.Write("CPF da pessoa física: ");
                    int cpf = int.Parse(Console.ReadLine());
                    Console.Write("Data de nascimento: ");
                    DateTime dataNasc = DateTime.Parse(Console.ReadLine());
                    Console.Write("Data atual: ");
                    DateTime dataAtual = DateTime.Parse(Console.ReadLine());

                    list.Add(new Entidades.ContratoPessoaFisica(numero, contratante, valor, prazo, cpf, dataNasc, dataAtual));
                }
                else
                {
                    Console.Write("CNPJ da pessoa jurídica: ");
                    int cnpj = int.Parse(Console.ReadLine());
                    Console.Write("Inscrição estadual: ");
                    int inscricaoEstadual = int.Parse(Console.ReadLine());

                    list.Add(new Entidades.ContratoPessoaJuridica(numero, contratante, valor, prazo, cnpj, inscricaoEstadual));
                }
                Console.WriteLine();
            }
            Console.WriteLine("Dados do contrato: ");
            Console.WriteLine();
            int a = 1;
            foreach(Entidades.Contrato con in list)
            {
                Console.WriteLine($"Dados do {a}º Contrato");
                Console.WriteLine(con.ExibirInfo());
                Console.WriteLine();
                a++;
            }
        }
    }
}
