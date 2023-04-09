/*12.Crie um programa que leia uma sequência de números terminada por 0(zero) e imprima
o número que for múltiplo de sua posição na sequência.
Exemplo:
valores lidos: 3 7 8 16
posição: 1 2 3 4
impressão: 3 16*/

using System;
class Program
{
    public static void Main(string[] args)
    {
      
        int numero, posicao = 1;

        Console.Write("Digite uma sequência de números:  ");
        numero = int.Parse(Console.ReadLine());

        while (numero != 0)
        {
            if (numero % posicao == 0)
            {
                Console.Write( numero );
                if (posicao != 1)
                {
                    Console.Write(" DIVISIVEL ");
                }
                Console.Write(" ");
            }

            posicao++;
            numero = int.Parse(Console.ReadLine());
        }
    }
}



