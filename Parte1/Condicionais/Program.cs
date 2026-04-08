using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Condicionais

            int valor = 10;

            if (valor==5) //Se o bloco for verdadeiro tudo é executado
            {
                Console.WriteLine("Bloco IF executado");
                //Qualquer comando pode ser executado aqui
            }
            else //Bloco alternativo caso o if seja falso
            {
                Console.WriteLine("Bloco ELSE executado"); 
            }
            #endregion

            #region Encadeadas
            //Vai ter mais de uma alternativa de condição dentro do if
            //Nao pode existir conflito entre as condições
            //Exemplo: if(valor > 5) e else if (valor > 3) - Conflito
            //O primeito bloco que for verdadeiro será executado e os demais serão ignorados

            //Dentro do bloco podemos usar qualquer operador de comparação: >, <, >=, <=, ==, !=
            //Ou operador lógico: &&, ||

            if (valor > 5)
            {

            }
            else if (valor > 3 )
            {
            
            }
            else if (valor == 10)
            {
            
            }
            else
            {
            
            }


            #endregion

            #region Aninhadas
            //Estruturas condicionais dentro de outras estruturas condicionais
            //Podemos ter quantos níveis quisermos

            int num = 10;

            if (num > 5)
            {
                Console.Write("O numero é mneior que 5");

                if(num % 2 == 0)
                {
                    Console.WriteLine("E é par");
                }
                else
                {
                    Console.WriteLine("E é impar");
                }

            }

            #endregion

            #region Operador Ternário
            //Estrutura condicional simplificada que retorna um valor baseado em uma condição
            //Tudo em uma única linha
            //Sintaxe: condição ? valor_se_verdadeiro : valor_se_falso;

            int numero = 10;
            string msg = "";

            if (numero > 5)
            {
                msg = "Maior que 5";
            }
            else
            {
                msg = "Menor ou igual a 5";
            }

            //Usando o operador ternário
            //Pode ser usado em atribuição direta, em prints , etc. Porque retorna um valor

            msg = (numero > 5) ? "Maior que 5" : "Menor ou igual a 5"; //Atribuição direta

            #endregion

            #region Cálculo IMC

            Console.Write("Informe seu peso em Kg: ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Informe a altura em metros: ");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);

            if (imc < 20)
            {
                Console.WriteLine("\nIMC = " + imc + " -> Abaixo do peso");
            }
            else if ((imc >= 20) && (imc < 25))
            {
                Console.WriteLine("\nIMC = " + imc + " -> Peso normal");
            }
            else if ((imc >= 25) && (imc < 30))
            {
                Console.WriteLine("\nIMC = " + imc + " -> Acima do peso");
            }
            else
            {
                Console.WriteLine("\nIMC = " + imc + " -> Obeso");
            }

            #endregion


        }
    }
}

