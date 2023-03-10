using System;
class Program
{
    public static void Main(string[] args)
    {
        double raio, pi, perimetro;
        Console.WriteLine("Escreva o raio de uma circunferência: ");
        raio = int.Parse(Console.ReadLine());
        pi = 3.14;
        perimetro = 2 * pi * raio;
        Console.WriteLine("O valor do perímetro é :" + perimetro);
    }
}