/*Sabendo que o preço de cada parafuso é R$ 0,80, faça um programa que leia o número
de parafusos comprados por um cliente e imprima o preço que este cliente deverá
pagar.*/

using System;
namespace Exemplo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Declaração de variaveis

            float numeroP;
            float valorP, desconto;

            //Entrada de dados

            Console.WriteLine("Digite o numero de parafusos comprados por um cliente: ");
            numeroP = float.Parse(Console.ReadLine());

            //Processamento dos dados e saída da informação
   
                if (numeroP >= 1 && numeroP <= 99)
                {
                    valorP = numeroP * 0.80f;
                    Console.WriteLine(" O valor que deve ser pago é :" +valorP);

                }else if (numeroP >= 100 && numeroP <= 199)
                {
                    desconto = (numeroP / 100) * 10; 
                    valorP = (numeroP * 0.80f) - desconto;
                    Console.WriteLine("O valor que deve ser pago é " + valorP);

                }else if (numeroP >= 200 &&  numeroP <= 299)
                {
                    desconto = (numeroP / 100) * 20;
                    valorP = (numeroP * 0.80f) - desconto;
                    Console.WriteLine("O valor que deve ser pago é " + valorP);

                }else if (numeroP > 299)
                {
                    desconto = (numeroP / 100) * 30;
                    valorP = (numeroP * 0.80f) - desconto;
                    Console.WriteLine("O valor que deve ser pago é " + valorP);
                }

            





        }
    }
}
