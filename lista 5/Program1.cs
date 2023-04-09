using System;
class Program { 
public static void Main(string[] args)
{ 
    // declarando variáveis
    int num1, num2, resultado;

    // entrada, processamento e saída 
    for ( num1 = 1; num1 <= 10; num1++)
            for(num2 = 1; num2 <= 10;num2++)
    {
                resultado = num1 * num2;
                

                Console.WriteLine(num1 + " * " + num2 + " = " + resultado );



            }
    }
}