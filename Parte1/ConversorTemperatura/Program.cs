using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorTemperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double c, f, k;

            Console.WriteLine("-- Conversor de Temperaturas-- \n");
            Console.Write("Insira a Temperatura em Celcius: ");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            f = (c * 9 / 5) + 32;
            k = c + 273.15;

            Console.WriteLine("Graus Fahrenheit = " + f);
            Console.WriteLine("Graus Kelvin = " + k);
            Console.ReadKey();
        }
    }
}
