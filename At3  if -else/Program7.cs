using System;

class Program
{
    public static void Main(string[] args)
    {

        // declaração de variável
        int litros;
        
        // entrada da informação
        Console.WriteLine("Escreva o numero de litros colocados no automovel: ");
        litros = int.Parse(Console.ReadLine());
        // processamento e saída da informação
        if (litros < 10 && litros > 0)
        {

            Console.WriteLine("PARABÉNS, VOCÊ GANHOU UM CHAVEIRO ");



        }
        else if (litros >= 10)
        {


            Console.WriteLine("PARABÉNS, VOCÊ GANHOU UMA DUCHA ");


        }
        else
        {
            Console.WriteLine("Valor invalido");
        }



    }
}