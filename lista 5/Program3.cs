using System;
class Program
{
    public static void Main(string[] args)
    {
        //entrada de variáveis
        float pessoas;
        // entrada de dados 
        Console.WriteLine("Digite o numero de pessoas que assitiram a uma partida de futebol");
        pessoas = float.Parse(Console.ReadLine());
        // processamento de dados e saída de dados
        if (pessoas <= 1000)
        {
            Console.WriteLine("Público baixo");
        }else if (pessoas >= 1001 && pessoas <= 10000)
        {
            Console.WriteLine("Público médio");

        }else if (pessoas > 10000)
        {
            Console.WriteLine("Público alto");
        }



    
    }
}
