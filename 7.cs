using System;

class Program
{
    static void Main(string[] args)
    {
        double tempo, horas, minutos, segundos;
        Console.WriteLine("Escreva as horas, os minutos e os segundos de um tempo.");
        horas = int.Parse(Console.ReadLine());
        minutos = int.Parse(Console.ReadLine());
        segundos = int.Parse(Console.ReadLine());
        tempo = (horas * 3600) + (minutos * 60) + segundos;
        Console.WriteLine("O tempo em minutos é : " + tempo);
    }

}
