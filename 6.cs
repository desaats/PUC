using System;

class Program
{
    static void Main(string[] args)
    {
        double pressao, volume, temperatura, pv, m, massa;
        Console.WriteLine("Escreva a pressão do peneu.");
        Console.WriteLine("Escreva o volume do peneu");
        Console.WriteLine("Escreva a temperatura do peneu");
        pressao = int.Parse(Console.ReadLine());
        volume = int.Parse(Console.ReadLine());
        temperatura = int.Parse(Console.ReadLine());
        pv = pressao * volume;
        m = 0.37 * (temperatura + 460);
        massa = m / pv;

        Console.WriteLine("A massa do pneu é = " + massa);
    }

}