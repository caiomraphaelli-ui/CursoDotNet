using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntradaSaida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Entrrada e Saida
            
            Console.WriteLine("Cao"); //Tarefa desse método: Saída de dados 

            //Console.Write("Mensagem"); //Escreve o dado sem quebrar a linha

            int codigo = Console.Read(); //Ele lê o caracter e espera Enter para pular a proxima instrucao - Retorna um código ASCII do caracter digitado
            Console.WriteLine(codigo);

            string texto = Console.ReadLine(); //Lê a linha de caracteres escritas e retorna uma String ( Também espera o Enter )
            Console.WriteLine(texto);

            Console.ReadKey(); //Método que espera uma tecla para fechar
            
            #endregion



      
            string nome1, nome2, nome3, nome4;

            Console.Write("Digite o nome 1: ");
            nome1 = Console.ReadLine();

            Console.Write("Digite o nome 2: ");
            nome2 = Console.ReadLine();

            Console.Write("Digite o nome 3: ");
            nome3 = Console.ReadLine();

            Console.Write("Digite o nome 4: ");
            nome4 = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine(nome3 + nome4);
            Console.ReadKey();
            
        }
    }
}
