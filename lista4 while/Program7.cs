
/*7.Escreva um programa para calcular e escrever o valor final de S:
S = 1 / 1 + 2 / 4 + 4 / 16 + 5 / 25 + 6 / 36 + ... 10 / 100*/

using System;
namespace Exemplo
{
    class MainClass
    {
        public static void Main(string[] args)
        {


            //variáveis
            float S = 0, numerador = 1;
             //entrada e processamento
             while (numerador <= 10)
             {
                 S = S + numerador/ (numerador * numerador);
                 numerador++;

             }
             
             //Saída da informação
             Console.WriteLine("RESULTADO " + S);
        }
    }
}

    


