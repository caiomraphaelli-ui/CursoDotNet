namespace WindowsForms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Nome = new System.Windows.Forms.TextBox();
            this.Txt_Data = new System.Windows.Forms.DateTimePicker();
            this.Txt_Fone = new System.Windows.Forms.MaskedTextBox();
            this.check_Casa = new System.Windows.Forms.CheckBox();
            this.check_Veiculo = new System.Windows.Forms.CheckBox();
            this.grupo_Sexo = new System.Windows.Forms.GroupBox();
            this.radio_Fem = new System.Windows.Forms.RadioButton();
            this.radio_Masc = new System.Windows.Forms.RadioButton();
            this.lista = new System.Windows.Forms.ListBox();
            this.btn_Cadastro = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.combo_Estado = new System.Windows.Forms.ComboBox();
            this.grupo_Sexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data Nascimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estado Civil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefone";
            // 
            // Txt_Nome
            // 
            this.Txt_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Nome.Location = new System.Drawing.Point(239, 22);
            this.Txt_Nome.Name = "Txt_Nome";
            this.Txt_Nome.Size = new System.Drawing.Size(279, 31);
            this.Txt_Nome.TabIndex = 4;
            // 
            // Txt_Data
            // 
            this.Txt_Data.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Data.Location = new System.Drawing.Point(239, 71);
            this.Txt_Data.Name = "Txt_Data";
            this.Txt_Data.Size = new System.Drawing.Size(279, 24);
            this.Txt_Data.TabIndex = 5;
            // 
            // Txt_Fone
            // 
            this.Txt_Fone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Fone.Location = new System.Drawing.Point(239, 164);
            this.Txt_Fone.Mask = "(00) 00000-0000";
            this.Txt_Fone.Name = "Txt_Fone";
            this.Txt_Fone.Size = new System.Drawing.Size(279, 31);
            this.Txt_Fone.TabIndex = 7;
            // 
            // check_Casa
            // 
            this.check_Casa.AutoSize = true;
            this.check_Casa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_Casa.Location = new System.Drawing.Point(239, 213);
            this.check_Casa.Name = "check_Casa";
            this.check_Casa.Size = new System.Drawing.Size(170, 24);
            this.check_Casa.TabIndex = 8;
            this.check_Casa.Text = "Possui Casa Própria";
            this.check_Casa.UseVisualStyleBackColor = true;
            // 
            // check_Veiculo
            // 
            this.check_Veiculo.AutoSize = true;
            this.check_Veiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_Veiculo.Location = new System.Drawing.Point(239, 255);
            this.check_Veiculo.Name = "check_Veiculo";
            this.check_Veiculo.Size = new System.Drawing.Size(131, 24);
            this.check_Veiculo.TabIndex = 9;
            this.check_Veiculo.Text = "Possui Veículo";
            this.check_Veiculo.UseVisualStyleBackColor = true;
            // 
            // grupo_Sexo
            // 
            this.grupo_Sexo.Controls.Add(this.radio_Fem);
            this.grupo_Sexo.Controls.Add(this.radio_Masc);
            this.grupo_Sexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupo_Sexo.Location = new System.Drawing.Point(239, 297);
            this.grupo_Sexo.Name = "grupo_Sexo";
            this.grupo_Sexo.Size = new System.Drawing.Size(279, 118);
            this.grupo_Sexo.TabIndex = 11;
            this.grupo_Sexo.TabStop = false;
            this.grupo_Sexo.Text = "Sexo";
            // 
            // radio_Fem
            // 
            this.radio_Fem.AutoSize = true;
            this.radio_Fem.Location = new System.Drawing.Point(6, 68);
            this.radio_Fem.Name = "radio_Fem";
            this.radio_Fem.Size = new System.Drawing.Size(92, 24);
            this.radio_Fem.TabIndex = 1;
            this.radio_Fem.TabStop = true;
            this.radio_Fem.Text = "Feminino";
            this.radio_Fem.UseVisualStyleBackColor = true;
            // 
            // radio_Masc
            // 
            this.radio_Masc.AutoSize = true;
            this.radio_Masc.Location = new System.Drawing.Point(6, 38);
            this.radio_Masc.Name = "radio_Masc";
            this.radio_Masc.Size = new System.Drawing.Size(102, 24);
            this.radio_Masc.TabIndex = 0;
            this.radio_Masc.TabStop = true;
            this.radio_Masc.Text = "Masculino ";
            this.radio_Masc.UseVisualStyleBackColor = true;
            // 
            // lista
            // 
            this.lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista.FormattingEnabled = true;
            this.lista.ItemHeight = 25;
            this.lista.Location = new System.Drawing.Point(53, 576);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(658, 154);
            this.lista.TabIndex = 12;
            this.lista.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lista_MouseDoubleClick);
            // 
            // btn_Cadastro
            // 
            this.btn_Cadastro.Location = new System.Drawing.Point(12, 504);
            this.btn_Cadastro.Name = "btn_Cadastro";
            this.btn_Cadastro.Size = new System.Drawing.Size(217, 49);
            this.btn_Cadastro.TabIndex = 13;
            this.btn_Cadastro.Text = "Cadastrar / Alterar";
            this.btn_Cadastro.UseVisualStyleBackColor = true;
            this.btn_Cadastro.Click += new System.EventHandler(this.btn_Cadastro_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Location = new System.Drawing.Point(276, 504);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(217, 49);
            this.btn_Excluir.TabIndex = 14;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Location = new System.Drawing.Point(540, 504);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(217, 49);
            this.btn_Limpar.TabIndex = 15;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // combo_Estado
            // 
            this.combo_Estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_Estado.FormattingEnabled = true;
            this.combo_Estado.Items.AddRange(new object[] {
            "Solteiro",
            "Casado",
            "Divorciado"});
            this.combo_Estado.Location = new System.Drawing.Point(239, 113);
            this.combo_Estado.Name = "combo_Estado";
            this.combo_Estado.Size = new System.Drawing.Size(279, 33);
            this.combo_Estado.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 780);
            this.Controls.Add(this.combo_Estado);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Cadastro);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.grupo_Sexo);
            this.Controls.Add(this.check_Veiculo);
            this.Controls.Add(this.check_Casa);
            this.Controls.Add(this.Txt_Fone);
            this.Controls.Add(this.Txt_Data);
            this.Controls.Add(this.Txt_Nome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grupo_Sexo.ResumeLayout(false);
            this.grupo_Sexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Nome;
        private System.Windows.Forms.DateTimePicker Txt_Data;
        private System.Windows.Forms.MaskedTextBox Txt_Fone;
        private System.Windows.Forms.CheckBox check_Casa;
        private System.Windows.Forms.CheckBox check_Veiculo;
        private System.Windows.Forms.GroupBox grupo_Sexo;
        private System.Windows.Forms.RadioButton radio_Fem;
        private System.Windows.Forms.RadioButton radio_Masc;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Button btn_Cadastro;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.ComboBox combo_Estado;
    }
}

