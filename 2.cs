public class Example
{
    public static void Main(string[] args)
    {

        float raio, area , pi;

        Console.WriteLine(" Escreva o valor do raio de um círculo: ");
        raio = float.Parse(Console.ReadLine());
        pi = 3.14f;
        area =  (float)Math.Pow(raio, 2) * pi;
        Console.WriteLine("  A = : " + area);

    }
}