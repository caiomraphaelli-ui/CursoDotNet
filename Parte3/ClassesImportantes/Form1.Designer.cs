namespace ClassesImportantes
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
            this.btnMessageBox = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnTimeSpam = new System.Windows.Forms.Button();
            this.btnDateTime = new System.Windows.Forms.Button();
            this.btnEnvironment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMessageBox
            // 
            this.btnMessageBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnMessageBox.Location = new System.Drawing.Point(12, 410);
            this.btnMessageBox.Name = "btnMessageBox";
            this.btnMessageBox.Size = new System.Drawing.Size(143, 54);
            this.btnMessageBox.TabIndex = 0;
            this.btnMessageBox.Text = "MessageBox";
            this.btnMessageBox.UseVisualStyleBackColor = false;
            this.btnMessageBox.Click += new System.EventHandler(this.btnMessageBox_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(12, 9);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(835, 350);
            this.lblResultado.TabIndex = 1;
            this.lblResultado.Text = "Resultado";
            // 
            // btnRandom
            // 
            this.btnRandom.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnRandom.Location = new System.Drawing.Point(191, 410);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(143, 54);
            this.btnRandom.TabIndex = 2;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = false;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnTimeSpam
            // 
            this.btnTimeSpam.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnTimeSpam.Location = new System.Drawing.Point(365, 410);
            this.btnTimeSpam.Name = "btnTimeSpam";
            this.btnTimeSpam.Size = new System.Drawing.Size(143, 54);
            this.btnTimeSpam.TabIndex = 3;
            this.btnTimeSpam.Text = "TimeSpam";
            this.btnTimeSpam.UseVisualStyleBackColor = false;
            this.btnTimeSpam.Click += new System.EventHandler(this.btnTimeSpam_Click);
            // 
            // btnDateTime
            // 
            this.btnDateTime.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnDateTime.Location = new System.Drawing.Point(526, 410);
            this.btnDateTime.Name = "btnDateTime";
            this.btnDateTime.Size = new System.Drawing.Size(143, 54);
            this.btnDateTime.TabIndex = 4;
            this.btnDateTime.Text = "DateTime";
            this.btnDateTime.UseVisualStyleBackColor = false;
            this.btnDateTime.Click += new System.EventHandler(this.btnDateTime_Click);
            // 
            // btnEnvironment
            // 
            this.btnEnvironment.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnEnvironment.Location = new System.Drawing.Point(687, 410);
            this.btnEnvironment.Name = "btnEnvironment";
            this.btnEnvironment.Size = new System.Drawing.Size(143, 54);
            this.btnEnvironment.TabIndex = 5;
            this.btnEnvironment.Text = "Environment";
            this.btnEnvironment.UseVisualStyleBackColor = false;
            this.btnEnvironment.Click += new System.EventHandler(this.btnEnvironment_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 476);
            this.Controls.Add(this.btnEnvironment);
            this.Controls.Add(this.btnDateTime);
            this.Controls.Add(this.btnTimeSpam);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnMessageBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMessageBox;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnTimeSpam;
        private System.Windows.Forms.Button btnDateTime;
        private System.Windows.Forms.Button btnEnvironment;
    }
}

