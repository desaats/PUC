class Program
{
    public static void Main(string[] args)
    {
        double d, g, t, distanciaper;
        Console.WriteLine("Escreva o tempo em segundos: ");
        Console.WriteLine("Escreva o deslocamento: ");
        t = int.Parse(Console.ReadLine());
        d = int.Parse(Console.ReadLine());
        g = 9.81;
        distanciaper = 0.5 * 9.81 * (t * t);
        Console.WriteLine("A distancia é :" + distanciaper);
    }
}
