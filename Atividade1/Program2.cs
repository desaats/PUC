using System;
class Program
{
    public static void Main(string[] args)
    {
        double aluno1, aluno2, aluno3, aluno4, soma, mediaA;
        Console.WriteLine("Escreva a nota dos 4 alunos: ");
        aluno1 = int.Parse(Console.ReadLine());
        aluno2 = int.Parse(Console.ReadLine());
        aluno3 = int.Parse(Console.ReadLine());
        aluno4 = int.Parse(Console.ReadLine());
        soma = aluno1 + aluno2 + aluno3 + aluno4;
        mediaA = soma / 4;
        Console.WriteLine("A soma das notas dos alunos são : " + soma);
        Console.WriteLine("A média aritmética das notas é : " + mediaA);
    }
}
