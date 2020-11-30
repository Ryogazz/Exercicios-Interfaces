using System;
using System.Globalization;

namespace Exercicios_Interfaces.Entities
{
    class Prestacoes
    {
        public DateTime DataDeVencimento { get; set; }
        public double Valor { get; set; }

        public Prestacoes(DateTime dataDeVencimento, double valor)
        {
            DataDeVencimento = dataDeVencimento;
            Valor = valor;
        }

        public override string ToString()
        {
            return DataDeVencimento.ToString("dd/MM/yyyy")
                + " - "
                + Valor.ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}
