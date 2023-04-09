using System;
class Program
{
    public static void Main(string[] args)
    {
        //declarando variáveis
        float saldo, valor;
        float menorV = float.MaxValue, cont = 0;

        // entrada de dados
        Console.WriteLine("Digite o valor do saldo.");
        saldo = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor que será depositado.");
        valor = float.Parse(Console.ReadLine());

        
            //processamento de dados
            if (saldo > valor)
            {
                menorV = saldo;
            }
            else if (saldo < valor)
            {
                saldo = saldo + valor;
                
            }
            
        
      
        // saída de dados
        Console.WriteLine("O SALDO É :" + saldo);
    }
}
