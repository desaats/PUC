
/*5.Escreva um programa que leia o peso de um indivíduo. Considere que serão lidos os pesos
de 30 pessoas. Calcule e mostre:
-A média aritmética dos pesos das pessoas que possuem mais de 60 Kg
- O valor do peso da pessoa mais pesada*/

using System;
using System.Xml.Serialization;

class Program
{
    public static void Main(string[] args)
    {
        // DECLARANDO AS VARIÁVEIS
        float peso, pessoas = 0, soma_60 = 0, cont = 0;
        float maisP = float.MinValue, media = 0;

        //ENTRADA E PROCESSAMENTO
        while (pessoas < 5)
        {
            Console.WriteLine("Digite o peso de 30 pessoas.");
            peso = float.Parse(Console.ReadLine());
            

            if (peso > maisP)
            {
                maisP = peso;
            }

            else if (peso > 60)
            {
                 cont++;
                 soma_60 = soma_60 + peso;
            }
            
            pessoas++;

        }
        media = soma_60 / cont;


        Console.WriteLine("A pessoa mais pesada: " + maisP);
        Console.WriteLine("MEDIA DAS 30 PESSOAS: " + media);
    }
}

