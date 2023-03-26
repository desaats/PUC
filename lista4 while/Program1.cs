
/*1.Escreva um programa que leia 3 valores inteiros e diferentes e mostre-os em ordem
decrescente*/

using System;
using System.Runtime.Intrinsics.X86;

namespace Exemplo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //variáveis
            int valor1, valor2, valor3;
            //entrada, processamento e saída da informação

            Console.WriteLine("Digite 3 valores: ");
            valor1 = int.Parse(Console.ReadLine());
            valor2 = int.Parse(Console.ReadLine());
            valor3 = int.Parse(Console.ReadLine());
            if (valor1 == valor2)
            {
                Console.WriteLine("Digite novamente");
            }
            else if (valor2 == valor3)
            {
                Console.WriteLine("Digite novamente");
            }else if (valor1 == valor3)
            {
              Console.WriteLine("Digite novamente");
            }
            else if (valor1 > valor2 && valor2 > valor3)
            {
                Console.WriteLine(" Valores em ordem decresente : " + valor1 + "," + valor2 + "," + valor3);
            }
            else if (valor1 > valor3 && valor3 > valor2)
            {

                Console.WriteLine(" Valores em ordem decresente : " + valor1 + "," + valor3 + "," + valor2);

            }
            else if (valor2 > valor1 && valor1 > valor3)
            {

                Console.WriteLine(" Valores em ordem decresente : " + valor2 + "," + valor1 + "," + valor3);


            }
            else if (valor2 > valor3 && valor3 > valor1)
            {

                Console.WriteLine(" Valores em ordem decresente : " + valor2 + "," + valor3 + "," + valor1);

            }
            else if (valor3 > valor1 && valor1 > valor2)
            {

                Console.WriteLine(" Valores em ordem decresente : " + valor3 + "," + valor1 + "," + valor2);

            }
            else if (valor3 > valor2 && valor2 > valor1)
            {

                Console.WriteLine(" Valores em ordem decresente : " + valor3 + "," + valor2 + "," + valor1);
            }
        }
    }
 }