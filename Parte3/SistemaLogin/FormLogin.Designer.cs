namespace SistemaLogin
{
    partial class FormLogin
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
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.lbl_Senha = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Usuario.Location = new System.Drawing.Point(12, 15);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(145, 37);
            this.lbl_Usuario.TabIndex = 0;
            this.lbl_Usuario.Text = "Usuário:";
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Usuario.Location = new System.Drawing.Point(176, 12);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(342, 44);
            this.txt_Usuario.TabIndex = 1;
            // 
            // txt_Senha
            // 
            this.txt_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Senha.Location = new System.Drawing.Point(176, 113);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.PasswordChar = '*';
            this.txt_Senha.Size = new System.Drawing.Size(342, 44);
            this.txt_Senha.TabIndex = 3;
            // 
            // lbl_Senha
            // 
            this.lbl_Senha.AutoSize = true;
            this.lbl_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Senha.Location = new System.Drawing.Point(12, 116);
            this.lbl_Senha.Name = "lbl_Senha";
            this.lbl_Senha.Size = new System.Drawing.Size(124, 37);
            this.lbl_Senha.TabIndex = 2;
            this.lbl_Senha.Text = "Senha:";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.Location = new System.Drawing.Point(12, 194);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(255, 76);
            this.btn_Cancelar.TabIndex = 4;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Location = new System.Drawing.Point(369, 194);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(255, 76);
            this.btn_Login.TabIndex = 5;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 307);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.txt_Senha);
            this.Controls.Add(this.lbl_Senha);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.lbl_Usuario);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.Label lbl_Senha;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Login;
    }
}