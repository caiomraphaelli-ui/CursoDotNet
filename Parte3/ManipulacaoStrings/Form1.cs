using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManipulacaoStrings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Executar_Click(object sender, EventArgs e)
        {
            string texto = "Este tipo de variável é alfanumérica";
            int num = 55;


            #region Contains / ToString 

            num.ToString(); // Convertendo o número para string

            // Verificar se a string contém a substring "variável" Case Sensitive
            if (texto.Contains("variável"))
            {
                label1.Text = "Contém";
            }
            else
            {
                label1.Text = "Não Contém";
            }
            #endregion

            #region ToUpper / ToLower

            label2.Text = texto.ToUpper(); // Converte a string para tudo maiúsculo
            label2.Text = texto.ToLower(); // Converte a string para tudo minúsculo

            #endregion

            #region IndexOf / LastIndexOf
            //Index é a posição do caractere na string, começando do 0

            texto.IndexOf("va"); // Retorna a posição da primeira ocorrência da substring "va"
            texto.IndexOf('a', 5, 4); // Retorna a posição da primeira ocorrência do caractere 'a' a partir da posição 5 e considerando os próximos 4 caracteres

            label2.Text = texto.LastIndexOf("va").ToString(); // Retorna a posição da última ocorrência da substring "va"
            label2.Text = texto.LastIndexOf('a', 20, 10).ToString(); // Retorna a posição da última ocorrência do caractere 'a' a partir da posição 20 e considerando os próximos 10 caracteres

            #endregion

            #region Insert / Replace

            label2.Text = texto.Insert(5, "TESTE"); // Insere a string "TESTE" na posição 5 da string original
            label2.Text = texto.Replace("variável", "string"); // Substitui todas as ocorrências da substring "variável" por "string"
            label2.Text = texto.Replace('a', 'x'); // Substitui todas as ocorrências do caractere 'a' por 'x'

            #endregion

            #region Length / Substring
            //String é um array de caracteres

            string subTexto = texto.Substring(5, 10); // Retorna uma substring da string original, começando na posição 5 e com comprimento de 10 caracteres
            label2.Text = texto.Length.ToString(); // Retorna o comprimento da string original

            #endregion

            #region Split
            //Retorna um array de strings, dividindo a string original com base em um separador especificado

            string nomes = "Caio João Danny Arthur Bias";

            char[] separador = {' '};

            string[] array_nomes = nomes.Split(separador);

            label2.Text = array_nomes[0]; // Retorna "Caio"

            #endregion

            #region StartsWith / EndsWith
            // Verificar se a string começa/termina com um caracter ou uma substring

            label1.Text = array_nomes[0].StartsWith("Ca").ToString();
            label2.Text = array_nomes[0].EndsWith("io").ToString();

            //Temos parametros de StringComparison para ignorar case sensitive, acentos, etc

            array_nomes[0].StartsWith("ca", StringComparison.OrdinalIgnoreCase); // Ignora case sensitive

            #endregion

            #region Trim / TrimStart / TrimEnd
            // Remove os espaços em branco do início e do final da string

            string texto2 = "   Este texto tem espaços em branco no início e no final.   ";
            label2.Text = texto2.Trim(); // Remove os espaços em branco do início e do final da string
                                         //Trim com parametros para remover caracteres específicos

            label2.Text = texto2.TrimStart(); // Remove os espaços em branco do início da string

            #endregion

            #region Equals / CompareTo

            //Equals compara o conteúdo de duas strings, retornando true se forem iguais e false caso contrário
            //CompareTo compara duas strings e retorna um valor inteiro que indica a relação entre elas (menor, igual ou maior) em relação à ordem lexicográfica (case sensitive)
            string str1 = "Hello";
             string str2 = "hello";
             label1.Text = str1.Equals(str2).ToString(); // Retorna false, pois as strings são diferentes (case sensitive)
             label1.Text = str1.Equals(str2, StringComparison.OrdinalIgnoreCase).ToString(); // Retorna true, ignorando case sensitive
             label2.Text = str1.CompareTo(str2).ToString(); // Retorna um valor negativo, pois "Hello" é menor que "hello" (case sensitive)

            #endregion

            #region Format
            // Formata uma string usando um formato específico, como moeda, data, etc
            //O formato é definido por meio de um especificador de formato, que pode ser um número, uma letra ou uma combinação de ambos

            decimal valor = 1234.56m;
            int tempo = 90;
            
            string textoFormatado = String.Format("O valor é {0:C2} e o tempo é {1}", valor, tempo); // Formata o valor como moeda, usando a cultura atual
            string textoFormatado2 = String.Format($"Aqui inserimos aa variavel {valor} diretamente ");


            string.Format("{0:N2}", 1234.5); // 1.234,50 - Formata o número com 2 casas decimais e separador de milhares
            string.Format("{0:P}", 0.25);    // 25,00 % - Formata o número como porcentagem
            string.Format("{0:D4}", 12);     // 0012 - Formata o número como um inteiro decimal com 4 dígitos, preenchendo com zeros à esquerda
            string.Format("{0:F1}", 10.567); // 10,6 - Formata o número como um número de ponto flutuante com 1 casa decimal
            string.Format("{0:X}", 255);     // FF - Formata o número como um hexadecimal

            //Para Data e Hora, temos varios formatos


            #endregion

        }
    }
}
