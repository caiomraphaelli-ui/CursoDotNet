using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos
{
    partial class Pessoa //Essa classe representa outra classe dentro do mesmo namespace
    //colocamos a palavra partial para indicar que essa classe é uma parte de uma classe maior que pode estar dividida em vários arquivos
    //Se criarmos outra classe Pessoa em outro arquivo, ela será considerada parte da mesma classe Pessoa, desde que ambas sejam declaradas como partial 
    //Classe parcial é útil para organizar o código em arquivos separados, especialmente quando a classe tem muitos membros ou funcionalidades distintas
    {
        #region Atributos
        //Atributo é um campo de dados que define o estado do objeto
        //Podemos criar quantos atributos quisermos dentro de uma classe

        public string nome; //Atributo Nome do tipo string
        public string sobrenome; //Atributo Sobrenome do tipo string
        public int anoNascimento; //Atributo AnoNascimento do tipo int
        public int idade;

        private string cpf; //Atributo CPF do tipo string, declarado como privado, ou seja, só pode ser acessado dentro da classe Pessoa
        private string rg {  get; set; }//Podemos ter atributos privados com propriedades autoimplementadas, onde o get e set são gerados automaticamente pelo compilador, mas ainda assim o acesso ao atributo é controlado pela propriedade
        #endregion

        #region Métodos Construtores

        //Método construtor é um método especial que é chamado quando um objeto é criado
        //Sempre precisa ser do mesmo nome da classe
        //Não possui tipo de retorno
        //Esse método inicializa os atributos do objeto no momento da instanciação de um objeto

        public Pessoa() //Construtor padrão sem parâmetros
        {
            nome = "Nome padrão";
            sobrenome = "Sobrenome padrão";
            anoNascimento = 2000;
        }

        public Pessoa(string nome, string sobrenome, int anoNascimento) //Construtor com parâmetros
        {
            this.nome = nome; //Usando o termo this para diferenciar o atributo do parâmetro
            this.sobrenome = sobrenome;
            this.anoNascimento = anoNascimento;
            this.idade = CalcularIdade(anoNascimento); //Chamando o método CalcularIdade para inicializar o atributo idade
        }

        #endregion

        #region Métodos
        //Método é uma função que define o comportamento do objeto
        //Modificador publico indica que o método pode ser acessado fora da classe

        public void Apresentar() //Método Apresentar que não retorna nenhum valor (void)
        {
            Console.WriteLine("Olá, meu nome é {0} {1} e nasci em {2}", nome, sobrenome, anoNascimento);
        }

        //Método que possui parâmetros de entrada
        //O tipo de paraâmetro deve ser declarado antes do nome do parâmetro
        public void Idade(int anoNas, int anoAtual, string nome) 
        {
            int idade = anoAtual - anoNas;
            Console.WriteLine("A idade de {1} é: {0} anos", idade, nome);
        }

        //Passagem de parâmetro por valor
        //Nesse caso , o valor do parâmetro não é alterado fora do método
        public void AumentarValor(int valor)
        {
            valor = valor + 10;
            Console.WriteLine("Valor dentro do método: {0}", valor);
        }

        //Passagem de parâmetro por referência
        //Nesse caso , o valor do parâmetro é alterado fora do método
        //Essa alteração persiste após a execução do método
        public void AumentarValorRef(ref int valor) //Precisa ter ref no paraâmetro
        {
            valor = valor + 10;
            Console.WriteLine("Valor dentro do método (ref): {0}", valor);
        }

        //Método de retorno de valor
        //Retorno e parametros sao idependentes um do outro
        public int CalcularIdade(int anoNas, int anoAtual) //O tipo de retorno é declarado antes do nome do método
        {
            return anoAtual - anoNas; //Retorna a idade calculada
            //Retorno precisa ser do mesmo tipo declarado no método
        }

        //Sobrecarga de métodos
        //Nesse caso temos dois métodos com o mesmo nome, mas com assinaturas diferentes
        public int CalcularIdade(int anoNas) //Sobrecarga do método CalcularIdade
        {
            int anoAtual = DateTime.Now.Year; //Obtém o ano atual do sistema
            return anoAtual - anoNas; //Retorna a idade calculada
        }
        #endregion

        #region Termo this

        //Tedrmo this faz referencia a instancia atual da classe

        string senha = "12345"; //Atributo senha

        public bool Login(string senha)
        {
            return this.senha == senha; //Usando o termo this para diferenciar o atributo do parâmetro
        }

        #endregion

        #region Tipo Delegate

        //Serve para referenciar métodos que tenham a mesma assinatura
        //Precisa ser instanciado antes da declaração da classe e metodo main

        public void Somar (int a, int b)
        {
            Console.WriteLine("Soma: {0}", a + b);
        }
        public void Subtrair(int a, int b)
        {
            Console.WriteLine("Subtração: {0}", a - b);
        }
        public void Multiplicar(int a, int b)
        {
            Console.WriteLine("Multiplicação: {0}", a * b);
        }

        public void Divide(int a, int b) {
            if (b != 0)
            {
                Console.WriteLine("Divisão: {0}", a / b);
            }
            else
            {
                Console.WriteLine("Divisão por zero não é permitida.");
            }
        }

        #endregion

        #region Membros estáticos

        //Membros estáticos pertencem a classe e não ao objeto
        //Podemos ter métodos que são estáticos dentro de uma classe não estática
        //Servem para agrupar funcionalidades que não dependem do estado do objeto
        //Podem ser acessados sem a necessidade de criar um objeto da classe

        public static int maioridade = 18; //Atributo estático

        #endregion

        #region Propriedades de uma Classe

        //Definicao de uma propriedade para acessar atributos privados
        //Por padrao a gente nao acessa os atributos diretamente, mas sim por meio de propriedades, que sao metodos especiais que permitem controlar o acesso aos atributos
        public string Cpf //Geralmente o nome da propriedade é o mesmo do atributo, mas com a primeira letra maiúscula
        {
            //Podemos ter regras para os gets e sets, como validações ou formatações

            get { return cpf; } //Acessa o valor do atributo cpf
            set 
            { 
                if (value.Length == 11) //Aqui podemos colocar uma validação para garantir que o cpf tenha 11 caracteres
                {
                    cpf = value;
                } 
                else 
                {
                    Console.WriteLine("CPF inválido. O CPF deve conter 11 caracteres.");
                }
            } 
        }

        #endregion
    }
}