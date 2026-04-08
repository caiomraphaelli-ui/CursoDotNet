using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Operadores Matemáticos

            int num1 = 10;
            int num2 = 2;
            int resultado = num1 + num2; //Operador de mais

            Console.WriteLine(Convert.ToString(resultado)); //Aqui foi apenas teste
            Console.WriteLine(num1 * num2);
            Console.WriteLine(num1 - num2);
            Console.WriteLine(num1 / num2);
            Console.WriteLine(num1 % num2); //Retorno do resto da divisao

            #endregion

            #region Prioridade
            
            //A prioridade de precedencia é () -> * ou / -> + ou -
            //Cuidar o tipo de variaveis pois existem casas decimais

            int res = num1 + num2 * num2; //Nesse caso a multiplicacao vem primeiro
            res = (num1 + num2) * num2; //Aqui difere

            #endregion

            #region Incrementos

            //O tipo de incremento influencia no processo de métodos

            int incre1 = 10;
            incre1 = incre1 + 1; //Incremento extenso

            //Pós Incremento - A variável é acrescida depois
            incre1++; 
            incre1--; 

            //Pré Incremento - Primeiro a variavel é acrescida
            ++incre1;
            --incre1;

            incre1 -= 1; //Aqui temos outro tipo de atribuicao
            incre1 += 1;

            Console.WriteLine(++incre1); //Aqui ele é acrescido de 1 e imprime na tela
            Console.WriteLine(incre1++); //Aqui ele é apenas acrescido depois de rodar o Console

            #endregion

            #region Operadores Concatenação

            string nome = "Caio " + "Raphaelli"; // Esse operador pode ser usado com strings para concatenar
            string atr = "Lindo";
            string conca = nome + atr + " " + 1988; // Aqui também concatena e apesar de ter um valor numerico ele é tratado como numnerico

            Console.WriteLine(conca);
            Console.ReadKey();

            #endregion

            #region Operadores Atribuição

            //Atribuições combinadas para todos os operadores

            int atri1 = 10; //Atribuição ' = ' sobrescreve o valor da variavel
            atri1 += 20; // Aqui basicamente ocorre atri1 = atri1 + 20;
            atri1 *= 1;
            atri1 /= atri1;
            atri1 %= 10;

            //Funciona para strings também
            string atri2 = "Caio";
            atri2 += " Artigas";

            #endregion

            #region Operadores Igualdade

            //O retorno sempre é true ou false

            bool result = 100 == 200; //Operador de igualdade - retorno false
            result = 100 == 50 * 2;

            bool resul2 = 200 != 50; //Aqui verifica se é diferente de - retorno de true

            string nom = "Caio";
            result = nom == "Caio"; //Também pode ser utitlizado para comparacao de strings

            #endregion

            #region Operadores Relacionais

            //Assim como a igualdade, os relaiconais também retornam true ou false
            // < Menor, > Maior, <= Menor ou igual, >= Maior ou igual
            //Também funciona com comparaçoes de variaveis

            bool res3 = 10 < 40;
            res3 = 10 > 5;
            res3 = 10 <= 10;


            #endregion

            #region Operadores Lógicos

            // && AND - Ambas verificacoes precisam ser true para retornar true
            // || OR - Se uma verificacao for true ele ja retorna true
            //Geralmente usado em condicionais
            //Ele retorna um booleano a partir de verificacoes de outras logicas

            bool res4 = 10 <= 10;
            bool res5 = 50 * 2 == 100;

            bool final = res4 && res5; //Aqui como os 2 são true, vai retornar um true
            final = res4 && 50 != 50; //Vai dar false, pois ele exige que ambos os lados sejam true
            final = res4 || 10 < 4; //True porque o res4 tem valor true

            #endregion


        }
    }
}
