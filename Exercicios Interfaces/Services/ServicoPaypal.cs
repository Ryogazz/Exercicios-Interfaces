//ServicoPaypal chamou IServicoDePagamentoOnline portanto foi obrigado a implemtar os membros do mesmo


namespace Exercicios_Interfaces.Services
{
    class ServicoPaypal : IServicoDePagamentoOnline
    {
        //aqui definimos os valores do juros do paypal
        //private usado para que esses valores nao sejam modificados pelo usuario
        // const usado pois sao valores que NAO podem ser modificados 
        private const double JurosSimples = 0.1;
        private const double TaxaJurosMensal = 0.2;


        public double Juros(double Valor, int Meses)
        {
            return Valor * JurosSimples * Meses;
        }

        public double TaxaDePagamento(double Valor)
        {
            return Valor * TaxaJurosMensal;
        }
    }
}
