using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos //Namespace que agrupa nossas classes
{
    internal class Program //Essa classe representa nosso programa principal
    {

        delegate void Operacao(int num1, int num2); //Aqui temos um delegate com a mesma assinatura

        static void Main(string[] args) //Cada classe possui um método Main
        {
            //Podemos criar quantos objetos quisermos a partir de uma classe
            //Normalmente não criamos objetos da classe no mesmo arquivo onde a classe é definida

            MinhaClasse mClasse = new MinhaClasse(); //Criando um objeto da classe MinhaClasse
            MinhaClasse m2 = null; //Criando uma variável do tipo MinhaClasse que não referencia nenhum objeto

            Pessoa p1 = new Pessoa(); //Criando um objeto da classe Pessoa
            
            p1.nome = "João"; //Acessando o campo nome do objeto p1
            p1.sobrenome = "Silva";
            p1.anoNascimento = 1990;

            p1.Cpf = "123456789"; //Usando o método set do campo Cpf para atribuir um valor

            //Retornno do método CalcularIdade ja atribuído a variável idadeJoao
            int idadeJoao = p1.CalcularIdade(p1.anoNascimento, 2026); 

            //Nesse caso estamos criando e inicializando um objeto da classe Pessoa
            Pessoa p2 = new Pessoa()
            {
                nome = "Maria",
                sobrenome = "Oliveira",
                anoNascimento = 1985
            };

            p1.Apresentar(); //Chamando o método Apresentar do objeto p1

            //Aqui precisamos passar os parâmetros necessários para o método Idade
            p1.Idade(p1.anoNascimento, 2026, p1.nome); //Chamando o método Idade do objeto p1
            p1.AumentarValorRef(ref p1.anoNascimento); //Aqui usamos ref para passar o parâmetro por referência
            p2.idade = p2.CalcularIdade(p2.anoNascimento, 2026); //Chamando o método CalcularIdade do objeto p2

            if (p1.Login("24124"))
            {
                Console.WriteLine("Seja bem vindo !");
            }

            //Utilização do Delegate

            Operacao conta = null;
            conta += p1.Subtrair;   //Essa variavel basicamente funciona como referencia de método
            conta(10, 4); //Os parametros do método Subtrair


            Console.WriteLine("Pessoa 1: {0} {1}, Nascido em {2}", p1.nome, p1.sobrenome, p1.anoNascimento);
            Console.WriteLine("Pessoa 2: {0} {1}, Nascida em {2}", p2.nome, p2.sobrenome, p2.anoNascimento);


            Matematica.taxa = 10; //Não instanciamos um objeto de classe estatica
            int valor1 = Matematica.Adicionar(100); //Usando método da classe estática

            ContaPoupanca contaPoupanca = new ContaPoupanca(); //Criando um objeto da classe ContaPoupanca
            contaPoupanca.Sacar(100); //Aqui estamos usando o método Sacar da classe Conta, que é a classe base de ContaPoupanca
            contaPoupanca.Print(); //Print é um método da classe Conta que foi herdado por ContaPoupanca

            Forma forma = new Circulo(); //Criando um objeto do tipo Forma, mas na verdade é um objeto do tipo Circulo, isso é possível por causa do polimorfismo
            //Mas se a classe Circulo tivesse um método específico que não existe na classe Forma, não poderíamos acessar esse método através da variável forma, pois ela é do tipo Forma e não do tipo Circulo
        }




    }


    //Definição de uma nova classe dentro do namespace ClassesObjetos
    //Sua definição começa com a palavra-chave class seguida do nome da classe

    class MinhaClasse //Não pode ser o mesmo nome de classe que existe
    {
        //Tudo aqui dentro define o que a classe é e o que ela pode fazer

    }

}
