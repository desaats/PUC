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
            if (numero > 20 && numero < 90)
            {
                Console.WriteLine("O numero está compreendido entre 20 e 90");
            }
            else 

            {
                Console.WriteLine("O numero não está entre 20 e 90");
            }
           
        }
    }
}
