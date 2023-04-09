/*4.Construa um programa que leia uma medida em pés e apresente o seu valor convertido
em metros, lembrando que um pé mede 0,3048 metro, ou seja, um pé é igual a 30,48
centímetros.*/

using System;
namespace Exemplo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Declaração de variaveis

            float medida, mediP, medidaM;

            //Entrada de dados

            Console.WriteLine("Digite uma medida em pés: ");
            medida = float.Parse(Console.ReadLine());

            //Processamento dos dados
            
            mediP = medida * 30.48f;
            medidaM = mediP / 100;

            // saída da informação

            Console.WriteLine("O valor em metros é: " + medidaM);






        }
    }
}
