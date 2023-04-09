/*8.Faça um programa em C# que execute a potenciação entre dois números inteiros usando
apenas multiplicações sucessivas. Mostre o resultado da potenciação. Não use a função
Math.Pow(A, B).*/
using System;
namespace Exemplo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Declaração de variaveis

            int numero, elevado;
        
            //Entrada de dados

            Console.WriteLine("Digite o numero dois numeros: ");
            numero = int.Parse(Console.ReadLine());
            elevado = int.Parse(Console.ReadLine());


            //Processamento dos dados e saída da informação
            int resultado = 1

            for (int i = 0; i < elevado; i++) ;
            {
                resultado = resultado * numero;]
            }

            Console.WriteLine(numero + " elevado a " + elevado + " é igual a " + resultado );








        }
    }
}
