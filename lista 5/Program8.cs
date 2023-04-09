/*8.Faça um programa que realize e mostre o produto entre 2 números inteiros A e B, através
de somas sucessivas. Os números deverão ser lidos do teclado*/
using System;
using System.Drawing;

class Program
{
    public static void Main(string[] args)
    {
        // DECLARANDO VARIÁVEIS
        int a, b, produto = 0;
       
        //ENTRADA, PROCESSAMNETO E SAÍDA DA INFORMAÇÃO
        Console.WriteLine("Digite um valor de a.");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite um valor de b.");
        b = int.Parse(Console.ReadLine());

       
        for (int i = 1; i <= b; i++)
        {
            produto = produto + a;
        }
        Console.WriteLine("O produto de " + a + " e de " + b + " é " + produto);

    }
}
