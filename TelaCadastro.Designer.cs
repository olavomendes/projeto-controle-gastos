namespace SOS
{
    partial class TelaCadastro
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
            this.usuarioCadastro = new System.Windows.Forms.Label();
            this.usuarioCadastroCampo = new System.Windows.Forms.TextBox();
            this.senhaCadastroCampo = new System.Windows.Forms.TextBox();
            this.senhaCadastro = new System.Windows.Forms.Label();
            this.emailCadastro = new System.Windows.Forms.Label();
            this.emailCadastroCampo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usuarioCadastro
            // 
            this.usuarioCadastro.AutoSize = true;
            this.usuarioCadastro.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.usuarioCadastro.Location = new System.Drawing.Point(303, 113);
            this.usuarioCadastro.MaximumSize = new System.Drawing.Size(50, 50);
            this.usuarioCadastro.MinimumSize = new System.Drawing.Size(10, 10);
            this.usuarioCadastro.Name = "usuarioCadastro";
            this.usuarioCadastro.Size = new System.Drawing.Size(46, 13);
            this.usuarioCadastro.TabIndex = 0;
            this.usuarioCadastro.Text = "Usuario:";
            this.usuarioCadastro.Click += new System.EventHandler(this.usuarioCadastro_Click);
            // 
            // usuarioCadastroCampo
            // 
            this.usuarioCadastroCampo.Location = new System.Drawing.Point(306, 129);
            this.usuarioCadastroCampo.Name = "usuarioCadastroCampo";
            this.usuarioCadastroCampo.Size = new System.Drawing.Size(156, 20);
            this.usuarioCadastroCampo.TabIndex = 1;
            this.usuarioCadastroCampo.TextChanged += new System.EventHandler(this.usuarioCadastroCampo_TextChanged);
            // 
            // senhaCadastroCampo
            // 
            this.senhaCadastroCampo.Location = new System.Drawing.Point(305, 179);
            this.senhaCadastroCampo.Name = "senhaCadastroCampo";
            this.senhaCadastroCampo.Size = new System.Drawing.Size(154, 20);
            this.senhaCadastroCampo.TabIndex = 2;
            this.senhaCadastroCampo.TextChanged += new System.EventHandler(this.senhaCadastroCampo_TextChanged);
            // 
            // senhaCadastro
            // 
            this.senhaCadastro.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.senhaCadastro.Location = new System.Drawing.Point(303, 161);
            this.senhaCadastro.Name = "senhaCadastro";
            this.senhaCadastro.Size = new System.Drawing.Size(67, 15);
            this.senhaCadastro.TabIndex = 3;
            this.senhaCadastro.Text = "Senha:";
            this.senhaCadastro.Click += new System.EventHandler(this.senhaCadastro_Click_1);
            // 
            // emailCadastro
            // 
            this.emailCadastro.ForeColor = System.Drawing.SystemColors.Highlight;
            this.emailCadastro.Location = new System.Drawing.Point(303, 212);
            this.emailCadastro.Name = "emailCadastro";
            this.emailCadastro.Size = new System.Drawing.Size(57, 13);
            this.emailCadastro.TabIndex = 4;
            this.emailCadastro.Text = "Email:";
            // 
            // emailCadastroCampo
            // 
            this.emailCadastroCampo.Location = new System.Drawing.Point(306, 228);
            this.emailCadastroCampo.Name = "emailCadastroCampo";
            this.emailCadastroCampo.Size = new System.Drawing.Size(152, 20);
            this.emailCadastroCampo.TabIndex = 5;
            this.emailCadastroCampo.TextChanged += new System.EventHandler(this.emailCadastroCampo_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(315, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.cadastrarUsuario_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(386, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 27);
            this.button2.TabIndex = 7;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.sairCadastro_Click);
            // 
            // TelaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.emailCadastroCampo);
            this.Controls.Add(this.emailCadastro);
            this.Controls.Add(this.senhaCadastro);
            this.Controls.Add(this.senhaCadastroCampo);
            this.Controls.Add(this.usuarioCadastroCampo);
            this.Controls.Add(this.usuarioCadastro);
            this.Name = "TelaCadastro";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.TelaCadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usuarioCadastro;
        private System.Windows.Forms.TextBox usuarioCadastroCampo;
        private System.Windows.Forms.TextBox senhaCadastroCampo;
        private System.Windows.Forms.Label senhaCadastro;
        private System.Windows.Forms.Label emailCadastro;
        private System.Windows.Forms.TextBox emailCadastroCampo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}