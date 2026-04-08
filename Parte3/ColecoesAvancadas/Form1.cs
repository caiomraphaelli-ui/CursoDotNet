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
        }

        private void btnDictionary_Click(object sender, EventArgs e)
        {
            //Dicionarios são coleções de chave e valor, onde cada chave é única
            //A chave é usada para acessar o valor correspondente
            //Podemos usar qualquer tipo de dado para chave e valor, inclusive classes criadas por nós
            //Não pode repetir chaves, mas os valores podem ser repetidos
            Dictionary<string, int> alunos = new Dictionary<string, int>()
            {
                { "Rita", 10 },
                {"Aviao", 9},
                {"Zap", 8 }
            };

            alunos.Add("Caio", 10); //Adiciona um par chave-valor ao dicionário

        }
    }
}
