using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Vetor Unidirecional
            
            //Vetores são coleçoes de dados do mesmo tipo

            int[] numeros = new int[5]; //Setando um vetor de 5 posiçoes de int
            numeros[0] = 10; //Aplicamos no índice 0 o número 10
            numeros[1] = 20;
            numeros[2] = 30;

            numeros[2] = 55; //Atribuição de outro valor naquele índice

            string[] nomes = {"Caio", "Rita"}; //Aqui startamos o vetor ja com os valores  ( nesse caso com 2 elementos ) - Em tempo de complicação
            //nomes[3] = "Joao"; //Vai dar erro pois ja inicilizamos ele com 2 valores

            string[] nomes2 =  //Outro meio de inicilização
            {
                "Caio2",
                "Jambu"
            };

            #endregion

            #region Matriz ( Bidirecional )

            int[,] matriz = new int[2,3]; // Uma matriz de 2 linhas e 3 colunas
            matriz[0, 0] = 10; //Primeira posição da matriz
            matriz[0, 1] = 20; //Nesse caso estamos alterando a posicao da segunda coluna da primeira linhna
            matriz[0, 2] = 30;

            string[,] matriz2 = // Nesse caso ja estamos instanciando - Aqui temos uma matriz 2x2 (OBS: "CAIO" esta na posicao 0,0)
            {
                {"Caio", "Lilil"}, //Linha 0, colunas 0 e 1
                {"XCablau", "dfdf" } //Linha 1, colunas 0 e 1
            };

            #endregion

            Console.WriteLine(matriz2[0, 1]);
            Console.WriteLine(numeros[2]);
            Console.Write("[" + matriz[0 ,0] + " ");
            Console.Write(matriz[0, 1] + " ");
            Console.Write(matriz[0, 2] + "]");
            Console.WriteLine("");

            #region Multiplicao de Matriz

            int[,] matrizA = new int[2,3];
            int[,] matrizB = new int[3,2];
            int[,] resultado = new int[2,2];

            Console.WriteLine(" -- Preencher a matriz A -- \n");

            for (int linha = 0; linha < 2; linha++)
            {
                for (int coluna = 0;  coluna < 3; coluna++)
                {
                    Console.Write("Posição [" + linha + "][" + coluna + "]: ");
                    matrizA[linha, coluna] = int.Parse(Console.ReadLine());
                }
            
            }

            Console.WriteLine("");
            Console.WriteLine(" -- Preencher a matriz B -- \n");

            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 2; coluna++)
                {
                    Console.Write("Posição [" + linha + "][" + coluna + "]: ");
                    matrizB[linha, coluna] = int.Parse(Console.ReadLine());
                }

            }

            Console.WriteLine("-- Resultado da Multiplicação -- ");

            for (int i = 0; i < 2; i++) //Linhas de A
            {
                for (int j = 0; j < 2; j++) //Colunas de B
                {
                    int soma = 0;

                    for (int k = 0; k < 3; k++) //Colunas de A
                    {
                        soma += matrizA[i, k] * matrizB[k, j];
                    }

                    resultado[i, j] = soma;
                }
            }

            #endregion



        }
    }
}
