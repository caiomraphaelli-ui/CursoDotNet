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
            //Listas genéricas sao iguais as listas normais
            //Mas podemos definir até mesmo do tipo de classes criadas

            List<string> nomes = new List<string>();

            nomes.Add("Caio");
            //Podemos usar o addrange para adicionar uma coleção de itens

            lista.Items.Add(nomes[0]);
        }
    }
}
