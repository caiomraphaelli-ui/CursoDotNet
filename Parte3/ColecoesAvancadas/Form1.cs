using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColecoesAvancadas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            //Listas genéricas sao iguais as listas normais
            //Elas admitem itens repetidos
            //Mas podemos definir até mesmo do tipo de classes criadas

            List<string> nomes = new List<string>();

            nomes.Add("Caio");
            //Podemos usar o addrange para adicionar uma coleção de itens

            //Verificacao e tamanho
            nomes.Contains("Caio"); //Retorna true ou false se o item foi encontrado
            nomes.Count(); //Retorna o numero de itens da lista

            lista.Items.Add(nomes.Count());

            //Remocao
            nomes.Remove("Caio"); //Retorna true ou false se o item foi encontrado e removido
            nomes.RemoveAt(0); //Remove o item do indice especificado
            nomes.Clear(); //Limpa a lista inteira

            //Ordenacao
            nomes.Sort(); //Ordena a lista em ordem alfabetica

        }

        private void btnHashSet_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            //HashSet é uma coleção que não admite itens repetidos
            //Também temos métodos parecidos com a List
            HashSet<string> set = new HashSet<string>()
            {
                "Rita",
                "Aviao",
                "Zap"
            };

            set.Add("Caio");
            set.ElementAt(0); //Mostra o elemento no índice 0

            foreach (string s in set)
            {
                lista.Items.Add(s);
            }

            //Temos também o SortedSet, que é um conjunto ordenado, mas ele é mais lento que o HashSet

        }

        private void btnDictionary_Click(object sender, EventArgs e)
        {
            //Dicionarios são coleções de chave e valor, onde cada chave é única
            //A chave é usada para acessar o valor correspondente
            //Podemos usar qualquer tipo de dado para chave e valor, inclusive classes criadas por nós
            //Não pode repetir chaves, mas os valores podem ser repetidos

            //Existe o SortDictionary, que é um dicionário ordenado pela chave, mas ele é mais lento que o Dictionary


            Dictionary<string, int> alunos = new Dictionary<string, int>()
            {
                { "Rita", 10 },
                {"Aviao", 9},
                {"Zap", 8 }
            };

            MessageBox.Show(alunos.Count().ToString()); //Mostra o numero de itens do dicionário
            MessageBox.Show(alunos["Rita"].ToString()); //Mostra o valor associado à chave "Rita"

            KeyValuePair<string, int> par = alunos.First(); //Mostra o primeiro par chave-valor do dicionário

            MessageBox.Show(par.Value.ToString()); //Mostra o valor do par chave-valor armazenado na variável par

            alunos.Add("Caio", 10); //Adiciona um par chave-valor ao dicionário
            alunos.Remove("Rita"); //Remove o par chave-valor com a chave especificada

        }

        private void btnSortedList_Click(object sender, EventArgs e)
        {
            //SortedList é uma coleção de chave e valor, onde cada chave é única e os itens são ordenados pela chave
            //Também tem índice associados as chaves, como um List
            SortedList<int, string> carros = new SortedList<int, string>()
            {
                {27, "Ferrari"  },
                {3, "Lamborghini" },
                {15, "Porsche" }
            };

            //Metodos parecidos com o Dictionary

            carros.Add(1, "Bugatti"); //Adiciona um par chave-valor à SortedList
            carros.Reverse(); //Inverte a ordem dos itens na SortedList

            foreach (KeyValuePair<int, string> par in carros)
            {
                lista.Items.Add(par.Key + " - " + par.Value); //Mostra a chave e o valor de cada par chave-valor na SortedList
            }

            //A diferenca entre o SortedList e o SortDictionary é que o SortedList é mais rápido para acessar os itens,
            //mas mais lento para adicionar ou remover itens, enquanto o SortDictionary é mais lento para acessar os itens,
            //mas mais rápido para adicionar ou remover itens

        }

        private void btnQueue_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            //Queue é uma coleção do tipo fila, onde os itens são adicionados no final da fila e removidos do início da fila (FIFO - First In First Out)

            Queue<string> fila = new Queue<string>();
            fila.Enqueue("Caio"); //Adiciona um item ao final da fila
            fila.Enqueue("Rita");
            fila.Enqueue("Aviao");

            MessageBox.Show(fila.Count().ToString()); //Mostra o número de itens na fila

            foreach (string s in fila)
            {
                lista.Items.Add(s); //Mostra os itens da fila
            }

            fila.Peek(); //Mostra o item no início da fila sem removê-lo
            MessageBox.Show(fila.Dequeue()); //Remove o item no início da fila e o retorna
            fila.Clear(); //Limpa a fila inteira

            //Existe também a Stack, que é uma coleção do tipo pilha, onde os itens são adicionados no topo da pilha e removidos do topo da pilha (LIFO - Last In First Out)

        }
    }
}
