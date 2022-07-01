using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Questão 1: - Faça um programa que receba o nome do aluno, nota de trabalho, nota da prova 1 e nota da prova 2.
            // Calcule a média  final (média simples) e apresente o conceito obtido seguindo a seguinte formula:

            string nome, conceito = "";
            double trabalho, nota1, nota2, media;

            Console.WriteLine("Escreva o nome do aluno: ");
            nome = Console.ReadLine();
            Console.WriteLine("Escreva a nota de trabalho: ");
            trabalho = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escreva a nota da prova 1: ");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escreva a nota da prova 2: ");
            nota2 = Convert.ToDouble(Console.ReadLine());

            media = (trabalho + nota1 + nota2) / 3;

            if (media >= 8.5)
            {
                conceito = "A";
            }
            else if (media > 7 && media < 8.4)
            {
                conceito = "B";
            }
            else if (media > 6 && media < 6.9)
            {
                conceito = "C";
            }
            else if (media > 0.1 && media < 5.9)
            {
                conceito = "D";
            }
            else
            {
                conceito = "E";
            }
            Console.WriteLine(nome + " ficou com conceito  " + conceito);



            Console.ReadKey();
        }
    }
}
