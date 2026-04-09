using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoKenPo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPedra_Click(object sender, EventArgs e)
        {
            Startgame(0);
        }

        private void btnPapel_Click(object sender, EventArgs e)
        {
            Startgame(1);
        }

        private void btnTesoura_Click(object sender, EventArgs e)
        {
            Startgame(2);
        }

        private void Startgame(int opcao)
        {
            label3.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            Game jogo = new Game();

            switch (jogo.Jogar(opcao))
            {
                case Game.Resultado.Ganhar:
                    picResultado.BackgroundImage = Image.FromFile("imagens/Ganhar.png");
                    //label3.Visible = true;
                    goto default;
                case Game.Resultado.Perder:
                    picResultado.BackgroundImage = Image.FromFile("imagens/Perder.png");
                    //label3.Visible = true;
                    goto default;
                case Game.Resultado.Empatar:
                    picResultado.BackgroundImage = Image.FromFile("imagens/Empatar.png");
                    //label3.Visible = true;
                    goto default;
                default:
                    pictureBox1.Image = jogo.ImgPlayer;
                    pictureBox2.Image = jogo.ImgPC;
                    break;

            }


        }

    }
}
