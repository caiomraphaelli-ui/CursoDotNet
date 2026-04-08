using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Switch - Case
            //Estrutura Switch case
            //Switch serve para fazer várias comparações de uma variável com vários valores possíveis
            //Também podemos criar enums para facilitar a leitura do switch case


            int escolha = 1;

            switch (escolha) //O case precisa ser do mesmo tipo da variável passada no switch
            {
                default: //Caso nenhum case seja atendido, ele cai no default
                    Console.WriteLine("Opção inválida");
                    break;

                case 1:
                    Console.WriteLine("Opção 1 selecionada");
                    break;
                case 2:
                    Console.WriteLine("Opção 2 selecionada");
                    break;
                case 3:
                    Console.WriteLine("Opção 3 selecionada");
                    break;

                    //Precisa de um break para cada case, senão o código "cai" no próximo case


            }
        #endregion

            #region Declaração Goto

        //Serve para pular para um ponto específico do código

        Inicio: //Label - Ponto de referência para o goto

            Console.Write("Escolha uma opção: ");

            int op = int.Parse(Console.ReadLine());
            int valor = 0;

            switch (op)
            {
                default:
                    goto Inicio; //Se a opção for inválida, volta para o início
                case 1:
                    valor += 100;
                    break;
                case 2:
                    valor += 200;
                    goto case 1; //Pula para o case 1 - Muda o fluxo

                    //Nesse caso será somado 300 ao valor, pois o case 2 pula para o case 1
            }

            #endregion

            #region Estruturas de Repetição

            //Estruturas de repetição - Serve para repetir um bloco de código várias vezes
            //Temos o for, while, do while e foreach

            valor = 0;

            while (valor < 500) //Enquanto o valor for menor que 500
            {
                Console.WriteLine("Valor atual: " + valor);
                valor += 100; //Incrementa 100 ao valor
            }


            do //Faz tudo que estiver dentro do bloco até a condição ser falsa
            {
                Console.WriteLine("Valor atual: " + valor);
                valor -= 50; //Decrementa 50 do valor

            } while (valor > 0); //Executa o bloco de código pelo menos uma vez

            //For - Estrutura de repetição com contador

            for (int i = 0; i < 5; i++) //i começa em 0, enquanto i for menor que 5, incrementa 1
            {
                Console.WriteLine("Contador: " + i);
            }
            //Podemos usar break e continue nas estruturas de repetição
            //Podemos também usar mais de uma variável no for
            
            for (int i = 0, j = 10; i < 5; i++, j--) //i começa em 0, j começa em 10
            {
                Console.WriteLine("i: " + i + " | j: " + j);
            }

            string[] nomes = { "Ana", "Bruno", "Carlos" };

            //Foreach - Estrutura de repetição para percorrer arrays e coleções
            
            foreach (string nome in nomes) //Para cada nome na coleção nomes
            {
                Console.WriteLine("Nome: " + nome);
            }

            //Nesse exemplo vamos ter 3 iterações, uma para cada elemento do array nomes
            //No foreach o tipo da variável deve ser o mesmo tipo dos elementos da coleção

            #endregion

        }
    }
}
