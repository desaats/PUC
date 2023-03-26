/*4.Deseja - se fazer uma pesquisa a respeito do consumo mensal de energia elétrica em uma
determinada cidade. Para isso, são fornecidos os seguintes dados por consumidor:
• preço do kWh;
• quantidade de kWh consumidos durante o mês;
O número de consumidores que participarão da pesquisa é igual a 80. Faça um programa
que leia os dados descritos acima, calcule e imprima
(a) para cada consumidor, o total a pagar,
(b) o maior consumo verificado,
(c) o menor consumo verificado,
(d) a média geral de consumo.*/

using System;
namespace Exemplo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //variáveis
            float precoK, quantidadeKm = 0, consumidores = 0, total = 0, media = 0, soma = 0;
            float maiorV = float.MinValue, menorV = float.MaxValue, cont = 0;

           // entra e processamento de informações 
            while (consumidores < 3)
            {
                Console.WriteLine(" Escreva o preço do kWh: ");
                precoK = float.Parse(Console.ReadLine());
                Console.WriteLine(" Escreva a quantidade kWh consumido por mês: ");
                quantidadeKm = float.Parse(Console.ReadLine());
                total = precoK * quantidadeKm;
                Console.WriteLine("Preço total : "+ total);
                soma = soma + consumidores;
                
                if (quantidadeKm > maiorV)
                {
                    maiorV = quantidadeKm;
                }
                else if(quantidadeKm > menorV)
                {
                    menorV = quantidadeKm;
                  
                }
               
                consumidores++;
            }
            media = soma / 3;

            // saída da informação
            Console.WriteLine("Media é: " + media);
            Console.WriteLine("O maior valor " + maiorV + "O menor valor é : " + quantidadeKm);


        }

    }
}






