using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form1 : Form
    {

        List<Pessoa> lista_pessoas;

        public Form1()
        {
            InitializeComponent();

            lista_pessoas = new List<Pessoa>();

            combo_Estado.Items.Add("Viúvo");
            combo_Estado.SelectedIndex = 0;
            radio_Masc.Checked = true;
        }


        //Associamos métodos para cada um dos eventos do Controler
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Cadastro_Click(object sender, EventArgs e)
        {

            int index = -1;

            foreach (Pessoa p in lista_pessoas)
            {
                if (p.Nome == Txt_Nome.Text)
                {
                    index = lista_pessoas.IndexOf(p);
                }
            }

            if (Txt_Nome.Text == "")
            {
                MessageBox.Show("Campo nome é obrigatório");
                Txt_Nome.Focus();
                return;
            }

            // Garantir que todos os dígitos obrigatórios do MaskedTextBox foram preenchidos
            if (!Txt_Fone.MaskCompleted)
            {
                MessageBox.Show("Campo telefone é obrigatório");
                Txt_Fone.Focus();
                return;
            }


            char sexo;

            sexo = radio_Masc.Checked ? 'M' : radio_Fem.Checked ? 'F' : 'U'; // 'U' para indefinido, caso nenhum dos dois seja selecionado

            Pessoa pessoa = new Pessoa
            {
                Nome = Txt_Nome.Text,
                DataNascimento = Txt_Data.Value.ToShortDateString(),
                EstadoCivil = combo_Estado.SelectedItem.ToString(),
                Telefone = Txt_Fone.Text,
                CasaPropria = check_Casa.Checked,
                Veiculo = check_Veiculo.Checked,
                Sexo = sexo
            };


            if (index < 0)
            {
                lista_pessoas.Add(pessoa);

            }
            else
            {
                lista_pessoas[index] = pessoa;
            }

            btn_Limpar_Click(btn_Limpar, EventArgs.Empty);

            Listar();

        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            int indice = lista.SelectedIndex;
            lista_pessoas.RemoveAt(indice);
            Listar();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            Txt_Nome.Clear();
            Txt_Data.Value = DateTime.Now;
            Txt_Fone.Clear();
            combo_Estado.SelectedIndex = 0;
            check_Casa.Checked = false;
            check_Veiculo.Checked = false;
            radio_Masc.Checked = true;
            radio_Fem.Checked = false;
            Txt_Nome.Focus();
        }

        private void Listar()
        {
            lista.Items.Clear();

            foreach (Pessoa p in lista_pessoas)
            {
                lista.Items.Add(p.Nome);
            }
        }

        private void lista_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Pessoa pessoa = lista_pessoas[lista.SelectedIndex];
            Preencher(pessoa);

        }

        private void Preencher(Pessoa pessoa)
        {
            Txt_Nome.Text = pessoa.Nome;
            Txt_Data.Value = DateTime.Parse(pessoa.DataNascimento);
            Txt_Fone.Text = pessoa.Telefone;
            combo_Estado.SelectedItem = pessoa.EstadoCivil;
            check_Casa.Checked = pessoa.CasaPropria;
            check_Veiculo.Checked = pessoa.Veiculo;
            
            switch (pessoa.Sexo)
            {
                case 'M':
                    radio_Masc.Checked = true;
                    radio_Fem.Checked = false;
                    break;
                case 'F':
                    radio_Masc.Checked = false;
                    radio_Fem.Checked = true;
                    break;
                default:
                    radio_Masc.Checked = false;
                    radio_Fem.Checked = false;
                    break;
            }
        }
    }
}
