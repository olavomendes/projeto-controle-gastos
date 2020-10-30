namespace SOS
{
    partial class telaLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.usuario = new System.Windows.Forms.Label();
            this.loginUsuario = new System.Windows.Forms.TextBox();
            this.loginEntrar = new System.Windows.Forms.Button();
            this.loginCadastro = new System.Windows.Forms.Button();
            this.senha = new System.Windows.Forms.Label();
            this.loginSenha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // usuario
            // 
            this.usuario.AutoSize = true;
            this.usuario.Location = new System.Drawing.Point(317, 190);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(46, 13);
            this.usuario.TabIndex = 2;
            this.usuario.Text = "Usuario:";
            this.usuario.Click += new System.EventHandler(this.usuario_Click);
            // 
            // loginUsuario
            // 
            this.loginUsuario.Location = new System.Drawing.Point(321, 206);
            this.loginUsuario.Name = "loginUsuario";
            this.loginUsuario.Size = new System.Drawing.Size(178, 20);
            this.loginUsuario.TabIndex = 3;
            this.loginUsuario.TextChanged += new System.EventHandler(this.loginUsuario_TextChanged);
            // 
            // loginEntrar
            // 
            this.loginEntrar.Location = new System.Drawing.Point(321, 271);
            this.loginEntrar.Name = "loginEntrar";
            this.loginEntrar.Size = new System.Drawing.Size(87, 27);
            this.loginEntrar.TabIndex = 0;
            this.loginEntrar.Text = "Entrar";
            this.loginEntrar.UseVisualStyleBackColor = true;
            this.loginEntrar.Click += new System.EventHandler(this.entrarLogin_Click);
            // 
            // loginCadastro
            // 
            this.loginCadastro.Location = new System.Drawing.Point(411, 271);
            this.loginCadastro.Name = "loginCadastro";
            this.loginCadastro.Size = new System.Drawing.Size(87, 27);
            this.loginCadastro.TabIndex = 1;
            this.loginCadastro.Text = "Cadastre-se";
            this.loginCadastro.UseVisualStyleBackColor = true;
            this.loginCadastro.Click += new System.EventHandler(this.loginCadastro_Click);
            // 
            // senha
            // 
            this.senha.AutoSize = true;
            this.senha.Location = new System.Drawing.Point(318, 229);
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(41, 13);
            this.senha.TabIndex = 4;
            this.senha.Text = "Senha:";
            this.senha.Click += new System.EventHandler(this.senha_Click_1);
            // 
            // loginSenha
            // 
            this.loginSenha.Location = new System.Drawing.Point(321, 245);
            this.loginSenha.Name = "loginSenha";
            this.loginSenha.Size = new System.Drawing.Size(177, 20);
            this.loginSenha.TabIndex = 6;
            this.loginSenha.TextChanged += new System.EventHandler(this.loginSenha_TextChanged);
            // 
            // telaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginSenha);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.loginUsuario);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.loginCadastro);
            this.Controls.Add(this.loginEntrar);
            this.Name = "telaLogin";
            this.Text = "SOS";
            this.Load += new System.EventHandler(this.SOS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label usuario;
        private System.Windows.Forms.TextBox loginUsuario;
        private System.Windows.Forms.Button loginEntrar;
        private System.Windows.Forms.Button loginCadastro;
        private System.Windows.Forms.Label senha;
        private System.Windows.Forms.TextBox loginSenha;
    }
}

