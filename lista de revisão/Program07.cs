/*7.Faça um programa que, dado um número inteiro, contabilize a quantidade de dígitos do
número. Exemplo: para o número 34567, seu programa deve imprimir: “O número 34567
possui 5 dígitos. Para este exercício, use somente número inteiro e não use funções prontas
do C#*/

using System;
using System.Runtime.Serialization;

namespace DuvidasProva1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // declarando variaveis 
            int numero, soma = 0;
            int quociente, digitos = 0;

            //entrada de dados 
            Console.WriteLine("Digite um numero:");
            numero = int.Parse(Console.ReadLine());
            
            //processamento de dados

         
            while (numero != 0)
            {
          
                digitos = numero % 10;
                soma = soma + digitos;
                numero = numero / 10;
            }

            Console.WriteLine("A soma dos dígitos do numero digitado é " + soma);

        }
    }
}
