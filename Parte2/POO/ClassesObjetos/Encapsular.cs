using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos
{
    //Encapsulamento é um dos pilares da programação orientada a objetos que consiste em ocultar os detalhes internos de uma classe e expor apenas o necessário para o uso externo
    //É uma forma de proteger os dados e garantir que eles sejam acessados e modificados de maneira controlada, evitando que o estado do objeto seja corrompido por acessos indevidos
    abstract class Conta
    {
        private string cliente;
        private double saldo;
        private double taxa = 10;

        public abstract void Sacar(double valor); //Membro abstrato

        public virtual void Print() //Método com implemntação
        {
            Console.WriteLine("Voce sacou");
        }

        public string Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; } //Aqui pode ser private para ser acesso apenas dentro da classe
        }
    }

    #region Herança
    //Herança permite criar uma nova classe a partir de uma classe existente, herdando seus atributos e métodos, e podendo adicionar novos ou modificar os existentes
    //Por exemplo podemos criar uma classe ContaPoupanca que herda da classe Conta, e adicionar um novo atributo taxaJuros e um método CalcularRendimento
    
    internal class ContaPoupanca : Conta //Aqui estamos usando a sintaxe de herança
    {
        private double taxaJuros;
        public void CalcularRendimento()
        {
            double rendimento = Saldo * taxaJuros; //Aqui estamos usando o saldo da classe Conta para calcular o rendimento da conta poupança
            Console.WriteLine("O rendimento da conta poupança é: {0}", rendimento);
        }

        public override void Sacar(double valor) //Aqui estamos usando a palavra-chave override para indicar que estamos sobrescrevendo o método Sacar da classe base Conta, ou seja, estamos fornecendo uma nova implementação para esse método na classe ContaPoupanca
        {
            Saldo = Saldo - valor; //
        }
    }
    #endregion

    #region Classe Abstrata 
    //Classe abstrata servem como um modelo para outras classes, ou seja, não podem ser instanciadas diretamente, mas podem conter métodos abstratos que devem ser implementados pelas classes derivadas
    //Por exemplo podemos criar uma classe abstrata FormaGeometrica com um método abstrato CalcularArea, e depois criar classes derivadas como Circulo e Retangulo que implementam esse método
    //Se o membro for abstrato ele nao tem implementacao e todos que herdarem dessa classe precisam implementar esse metodo
    #endregion

    #region Classe Selada
    //Classe selada é uma classe que não pode ser herdada por outras classes, ou seja, é uma classe final que não pode ser estendida
    //Mas ainda sim ela pode herdar de outras classes, ou seja, ela pode ser uma classe derivada, mas não pode ser uma classe base para outras classes
     sealed class ContaCorrente : Conta //Aqui estamos usando a palavra-chave sealed para indicar que essa classe é selada e não pode ser herdada por outras classes
    {
        public override void Sacar(double valor)
        {
            Saldo = Saldo - valor; //Aqui estamos usando o saldo da classe Conta para realizar a operação de saque da conta corrente
        }
    }
    #endregion

    #region Membros Selead
    //É parecido com o abstract porem ele existe uma implementaçao 
    //Podem ser sobrescritos e tambem reutilizados
    //Usa-se o virtual na declaração do método
    //O método selead sobrescrito pode ser chamado usando a palavra-chave base, ou seja, ele pode acessar a implementação do método na classe base mesmo depois de ter sido sobrescrito
     class ContaEspecial : Conta
    {
        public override void Sacar(double valor)
        {
            Saldo = Saldo - valor; //Aqui estamos usando o saldo da classe Conta para realizar a operação de saque da conta especial
        }
        public sealed override void Print() //Aqui estamos usando a palavra-chave sealed para indicar que esse método é selead e não pode ser sobrescrito por classes derivadas, ou seja, ele é uma implementação final desse método e não pode ser modificada por outras classes que herdem de ContaEspecial
        {
            Console.WriteLine("Voce sacou da conta especial");
        }
    }
    #endregion

    #region Modificadores de Acesso
    //Public : O membro é acessível de qualquer lugar, ou seja, pode ser acessado por outras classes e objetos
    //Private : O membro é acessível apenas dentro da própria classe, ou seja, não pode ser acessado por outras classes ou objetos
    //Protected : O membro é acessível dentro da própria classe e por classes derivadas, mas não por objetos instanciados da classe
    //Internal : O membro é acessível apenas dentro do mesmo assembly, ou seja, pode ser acessado por outras classes e objetos dentro do mesmo projeto, mas não por classes e objetos de outros projetos
    #endregion
}


