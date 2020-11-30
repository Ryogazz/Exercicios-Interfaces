//Interface e um contrato que define que onde ele for chamado sera obrigatorio implementar os
//membros do mesmo 

namespace Exercicios_Interfaces.Services
{
    interface IServicoDePagamentoOnline
    {
      double Juros(double Valor, int Meses);
      double TaxaDePagamento(double Valor);
    }
}
