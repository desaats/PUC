/*2.Escreva um programa para calcular a soma de 10 números quaisquer fornecidos pelo
usuário*/

using System;
namespace Exemplo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //variáveis
            int num, numero = 0, cont = 1;
            //entrada e processamento
            while (cont <= 10)
            {
                Console.WriteLine("Digite 10 numeros");
                num = int.Parse(Console.ReadLine());
                numero = num + numero;
                cont++;
             }

            //saída da informação
            Console.WriteLine("A soma dos valores são : " + numero);
        }

    }
}

