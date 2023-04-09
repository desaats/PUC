/*14.Repare a seguinte característica do número 3025: 30 + 25 = 55 e 552 = 3025
Crie um programa que possa ler vários números inteiros de 4 algarismos, um de cada vez, e
diga se o número apresenta a mesma característica (repare que 3025/100 =30 com resto
25). O algoritmo termina quando for lido um valor menor que 1.000 ou maior que 9999.
Utilize apenas operações aritméticas básicas na solução desta questão.*/

using System;
class Program
{
    public static void Main(string[] args)
    {
        //entrada de variáveis
        int numero, divisao, resto, soma = 0 ;
        // entrada de dados, processamento e saída
        do
        {
            Console.WriteLine("Digite um numero de 4 algarismos:");
            numero = int.Parse(Console.ReadLine());


            if (numero >= 1000 && numero <= 9999)
            {
                divisao = numero / 100;
                resto = numero % 100;
                soma = divisao + resto;


            }
            if (soma * soma == numero)
            {
                Console.WriteLine("O NÚMERO APRESENTA A MESMA CARACTERISTICA.");
            }
            else
            {
                Console.WriteLine("O NÚMERO NÃO APRESENTA A MESMA CARACTERISTICA.");

            }



        } while (numero >= 1000);
      }
   }