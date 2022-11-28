using System.Globalization;

namespace projetoFinanceira.Entidades
{
    class Contrato
    {
        public int Numero { get; set; }
        public string Contratante { get; set; }
        public double Valor { get; set; }
        public int Prazo { get; set; }

        public Contrato() { }

        public Contrato(int numero, string contratante, double valor, int prazo)
        {
            Numero = numero;
            Contratante = contratante;
            Valor = valor;
            Prazo = prazo;
        }

        public virtual double CalcularPrestacao()
        {
            return Valor / Prazo;
        }

        public virtual string ExibirInfo()
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
