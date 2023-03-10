class Program
{
    public static void Main(string[] args)
    {
        int consorcio, totalP, valorA,  totalC, falta;
        Console.WriteLine("Escreva o numero total de prestações do consórcio :");
        consorcio = int.Parse(Console.ReadLine());

        Console.WriteLine("Escreva o total de prestações pagas :");
        totalP = int.Parse(Console.ReadLine());

        Console.WriteLine("Escreva o valor atual das prestações :");
        valorA= int.Parse(Console.ReadLine());

        totalC = consorcio * valorA; 
        falta =  totalC - (totalP * valorA);
        Console.WriteLine("O valor do consórcio é "+  totalC + ", ainda falta pagar " + falta + " reais.");
         

      
    }
}