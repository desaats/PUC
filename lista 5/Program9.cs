/*9.Faça um programa que calcule e mostre o resultado para o seguinte somatório:*/
using System;

class Program
{
    public static void Main(string[] args)
    {

        //Declaração de variáveis
        float numerador = 1, deno = 225, dife = 29, S = 0;

        //Processamento dos dados
        do
        {
            S = S + numerador / deno;
            numerador = numerador * 2;
            deno = deno - dife;
            dife -= 2;

        }
        while (numerador <= 16384);

        //Saída da informação
        Console.WriteLine("\n\r");
        Console.WriteLine("S = " + S);
    }
}
