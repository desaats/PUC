using System;
namespace Exemplo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Declaração de variaveis

            float numero;
            //Entrada de dados
            Console.WriteLine("Digite um numero: ");
            numero = float.Parse(Console.ReadLine());
            //Processamento dos dados e saída da informação
            if ((numero > 0) && (numero % 2==0))
            {
                
                Console.WriteLine("Numero é par e positivo ");
            }
            else
            { 
                Console.WriteLine("Numero não é par ou positivo");
            }
            
        }
    }
}