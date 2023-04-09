/*2.Encontrar o dobro de um número caso ele seja positivo e o seu triplo caso seja negativo,
imprimindo o resultado.*/

using System;
namespace Exemplo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Declaração de variaveis

            int numero = 0, cont = 0;

            //Entrada de dados
            do
            {
                Console.WriteLine("Digite um numero: ");
                numero = int.Parse(Console.ReadLine());

                //Processamento dos dados e saída da informação
                if (numero > 0)
                {
                    numero = numero * 2;
                    Console.WriteLine("O dobro do numero é: " + numero);
                }
                else if (numero < 0)
                {
                    numero = numero * 3;
                    Console.WriteLine("O triplo do numero é: " + numero);
                }


            } while (numero != 0);

            cont++;
        }
    }
}
