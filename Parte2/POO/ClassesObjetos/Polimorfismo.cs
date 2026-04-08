using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos
{
    public abstract class Forma
    {
        //Polimorfismo permite que objetos de diferentes classes sejam tratados como objetos de uma classe comum, geralmente através de uma hierarquia de classes e do uso de métodos virtuais ou abstratos
        //Um objeto criado pode conter comportamentos diferentes conforme ele foi instanciado

        public int x {  get; private set; }
        public int y { get; private set; }
        public int Altura { get; private set; }
        public int Largura { get; private set; }   
        public int Raio { get; private set; }

        public virtual void Desenhar() //Aqui estamos usando a palavra-chave virtual para indicar que esse método pode ser sobrescrito pelas classes derivadas
        {
            Console.WriteLine("Desenhando uma forma genérica");
        }

        public virtual void Area()
        {
            //Sem implementação inicial
        }


    }

    public class Circulo : Forma
    {
        public override void Desenhar() 
        {
            base.Desenhar(); //Aqui estamos chamando o método Desenhar da classe base Forma, ou seja, estamos usando a implementação original do método antes de fornecer a nova implementação para o círculo
            Console.WriteLine("Desenhando um círculo");
        }

        public override void Area() //Método sobrescrito
        {
            double area = Math.PI * Math.Pow(Raio, 2);
            Console.WriteLine("Area do circulo" + area);
        }
    }

    #region interface 
    //Interface é um contrato que define um conjunto de métodos que uma classe deve implementar, mas não fornece a implementação desses métodos, ou seja, as classes que implementam a interface devem fornecer a implementação para os métodos definidos na interface

    interface IForma //Aqui estamos definindo uma interface chamada IForma
    {
        //Por padrão todos os membros de uma interface são públicos e abstratos

        string Usuario { get; set; }

        void Desenhar(); 
        void Area();
        void Perimetro();
    }

    #endregion


}
