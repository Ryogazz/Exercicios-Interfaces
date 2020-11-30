using System;
using Exercicios_Interfaces.Entities;
namespace Exercicios_Interfaces.Services
{
    class ServicoDeContratacao
    {
        //criando a variavel _servicoDePagamentoOnline do tipo IServicoDePagamentoOnline que e usada pelo contrutor 
        //pois _servicoDePagamentoOnline e privada
        private IServicoDePagamentoOnline _servicoDePagamentoOnline;

        public ServicoDeContratacao(IServicoDePagamentoOnline servicoDePagamentoOnline)
        {
            _servicoDePagamentoOnline = servicoDePagamentoOnline;
        }

        //esse metodo ta guardando os dados que vamos inserir, dentro de servicoDePagamentoOnline
       // e esses dados depois o ServicoPaypal vai pegar ele e "trabalhar" eles
        public void ProcessoDeContratacao(Contrato contrato, int meses)
        {
            double ValorBase = contrato.ValorTotal / meses;
            for(int i = 1; i <= meses; i++)
            {
                DateTime data = contrato.Data.AddMonths(i);
                double ValorParcelaSimples = ValorBase + _servicoDePagamentoOnline.Juros(ValorBase, i);
                double ValorParcelaTotal = ValorParcelaSimples + _servicoDePagamentoOnline.TaxaDePagamento(ValorParcelaSimples);
                contrato.AdicionarPrestacoes(new Prestacoes(data, ValorParcelaTotal));
            }
        }
    }
}
