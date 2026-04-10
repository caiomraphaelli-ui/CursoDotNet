using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Criamos uma nova thread, passando o método Tarefa como o ponto de entrada para a execução da thread.
            Thread thread = new Thread(new ThreadStart(Tarefa));
            thread.IsBackground = true; //Define a thread como uma thread em segundo plano, o que significa que ela não impedirá que o aplicativo seja encerrado se a thread principal terminar sua execução.

            thread.Start();
            //thread.Join(); //Aguarda a conclusão da thread Tarefa antes de continuar a execução do código na thread principal. Isso garante que a thread Tarefa tenha tempo para concluir sua execução antes que o programa termine.

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Principal");
                Thread.Sleep(500); //Adiciona um atraso de 100 milissegundos entre as iterações do loop, para simular um trabalho mais pesado e permitir que a thread Tarefa tenha tempo para executar.
            }

            Console.ReadKey();
        }

        //Thread é uma unidade de execução dentro de um processo.
        //Ele permite que um programa execute várias tarefas simultaneamente, melhorando a eficiência e a responsividade do aplicativo.

        static void Tarefa()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Tarefa Executada");
                Thread.Sleep(1000);
            }
        }

    }
}
