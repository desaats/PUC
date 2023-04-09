/*11.Faça um programa que leia um número e verifique se ele é ou não quadrado perfeito.
Um número é um quadrado perfeito quando tem um número inteiro como raiz quadrada.*/
using System;
class Program
{
    public static void Main(string[] args)
    {
        //entrada de variáveis
        int numero, raiz, quadradop;
        // entrada de dados, processamento e saída
        do
        {
            Console.WriteLine("Digite um numero");
            numero = int.Parse(Console.ReadLine());
            raiz = (int)Math.Sqrt( numero);

            if (raiz * raiz == numero)
            {
                Console.WriteLine("O número é um quadrado perfeito");

            }else
            {
                Console.WriteLine("Não é um quadrado perfeito");
            }

        
            
        }while (numero > 0);
        
        
        
     




    }
}