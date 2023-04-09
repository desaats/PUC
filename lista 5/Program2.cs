using System;
class Program
{
    public static void Main(string[] args)
    {   
        // declarando variáveis
        int num,resultado;
        // entrada, processamento e saída de dados
        do
        {
            Console.WriteLine("Digite um numero: ");
            num = int.Parse(Console.ReadLine());
            resultado = num * num;
            Console.WriteLine("Numero: " + num + " Seu Quadrado: " + resultado);
            Console.WriteLine("\n\r");

        } while (num % 6 != 0);
       




        }
    }
