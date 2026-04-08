/* Bloco de comentário */

#region Nome da região
//cria um bloco para mostrar para IDE algo para contrair
//IDE cria blocos assim com a limitação do bloco {}
//Compilador também ignora essas regiões
#endregion

namespace ConsoleAppDotNet
{
    internal class Program
    {
        struct Pessoa
        {
            //nao pode ser inicializado
            public string nome; //precisa ser public para poder acessar essa estrutura 
            public int idade;
            public double altura;
        }

        enum Notas
        {
            Minimo = 10, 
            Media = 20, 
            Maxima = 30
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            #region Variaveis Integrais
            //Variaveis intgrais não suportam casas decimais
            //variaveis assinado
            sbyte num1 = 10; // 8 bits
            short num2 = 10; // 16 bits
            int num3 = 10; // 32 bits
            long num4 = 10l; // 64 bits

            //variaveis sem sinal
            byte num5 = 10;
            ushort num6 = 10;
            uint num7 = 10;
            ulong num8 = 10;

            int numero;
            numero = 100; //Variavel referenciada
            numero = num3; //Recebe cópia do valor

            //isso tudo difere da utilização de memória 
            #endregion

            #region Decimais - Reais
            float real1 = 100.76f; // 4 bytes - 32 bits ( precisamos colocar o f explicitamente, caso tenha casas decimais)
            
            /* ele usa ponto flutuante binário (IEEE 754), que não consegue armazenar muitos números decimais de forma exata.

            Explicação técnica resumida:
            O float é armazenado em 32 bits, com parte para o sinal, expoente e mantissa.
            Como o computador trabalha em base 2, números como 100.76 (base 10) não têm uma representação exata em binário.
            Então, o valor armazenado é uma aproximação muito próxima 
            
            Usar decimal para precisão máxima 
            */


            float real2 = 100.6546f; // Diferente de cima, que ali teve mudança implícita
            double real3 = 500.75; // Ela não precisa de uma letra explícita como o float - 64 bits - 8 bytes
            decimal real4 = 44444.6666m; // Precisa da letra auxiliar 'm ou M' - 128 bits

            double aux;
            aux = 500;
            aux = real1; // Pode fazer a cópia do valor ( mas precisa estar no range dos bits )

            #endregion

            #region Caracteres
            
            //Char pode ter 16 bits

            char literal = 'C'; //Caracter que representa aquele UTF-16 ( Grafica do caracter Grifo )
            char letra2 = '8';
            char letra3 = '\u002B'; // Nesse caso, estamos colocando o codigo em Hexa que representa o Grifo '+'. Pode ser em decimal, ou bainario tambem
            char escape = '\n'; //caracteres especiais ou de escape ( \n quebra de linha, \u para o codigo do grifo, \0 caracter nulo, \\ para imprimir a barra invertida )
            char barra = '\\';
            
            #endregion

            #region Bool

            bool verifica = false; // false ou true
            verifica = true; // Mais usados em expressoes booleanas 
            
            #endregion

            #region Strings ( Cadeira de Caracteres )
            string texto = "Salve gurizada medonha @#!%"; //String armezena uma sequencia de caracter. Pode ser inicializada com 'null'
            string msg = null; // String é uma variável do tipo referência
            msg = texto; 
            string quebra = "Caio \n Raphaelli"; // Podemos usar caracteres de escape também no meio da string
            string barra_n = "Caio \\n"; // Nesse caso imprime o \n ou podemos iniciar a string com @ para ignorar os caracteres de escape
            string arroab = @"tira os escapes \n";

            //Strig é não primitivo, então temos métodos e atributos
            #endregion

            #region Tipo Implícito Var
            
            var valor = 140;
            
            //var asssume um valor de qualquer tipo
            //a partir do momento que definimos seu valor, nao podemos mais alterar o tipo de dado dessa vasriavel
            //exemplo do = 140 ela sempre vai ter do tipo inteiro
            
            valor = 20; //isso pode porque 20 e um interio
            valor = "Caio"; //vai dar erro pq nao podemos mudar
            
            #endregion

