/*10 - Escreva um programa que calcule e mostre o valor da série:
¶ = 4 - 4 + 4 - 4 + ... +/ -4
3 5 7 N*/

using System;

class Program
{
    static void Main(string[] args)
    {
        // entrdada de variaveis
        int numero = 0;
        double soma = 0;

        //processamento de dados 
        Console.Write("Digite a quantidade de termos da série: ");
        numero = int.Parse(Console.ReadLine());

        for (int i = 1; i <= numero; i++)
        {
            double valor = 4.0 / (2 * i - 1);

            if (i % 2 == 0)
            {
                soma= soma - valor;
            }
            else
            {
                soma= soma + valor;
            }
        }
        // Saída de informação

        Console.WriteLine("O valor da série é: {0}", soma);
    }
}