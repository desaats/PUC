using System;
namespace Exemplo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Declaração de variaveis
            
            int numero;
            //Entrada de dados
            Console.WriteLine("Digite um numero: ");
            numero = int.Parse(Console.ReadLine());
            //Processamento dos dados e saída da informação
            if (numero < 3)
            {
                Console.WriteLine("Numero menor que 3 ");
            }
            else if ( numero > 25)
            {
                Console.WriteLine("Numero maior que 25");
            }
            else {
                Console.WriteLine("Numero inválido.");

            }
        }
    }
}
