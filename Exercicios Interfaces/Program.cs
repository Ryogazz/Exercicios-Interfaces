using System;
using System.Globalization;
using Exercicios_Interfaces.Entities;
using Exercicios_Interfaces.Services;

namespace Exercicios_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os dado do contrato");
            Console.Write("Numero: ");
            int numeroDoContrato = int.Parse(Console.ReadLine());
            Console.Write("Data (dd/MM/yyyy): ");
            DateTime DataDoContrato = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Valor do contrato: ");
            double valorDoContrato = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o numero de parcelas: ");
            int meses = int.Parse(Console.ReadLine());

            //criando o objeto contrato
            Contrato meuContrato = new Contrato(numeroDoContrato, DataDoContrato, valorDoContrato);

            //criando o objeto servicoDeContratacao que tem os dados de servicoDeContratacao + ServicoPaypal
            //depois chamando o metodo ProcessoDeContratacao
            //com o objeto motando ele chama o metodo ProcessoDeContratacao 
            //com os dados de meu contrato e meses
            ServicoDeContratacao servicoDeContratacao = new ServicoDeContratacao(new ServicoPaypal());
            servicoDeContratacao.ProcessoDeContratacao(meuContrato, meses);

            Console.WriteLine("Prestaçõe:");
            foreach(Prestacoes prestacoes in meuContrato.Prestacoes)
            {
                Console.WriteLine(prestacoes);
            }

        }
    }
}
