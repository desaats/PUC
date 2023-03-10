using System;
class Program
{
    public static void Main(string[] args)
    {
        // Declaração de variáveis
        double construcao, casasU,salarioM, dolar,casasC;

        //Entrada de dados 
        Console.WriteLine("Escreva o valor do salário mínimo em reais:");
        salarioM = int.Parse(Console.ReadLine());

        //Processamento dos dados
        dolar = salarioM / 5.15;
        casasU= dolar * 150;
        construcao = 10000000;
        casasC = construcao / casasU;

        //Saída da informação 
        Console.WriteLine("A quantiade de casas que podemos construir são: " + casasC);
    }
}
