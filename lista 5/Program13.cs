/*13.Crie um programa que calcula e mostra o M. M. C. entre dois números lidos.*/
using System;
class Program
{
    public static void Main(string[] args)
    {
        //entrada de variáveis
        int numero1, numero2, mmc, maior;
        // entrada de dados

        Console.Write("Digite o primeiro número: ");
        numero1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo número: ");
        numero2 = int.Parse(Console.ReadLine());

        // processamento de dados
        if (numero1 > numero2)
        {
            maior = numero1;
        }
        else
        {
            maior = numero2;
        }

        mmc = maior;
        while (mmc % numero1 != 0 || mmc % numero2 != 0)
        {
            mmc =  mmc * maior;
        }
        // saída da informação
        Console.WriteLine("O MMC entre " + numero1 + " e " + numero2 + " é " + mmc);
    }
}





