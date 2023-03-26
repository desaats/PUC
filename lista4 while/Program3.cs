/*3. Escreva um programa para ler a idade de 40 pessoas, exibir a idade da pessoa mais nova,
calcular a idade média e calcular a porcentagem de pessoas com idade entre 24 e 30 anos.*/

using System;
namespace Exemplo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //variáveis
            int cont = 0, idade = 0;
            float maisN= float.MaxValue, soma = 0, media, porcentagem, conta = 0;
            
            //entrada e processamento
            while (cont < 40)
            {
                Console.Write("Digite a idade de 40 pessoas : ");
                idade = int.Parse(Console.ReadLine());
                soma = soma + idade;

                if (idade < maisN)
                {
                    maisN = idade;
                }else if(idade >= 24 && idade <= 30)
                {
                    conta++; 
                
                 
                }
                 cont++;
             }

            media = soma / 40;
            porcentagem = (conta / 40) * 100;





            Console.WriteLine("IDADE DA MAIS NOVA: " + maisN);
            Console.WriteLine("PORCENTAGEM DAS PESSOAS ENTRE 24 E 30 ANOS: " + porcentagem);
            Console.WriteLine("MEDIA DAS 40 PESSOAS: " + media);
        }

       }
   }