            #region Tipo Object
            //Tipo Object podemos atribuir qualquer tipo de dado
            //essa variavel e a base para outros tipos.
            //ela pode ser mudada em qualquer momento sem erro
            //todas essas variaveis sao tratadas como tipo objetos
            //por exemplo, tipos definidos nao cosneguimos usar ( apenas fazendo uma conversao )
            object obj = "Caio";
            obj = 100.20;
            #endregion

            #region Constantes
            const double pi = 100;
            //constante recebe o valor atribuiudo na sua declaracao e nao pode ser alterado ao longo da execucao
            #endregion

            #region Enumeração
            //precisa ser declarada na raiz da classe
            //define os valores automaticamente 0,1 e 2 caso a gente nao ajuste
            //bom para usos de casos de erro
            
            Notas notas_alunos = Notas.Media;
            #endregion

            #region Estrutura
            //pode encapsular dados e funcionaldiades relacionadas
            //estruturas de dados para armazenar valores de um tipo
            //ao inves de criar varias variaveis, podemos criar uma estrutura que engloba essas variaveis
            //tambem e delcarada na raiz

            Pessoa p1 = new Pessoa(); //Inicialização de uma estrutura

            p1.nome = "Caio";
            p1.altura = 1.88;
            p1.idade = 27;

            Pessoa p2 = new Pessoa() //Maneira diferente de instanciar os atributos
            {
                altura = 10,
                nome = "Joao"
            };

            #endregion


            Console.WriteLine(numero); //Referenciada variavel
            Console.WriteLine(real2);
            Console.WriteLine(letra3);
            Console.WriteLine(quebra);
            Console.WriteLine(p1.idade); //print da idade da p1 do tipo pessoa
            Console.ReadKey();


            /* Conversões de dados */

            #region Conversão Implícita Variável

            //Compilador faz a conversao de um tipo a aoutro desde que suporte o tipo
            //Para variaveis reais também funciona
            //Tambem pode para receber numeros inteiros em uma variavel de reais ( Float que recebe int )
            //Funciona para caracteres ( ja que pegamos o valor que representa o grifo )

            byte bit1 = 100; //8 bits
            ushort ush; //16 bits
            
            int carac = 'C'; //O Codigo numero que representa esse grifo é suportado pelo int

            ush = bit1;  // Aqui ele pode receber porque ele cabe ( Nao a perda de dados )


            #endregion

            #region Conversão Explícita

            //A variavel que recebve o valor nao suporta ela, podendo perder dados - Nesse caso precisa ser explicito
            //Se houver perda de dados é por nossa conta e risco- Exemplo 500 nao cabe no byte ( pq é 8 bits - max 255 )

            short teste1 = 100;
            byte teste2 = (byte)teste1; // Nesse caso convertemos explicitamente - Nao havera perda de dados pq o numero 100 é compreendido dentro do byte 

            float doismil = 2500f; //Se tiver casas decimais vai perder dados porque o int nao suporta
            int test3 = (int)doismil;

            int test4 = (int)2300.45f; //Aqui vai ter perdas de dados das casas decimais - Aqui também temos a forma literal ao inves de variavel

            char char1 = (char)97; // Nesse caso a gente converte para a letra correspondente ao valor numero 97 na tabela ASCII

            #endregion

            #region Método Parse
            
            //Transforma uma string em um numero correspondente
            //Se tiveer caracter junto vai dar erro em tempo de execucao da aplicao ex: "1985Caio"
            
            string txtnumero = "1985"; //ela contem um valor que pode ser representado por um numero inteiro
            int numerotxt = int.Parse(txtnumero); // aqui ele converte e podemos usar essa variavel como int mesmo 

            byte txtbyte = byte.Parse("4444"); //Com todos os outros tipos de variaveis numericas funcoiona tambem
            double numteste3 = double.Parse("12445,98"); //Nesse caso precisamos colocar a vírgula, se fosse ponto iria dar erro


            #endregion

            #region Classe Convert

            //A classe pode fazer a conversao para qualuer tipo de dado
            //Vários métodos de conversao nessa classe
            //Existe meios que nao funcionam

            string textoCovert = Convert.ToString(658);
            double duble = Convert.ToDouble(false); //Vai colocar a representacao numerica daquele booleano
            int charzin = Convert.ToInt32('C');

            #endregion

        }
    }
}
