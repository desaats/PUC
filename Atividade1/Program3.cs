class Program
{
    public static void Main(string[] args)
    {
        int ano, mes, dia, totalD;
        Console.WriteLine("Escreva a data de nascimento de uma pessoa. Ex: (Ano, mes, dia)");
        ano = int.Parse(Console.ReadLine());
        mes = int.Parse(Console.ReadLine());
        dia = int.Parse(Console.ReadLine());
        totalD = (ano * 365) + (mes * 30) + dia;
        Console.WriteLine("A idade em dias é : " + totalD);
    }
}
