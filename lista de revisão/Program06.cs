/*6.Faça um programa que leia um código e três valores: N1, N2 e N3. Os códigos válidos são
1, 2, 3, 4 e 5. Se o código for diferente destes, apresentar a mensagem “CÓDIGO INVÁLIDO”
e terminar o programa. Caso contrário, efetue o que se pede:
código = 1: multiplicar os três valores;
código = 2: somar os três valores;
código = 3: subtrair os três valores;
código = 4: somar o quadrado dos 3 valores;
código = 5: subtrair o quadrado dos 3 valores.*/
using System;
namespace Exemplo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Declaração de variaveis

            float numero1, numero2, numero3,resultado;
            char opcao;

            //Entrada de dados
            
                Console.WriteLine("Digite um numero: ");
                numero1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Digite um numero: ");
                numero2 = float.Parse(Console.ReadLine());
                Console.WriteLine("Digite um numero: ");
                numero3 = float.Parse(Console.ReadLine());
                Console.WriteLine("Opção: 1- para multiplicar, 2- para somar, 3- para subtrair, 4- somar o quadrado dos 3 valores, 5- subtrair o quadrado dos 3 valores ");
                opcao = char.Parse(Console.ReadLine());

                //Processamento dos dados e saída da informação

                switch (opcao)
                {
                    case '2':
                        resultado = numero1 + numero2 + numero3;
                        Console.WriteLine("Soma: " + resultado);
                        break;
                    case '3':
                        resultado = numero1 - numero2 - numero3;
                        Console.WriteLine("Soma: " + resultado);
                        break;
                    case '1':
                        resultado = numero1 * numero2 * numero3;
                        Console.WriteLine("Soma: " + resultado);
                        break;
                    case '4':
                        resultado = (numero1 * numero1) + (numero2 * numero2) + (numero3 * numero3);
                        Console.WriteLine("Soma: " + resultado);
                        break;
                    case '5':
                        resultado = (numero1 * numero1) - (numero2 * numero2) - (numero3 * numero3);
                        Console.WriteLine("Soma: " + resultado);
                        break;
                default:
                    Console.WriteLine("CÓDIGO ENVALIDO");
                    break;

            }






        }
    }
}
