/*5.Desenvolver um programa que efetue a soma de todos os números ímpares que são
múltiplos de três e que se encontram no conjunto dos números de 500 até 2100*/

using System;
using static System.Net.Mime.MediaTypeNames;

namespace Exemplo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //variáveis
            int cont = 500, numero = 0;
         

            //entrada e processamento
            while ( cont <=2100)
            {
              


            if ( cont % 3 == 0)
            {
                numero =  numero+ cont;

             }
             cont++;

            }
            
            //saída da informação
            Console.WriteLine("Soma: " + numero);
        }
      }
  
 }

    





