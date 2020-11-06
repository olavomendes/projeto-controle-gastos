namespace SOS
{
    partial class Conta
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
            this.contaUsuario = new System.Windows.Forms.Label();
            this.campoNomeUsuario = new System.Windows.Forms.TextBox();
            this.contaEmail = new System.Windows.Forms.Label();
            this.campoNomeEmail = new System.Windows.Forms.TextBox();
            this.trocarSenha = new System.Windows.Forms.Button();
            this.sairConta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contaUsuario
            // 
            this.contaUsuario.AutoSize = true;
            this.contaUsuario.Location = new System.Drawing.Point(311, 154);
            this.contaUsuario.Name = "contaUsuario";
            this.contaUsuario.Size = new System.Drawing.Size(43, 13);
            this.contaUsuario.TabIndex = 0;
            this.contaUsuario.Text = "Usuario";
            this.contaUsuario.Click += new System.EventHandler(this.contaUsuario_Click);
            // 
            // campoNomeUsuario
            // 
            this.campoNomeUsuario.Location = new System.Drawing.Point(314, 170);
            this.campoNomeUsuario.Name = "campoNomeUsuario";
            this.campoNomeUsuario.Size = new System.Drawing.Size(150, 20);
            this.campoNomeUsuario.TabIndex = 1;
            this.campoNomeUsuario.TextChanged += new System.EventHandler(this.campoNomeUsuario_TextChanged);
            // 
            // contaEmail
            // 
            this.contaEmail.AutoSize = true;
            this.contaEmail.Location = new System.Drawing.Point(311, 201);
            this.contaEmail.Name = "contaEmail";
            this.contaEmail.Size = new System.Drawing.Size(32, 13);
            this.contaEmail.TabIndex = 2;
            this.contaEmail.Text = "Email";
            this.contaEmail.Click += new System.EventHandler(this.contaEmail_Click);
            // 
            // campoNomeEmail
            // 
            this.campoNomeEmail.Location = new System.Drawing.Point(314, 217);
            this.campoNomeEmail.Name = "campoNomeEmail";
            this.campoNomeEmail.Size = new System.Drawing.Size(150, 20);
            this.campoNomeEmail.TabIndex = 3;
            this.campoNomeEmail.TextChanged += new System.EventHandler(this.campoNomeEmail_TextChanged);
            // 
            // trocarSenha
            // 
            this.trocarSenha.Location = new System.Drawing.Point(314, 252);
            this.trocarSenha.Name = "trocarSenha";
            this.trocarSenha.Size = new System.Drawing.Size(88, 32);
            this.trocarSenha.TabIndex = 4;
            this.trocarSenha.Text = "Trocar senha?";
            this.trocarSenha.UseVisualStyleBackColor = true;
            this.trocarSenha.Click += new System.EventHandler(this.trocarSenha_Click);
            // 
            // sairConta
            // 
            this.sairConta.Location = new System.Drawing.Point(408, 252);
            this.sairConta.Name = "sairConta";
            this.sairConta.Size = new System.Drawing.Size(56, 32);
            this.sairConta.TabIndex = 5;
            this.sairConta.Text = "Sair";
            this.sairConta.UseVisualStyleBackColor = true;
            this.sairConta.Click += new System.EventHandler(this.sairConta_Click);
            // 
            // Conta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sairConta);
            this.Controls.Add(this.trocarSenha);
            this.Controls.Add(this.campoNomeEmail);
            this.Controls.Add(this.contaEmail);
            this.Controls.Add(this.campoNomeUsuario);
            this.Controls.Add(this.contaUsuario);
            this.Name = "Conta";
            this.Text = "Sua Conta";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label contaUsuario;
        private System.Windows.Forms.TextBox campoNomeUsuario;
        private System.Windows.Forms.Label contaEmail;
        private System.Windows.Forms.TextBox campoNomeEmail;
        private System.Windows.Forms.Button trocarSenha;
        private System.Windows.Forms.Button sairConta;
    }
}