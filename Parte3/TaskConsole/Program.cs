using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskConsole
{
    internal class Program
    {
        //Task é uma classe que representa uma operação assíncrona. Ela é usada para executar código de forma assíncrona, permitindo que o programa continue a executar outras tarefas enquanto a operação assíncrona está em andamento.
        //A diferenca entre Task e Thread é que a Task é uma abstração de alto nível para operações assíncronas, enquanto a Thread é uma unidade de execução de baixo nível. A Task é gerenciada pelo .NET Framework e pode ser usada para executar código de forma assíncrona sem a necessidade de gerenciar threads manualmente.

        static void Main(string[] args)
        {
            #region Task Parte 1

            //Diferentes formas de criar uma Task

            /*
            Task t1 = new Task(Tarefa);
            t1.Start();

            Task t2 = Task.Run(Tarefa);

            Task.Run(Tarefa);
            */

            /*
            Task.Factory.StartNew(Tarefa);

            Task.Run(() => {

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Tarefa Anonima");
                }

            });

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Principal");
            }
            
            */
            #endregion

            #region Task Parte 2

            /*
            //Array de Tasks serve para armazenar várias tarefas e executá-las em paralelo. Ele é útil quando você tem várias operações assíncronas que podem ser executadas simultaneamente.
            Task[] tasks =
            {
                Task.Factory.StartNew(() => {
                    Console.WriteLine("Tarefa #1");
                }),

                Task.Factory.StartNew(() => {
                    Console.WriteLine("Tarefa #2");
                }),

                Task.Factory.StartNew(() => {
                    Console.WriteLine("Tarefa #3");
                })  
            };

            Task.WaitAll(tasks); //Aguarda todas as tarefas do array serem concluídas antes de continuar a execução do programa.

            Console.WriteLine("Principal");

            */
            #endregion

            #region Task Parte 3

            //Task<int> tarefa1 = Task.Factory.StartNew(() => Dobro(2));

            //Console.WriteLine(tarefa1.Result);

            //Task com retorno
            Task<int> tarefa1 = Task.Factory.StartNew(() =>
            {
                return new Random().Next(100);
            });

            //Aqui aproveitamos o retorno da tarefa anterior
            //num representa o retorno da tarefa 1
            Task<int> tarefa2 = tarefa1.ContinueWith((num) =>
            {
                return num.Result * 2;
            });

            //Aqui aproveitamos o retorno da task 2
            //Não é obroigatorio pegar o retorno, ela so fala que vamos iniciar uma nova tarefa quando a tarefa 2 for concluida
            Task<string> tarefa3 = tarefa2.ContinueWith((result) => { return result.Result.ToString(); });

            #endregion

            Console.WriteLine(tarefa3.Result);

            Console.ReadKey();  
            
        }

        static int Dobro(int num)
        {
            return num * 2;
        }

        private static void Tarefa()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Tarefa do Task");
            }
        }
    }
}
