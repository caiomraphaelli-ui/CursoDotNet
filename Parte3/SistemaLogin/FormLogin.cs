using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLogin
{
    public partial class FormLogin : Form
    {

        public static bool Cancelar = false;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txt_Usuario.Text.Equals("") || txt_Senha.Text.Equals(""))
            {
                MessageBox.Show("Preencha os campos de usuário e senha.");
                return;
            }
            else if(CadastroUsuarios.Login(txt_Usuario.Text, txt_Senha.Text))
            {
                //MessageBox.Show("Login realizado com sucesso!");
                Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos.");
                txt_Usuario.Clear();
                txt_Senha.Clear(); 
            }

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Cancelar = true;
            Close();
        }
    }
}
