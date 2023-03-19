using System;
namespace Exemplo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Declaração de variaveis

            float numero1, numero2;
            //Entrada de dados
            Console.WriteLine("Digite dois numeros: ");
            numero1 = float.Parse(Console.ReadLine());
            numero2 = float.Parse(Console.ReadLine());
            //Processamento dos dados e saída da informação
            if (numero1 <  numero2) 
            { 
                numero1 = numero1 * numero1;
                numero2 =  (float)Math.Sqrt(numero2);
            
                Console.WriteLine("O valor do numero1 é " +numero1+ " e o numero2 é : "  + numero2);
            }
            else 
            {
                numero1 = (float)Math.Sqrt(numero1);
                numero2 = numero2 * numero2;

                Console.WriteLine("O valor do numero1 é " + numero1 + "e o  numero2 é : " + numero2);
            }
            
            
        }
    }
}
