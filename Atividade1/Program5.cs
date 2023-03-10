
using System;

class Program
{

    public static void Main(string[] args)
    {
        double n, custoN, l, custoL, b, custoB, totalC, totalL, totalB, totalM;
        
        Console.WriteLine("Escreva a quantidade de Latas de chocolate e o seu valor unitario: ");
        n = int.Parse(Console.ReadLine());
        custoN = int.Parse(Console.ReadLine());
        totalC = custoN * n;
        Console.WriteLine("Latas de chocolate");
        Console.WriteLine("Total gasto: " + totalC);

        Console.WriteLine("Escreva a quantidade de Litros de leite e o seu valor unitario: ");
        custoL = int.Parse(Console.ReadLine());
        l = int.Parse(Console.ReadLine());
        totalL = custoL* l;
        Console.WriteLine("Leite");
        Console.WriteLine("Total gasto: " + totalL);

        Console.WriteLine("Escreva a quantidade de bananas e o seu valor unitario: ");
        custoB = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        totalB = custoB * b;
        Console.WriteLine("Bananas");
        Console.WriteLine("Total gasto: " + totalB);

        totalM = totalC + totalL + totalB;

        Console.WriteLine("O valor total gasto no mercado é: " + totalM);

    }

}
