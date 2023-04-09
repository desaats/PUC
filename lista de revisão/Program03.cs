/*3.Faça um programa que leia uma variável e some 5, caso seja par ou some 8, caso seja
ímpar, imprimir o resultado desta operação.*/


using System;
namespace Exemplo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Declaração de variaveis

            int numero = 0; 

            //Entrada de dados
                
                Console.WriteLine("Digite um numero: ");
                numero = int.Parse(Console.ReadLine());

                //Processamento dos dados e saída da informação
                if (numero > 0)
                {
                    numero = numero + 5;
                    Console.WriteLine("O Resultado é: " + numero);
                }
                else if (numero < 0)
                {
                    numero = numero + 8;
                    Console.WriteLine("O Resultado é: " + numero);
                }


         
        }
    }
}
