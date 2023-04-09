/*7.Escrever um programa que leia um número n que indica quantos valores devem ser lidos
a seguir. Para cada número lido, mostre uma tabela contendo o valor lido e o fatorial deste
valor.*/
using System;
using System.Drawing;

class Program
{
    public static void Main(string[] args)
    {
        // DECLARANDO VARIÁVEIS
        int numeroN, valor;

        //ENTRADA, PROCESSAMNETO E SAÍDA DA INFORMAÇÃO
        Console.WriteLine("Digite o numero que vai indicar quantos valores devem ser lidos.");
        numeroN = int.Parse(Console.ReadLine());
        for (int i = 1; i <= numeroN; i++)
        {
            Console.WriteLine("Digite o valor a ser calculado.");
            valor = int.Parse(Console.ReadLine());

            int fatorial = 1;
            for(int p = valor; p >=1 ; p--)
            {
                fatorial = fatorial * p;
            }
            Console.WriteLine("\t fatorial de {0} e {1}", valor, fatorial) ;
        }
       
    }
}

