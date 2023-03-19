using System;
namespace Exemplo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Declaração de variaveis

            float numero;
            //Entrada de dados
            Console.WriteLine("Digite um numero. ");
            numero = float.Parse(Console.ReadLine());
            
            //Processamento dos dados e saída da informação
            if (numero > 0)
            {
               
                numero = (float)Math.Sqrt(numero);

                Console.WriteLine("O valor do numero é: " + numero);
            }
            else
            {
                numero = (float)Math.Pow(numero, 2);
               

                Console.WriteLine("O valor do numero é: " + numero);
            }


        }
    }
}
