using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassesImportantes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMessageBox_Click(object sender, EventArgs e)
        {
            //MessageBox é uma classe do namespace System.Windows.Forms que exibe uma caixa de diálogo com uma mensagem para o usuário.
            //Tem 20 overloads, o mais simples é a string

            //Aqui setamos os botoes que queremos que apareçam, bem como o Título
            DialogResult res =  MessageBox.Show("Mensagem", "Título", MessageBoxButtons.YesNoCancel);

            if (res == DialogResult.Yes)
            {
                lblResultado.Text = "Você clicou em Sim";
            }

            MessageBox.Show("Mensagem", "Título", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);
   
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            //O numero nao e aleatorio de verdade, ele é gerado a partir de um algoritmo, por isso é chamado de pseudo-aleatório

            //Aqui inicializamos o gerador de números aleatórios com uma semente, que é o valor usado para iniciar o algoritmo de geração de números aleatórios.
            Random random = new Random(DateTime.Now.Millisecond);

            random.Next(10, 100); //Gera um número aleatório entre 10 e 99 (o limite superior é exclusivo)
            int valor = random.Next();

            lblResultado.Text = $"Número aleatório: {valor}";
        }

        private void btnTimeSpam_Click(object sender, EventArgs e)
        {
            //TimeSpan é uma estrutura representa um intervalo de tempo. Ele pode ser usado para medir o tempo decorrido entre dois eventos ou para representar uma duração específica.
            //Ticks são a menor unidade de tempo representada pelo TimeSpan, onde 1 tick é igual a 100 nanosegundos.

            //Varios metodos, da classe, objetos instaciaods e propriedades.

            TimeSpan.FromDays(12.6); //Cria um TimeSpan de 12,6 dias

            TimeSpan tempo = new TimeSpan(1, 30, 45 ); //Cria um TimeSpan de 1 hora, 30 minutos e 45 segundos
            tempo.Hours.ToString(); //Retorna a parte de horas do TimeSpan como string

            lblResultado.Text = $"TimeSpan: {TimeSpan.FromSeconds(90)}"; //Cria um TimeSpan de 90 segundos
        }

        private void btnDateTime_Click(object sender, EventArgs e)
        {
            //DateTime é uma estrutura que representa um ponto específico no tempo, incluindo data e hora. Ele pode ser usado para armazenar e manipular informações de data e hora em um programa.
            lblResultado.Text = $"Data e Hora atual: {DateTime.Now}"; //Retorna a data e hora atual do sistema
        }

        private void btnEnvironment_Click(object sender, EventArgs e)
        {
            //Classe Environment fornece informações sobre o ambiente de execução do aplicativo, como variáveis de ambiente, diretórios do sistema, informações de processador, etc.
            
            lblResultado.Text = $"Nome do computador: {Environment.MachineName}\n" +
                                $"Sistema Operacional: {Environment.OSVersion}\n" +
                                $"Número de processadores: {Environment.ProcessorCount}\n" +
                                $"Diretório atual: {Environment.CurrentDirectory}";

            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); //Retorna o caminho do diretório "Meus Documentos" do usuário atual
            Environment.GetEnvironmentVariable("PATH"); //Retorna o valor da variável de ambiente "PATH"

            //Tambem tem a classe Aplication , que fornece informações sobre o aplicativo em execução, como o caminho do executável, a versão do aplicativo, etc.
        }
    }
}
