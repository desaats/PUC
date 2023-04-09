/*9.Uma das maneiras de se conseguir a raiz quadrada de um número é subtrair do
número os ímpares consecutivos a partir de 1, até que o resultado da subtração seja
menor ou igual a 0 (zero). O número de vezes que se consegue fazer a subtração é a
raiz quadrada exata (resultado =0) ou aproximada do número (resultado negativo).
Exemplo: raiz quadrada de 16 = 4
16 -1 = 15 – 3 = 12 – 5 = 7 – 7 = 0 4 subtrações
Implemente um programa que calcule e imprima a raiz quadrada de um número
fornecido via teclado*/



using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número inteiro: ");
        int num = int.Parse(Console.ReadLine());

        int subtrator = 1;
        int raiz = 0;

        while (num >= 0)
        {
            num = num - subtrator;
            subtrator = subtrator + 2;
            raiz++;
        }

        Console.WriteLine("A raiz quadrada do número digitado é " + (raiz - 1) + ".");
    }
}