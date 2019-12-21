using System;
using System.Globalization;
namespace Exercicio_ConversaoDolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com a cotação do Dolar: ");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double qtDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            //Chamada do método estático
            double result = ConversorDeMoeda.ConversaoDolar(dolar, qtDolar);

            Console.WriteLine("Valor a ser pago em reais = " + result.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}
