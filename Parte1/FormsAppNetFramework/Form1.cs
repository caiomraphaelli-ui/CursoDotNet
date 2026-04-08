//Bibliotecas externas utiliza "using"
//Linha de instrução termina com ';'
//Dot Net as bibliotecas são implícitas (mas podem ser declaradas) - Net framework precisa ser explicita

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Bloco de instrução delimitado
//Todo projeto fica basicamente dentro do 'namespace'
//C# é case Sensitive - diferencia minuscula de maiuscula


namespace FormsAppNetFramework
{
    public partial class Form1 : Form //Classe Form utilizada para biblitoeca grafica
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

