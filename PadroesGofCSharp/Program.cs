using PadroesGofCSharp.Adapters;
using PadroesGofCSharp.Cliente;
using PadroesGofCSharp.Models;

Console.WriteLine("-- Bem vindo à loja online FastShoes --");

Console.WriteLine("-- Escolha o seu tênis --\n> 1. Nike Air Force (R$ 2.000)\n> 2. Nike Air Jordan (R$ 3.000)");
int tenisEscolhido = Int32.Parse(Console.ReadLine());
Console.WriteLine("-- Escolha a forma de pagamento --\n> 1. PagXPTO\n> 2. ABCPagamentos");
int pagamentoEscolhido = Int32.Parse(Console.ReadLine());

Console.WriteLine("-- Insira as informações do Cartão de Crédito --");
Console.WriteLine("> Número: ");
int numero = Int32.Parse(Console.ReadLine());
Console.WriteLine("> Nome: ");
string nome = Console.ReadLine();
Console.WriteLine("> Validade: ");
int validade = Int32.Parse(Console.ReadLine());
Console.WriteLine("> CVV: ");
int cvv = Int32.Parse(Console.ReadLine());

int valorAPagar = 0;
BrokerPagamento formaPagamento = new BrokerXPTOAdapter();

switch(tenisEscolhido)
{
    case 1:
        valorAPagar = 2000;
        break;
    case 2:
        valorAPagar = 3000;
        break;
    default:
        valorAPagar = 0;
        break;
}

switch (pagamentoEscolhido)
{
    case 1:
        formaPagamento = new BrokerXPTOAdapter();
        break;
    case 2:
        formaPagamento = new BrokerABCAdapter();
        break;
    default:
        break;
}

CartaoCredito cartaoCredito = new CartaoCredito(numero, nome, validade, cvv);

ServicoPagamento servicoPagamento = new ServicoPagamento();

servicoPagamento.pagarCartaoCredito(formaPagamento, cartaoCredito, valorAPagar);
Console.WriteLine(cartaoCredito.getLimite());