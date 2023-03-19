using System;

class Program
{
    public static void Main(string[] args)
    {

        // declaração de variável
        double valorP, lucro;
       
        // entrada da informação 
        Console.WriteLine("Escreva o valor do produto: ");
        valorP = double.Parse(Console.ReadLine());
       
        // Processamento e sa[ida da informação
        if (valorP < 20)
        {
            lucro = valorP * 0.45;
            Console.WriteLine("O um lucro de 45% : " + lucro);



        }
        else if (valorP > 20)
        {
            lucro = valorP * 0.30;
            Console.WriteLine("O um lucro de 30% : " + lucro);

        }
        else
        {
            Console.WriteLine("Valor invalido");
        }



    }
}