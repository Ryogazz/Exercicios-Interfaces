using System;
using System.Collections.Generic;

namespace Exercicios_Interfaces.Entities
{
    class Contrato
    {
        public int Numero  { get; set; }
        public DateTime Data { get; set; }
        public double ValorTotal { get; set; }
        public List<Prestacoes> Prestacoes { get; set; }

        public Contrato(int numero, DateTime data, double valorTotal)
        {
            Numero = numero;
            Data = data;
            ValorTotal = valorTotal;
            Prestacoes = new List<Prestacoes>();
        }

        public void AdicionarPrestacoes(Prestacoes prestacoes)
        {
            Prestacoes.Add(prestacoes);
        }
    }
}
