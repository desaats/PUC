/*6.Escrever um programa que leia 60 números e conte quantos deles estão nos seguintes
intervalos: [0-25], [26-50], [51-75] e[76 - 100].*/

using System;
namespace Exemplo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //variáveis
            int num = 0, cont = 0, numeros = 1;
            //entrada e processamento
            while (numeros <= 10) {
                Console.Write(" Digite 60 numeros :");
                num = int.Parse(Console.ReadLine());
                if (num > 0 && num < 25){

                    cont++;
                } else if (num > 26 && num < 50){

                    cont++;
                }else if (num > 51 && num < 75){

                   cont++;
                }else if (num > 76 && num < 100) {

                   cont++;
                }
                else {
                    Console.WriteLine(" Não está no intervalo ! ");
                }
                numeros++;

            }
            
            //Saída da informação
            Console.WriteLine(" Estão dentro dos intervalos : " + cont);



        }

    }
}




