using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaGeralPOO
{
    internal class Aluno
    {
        public string Nome { get; private set; }
        private double[] Notas;

        public double Media
        {
            get
            {
                return CalcularMedia();
            }
        }

        public Aluno(string nome, int provas)
        {
            Nome = nome;
            Notas = new double[provas];
        }

        public void InserirNotas()
        {
            for (int i = 0; i < Notas.Length; i++)
            {
                Console.Write($"Digite a nota da prova {i + 1}: ");
                Notas[i] = double.Parse(Console.ReadLine());
            }
        }

        private double CalcularMedia()
        {
            double soma = 0;
            foreach (double nota in Notas)
            {
                soma += nota;
            }
            return Notas.Length > 0 ? soma / Notas.Length : 0;
        }
    }
}
