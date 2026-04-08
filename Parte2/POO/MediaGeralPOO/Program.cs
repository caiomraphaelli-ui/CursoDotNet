using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaGeralPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Média Geral dos Alunos";
            Console.Write("Quantos alunos ? ");

            int nAlunos = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Aluno[] alunos = new Aluno[nAlunos];

            for (int i = 0; i < nAlunos; i++)
            {
                Console.Clear();

                Console.Write($"Digite o nome do aluno {i + 1}: ");
                string nome = Console.ReadLine();

                Console.Write($"Quantas provas o aluno {nome} fez? ");

                int provas = int.Parse(Console.ReadLine());
                alunos[i] = new Aluno(nome, provas);
                alunos[i].InserirNotas();
                Console.WriteLine();
            }

            Console.Clear();

            double mediaGeral = 0;

            foreach (Aluno aluno in alunos)
            {
                Console.WriteLine($"Aluno: {aluno.Nome}");
                Console.WriteLine($"Média: {aluno.Media}");
                Console.WriteLine();

                mediaGeral += aluno.Media;

            }

            double resultadoFinal = mediaGeral / alunos.Length;

            Console.WriteLine($"Media geral dos alunos: {resultadoFinal}");

            Console.ReadKey();
        }
    }
}
