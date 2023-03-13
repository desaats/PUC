using System;

class Program
{
    static void Main(string[] args)
    {
        double farenheit, centrigados;
        Console.WriteLine("Escreva uma temperatura.");
        farenheit = int.Parse(Console.ReadLine());
        centrigados = (farenheit - 32) * 5 / 9;
        Console.WriteLine("A temperatura em centrigados é = " + centrigados);
    }

}