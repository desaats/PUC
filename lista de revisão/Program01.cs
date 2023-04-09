/*1.Faça um programa que leia os valores A, B, C e imprima na tela se a soma de A + B é
menor que C.*/

using System;
namespace Exemplo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Declaração de variaveis

            int a, b, c, soma;

            //Entrada de dados
            Console.WriteLine("Digite tres valores : ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            soma = a + b;

            //Processamento dos dados e saída da informação
            if (soma < c)
            {
                Console.WriteLine("A soma de A e B / " + soma + " e menor que C /" + c );
            }
            else
            {
                Console.WriteLine(" A soma de A e B e maior que C");
            }


        }
    }
}
