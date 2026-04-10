using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadForm
{
    public partial class Form1 : Form
    {
        //delegate para atualizar o controle na thread principal
        private delegate void AtualizarControle(Control controle, string propriedade, object valor);

        Thread t;

        public Form1()
        {
            InitializeComponent();
            t = new Thread(new ThreadStart(Tarefa));
            t.IsBackground = true;
        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Olá, sou a thread principal!");
        }

        private void btnContador_Click(object sender, EventArgs e)
        {
            if (!t.IsAlive)
            {
                t.Start();
            }
        }

        private void DefinirValorPropriedade(Control controle, string propriedade, object valor)
        {
            //verifica se o controle precisa ser atualizado na thread principal
            //Necessario para evitar erros de cross-thread operation not valid
            if (controle.InvokeRequired)
            {
                //Apenas se precisa do Invoke

                AtualizarControle d = new AtualizarControle(DefinirValorPropriedade);
                controle.Invoke(d, new object[] { controle, propriedade, valor });// os parametros do delegate
            }
            else
            {
                Type type = controle.GetType();
                PropertyInfo[] properties = type.GetProperties();

                foreach (PropertyInfo p in properties)
                { 
                    if (p.Name.ToUpper() == propriedade.ToUpper())
                    {
                        p.SetValue(controle, valor, null);
                    }
                }
            }
        }

        private void Tarefa()
        {
            while (true)
            {
                //lblResultado.Text = DateTime.Now.ToString("HH:mm:ss");

                //DefinirValorPropriedade(lblResultado, "Text", DateTime.Now.Second.ToString());

                //Assim fica mais simples, sem a necessidade de criar um delegate e verificar o InvokeRequired
                //A expressao lambda é convertida em um delegate Action, que é o tipo de delegate esperado pelo Invoke
                lblResultado.Invoke(new Action(() => lblResultado.Text = DateTime.Now.ToString("HH:mm:ss")));


                Thread.Sleep(1000);
            }
        }

    }
}
