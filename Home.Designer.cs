namespace SOS
{
    partial class Home
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
            this.acessarConta = new System.Windows.Forms.Button();
            this.adicionarDespesa = new System.Windows.Forms.Button();
            this.butaoAdicionarCartao = new System.Windows.Forms.Button();
            this.analiseDaConta = new System.Windows.Forms.Button();
            this.entrarDespesa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // acessarConta
            // 
            this.acessarConta.Location = new System.Drawing.Point(1016, 18);
            this.acessarConta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.acessarConta.Name = "acessarConta";
            this.acessarConta.Size = new System.Drawing.Size(171, 35);
            this.acessarConta.TabIndex = 0;
            this.acessarConta.Text = "Conta";
            this.acessarConta.UseVisualStyleBackColor = true;
            this.acessarConta.Click += new System.EventHandler(this.acessarConta_Click);
            // 
            // adicionarDespesa
            // 
            this.adicionarDespesa.Location = new System.Drawing.Point(418, 560);
            this.adicionarDespesa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.adicionarDespesa.Name = "adicionarDespesa";
            this.adicionarDespesa.Size = new System.Drawing.Size(153, 35);
            this.adicionarDespesa.TabIndex = 1;
            this.adicionarDespesa.Text = "Adicionar despesa";
            this.adicionarDespesa.UseVisualStyleBackColor = true;
            this.adicionarDespesa.Click += new System.EventHandler(this.adicionarDespesa_Click);
            // 
            // butaoAdicionarCartao
            // 
            this.butaoAdicionarCartao.Location = new System.Drawing.Point(580, 560);
            this.butaoAdicionarCartao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butaoAdicionarCartao.Name = "butaoAdicionarCartao";
            this.butaoAdicionarCartao.Size = new System.Drawing.Size(150, 35);
            this.butaoAdicionarCartao.TabIndex = 2;
            this.butaoAdicionarCartao.Text = "Adicionar Cartão";
            this.butaoAdicionarCartao.UseVisualStyleBackColor = true;
            this.butaoAdicionarCartao.Click += new System.EventHandler(this.butaoAdicionarCartao_Click);
            // 
            // analiseDaConta
            // 
            this.analiseDaConta.Location = new System.Drawing.Point(837, 18);
            this.analiseDaConta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.analiseDaConta.Name = "analiseDaConta";
            this.analiseDaConta.Size = new System.Drawing.Size(171, 35);
            this.analiseDaConta.TabIndex = 3;
            this.analiseDaConta.Text = "Análise Financeira";
            this.analiseDaConta.UseVisualStyleBackColor = true;
            this.analiseDaConta.Click += new System.EventHandler(this.analiseDaConta_Click);
            // 
            // entrarDespesa
            // 
            this.entrarDespesa.Location = new System.Drawing.Point(659, 18);
            this.entrarDespesa.Name = "entrarDespesa";
            this.entrarDespesa.Size = new System.Drawing.Size(171, 35);
            this.entrarDespesa.TabIndex = 4;
            this.entrarDespesa.Text = "Despesas";
            this.entrarDespesa.UseVisualStyleBackColor = true;
            this.entrarDespesa.Click += new System.EventHandler(this.entrarDespesa_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.entrarDespesa);
            this.Controls.Add(this.analiseDaConta);
            this.Controls.Add(this.butaoAdicionarCartao);
            this.Controls.Add(this.adicionarDespesa);
            this.Controls.Add(this.acessarConta);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button acessarConta;
        private System.Windows.Forms.Button adicionarDespesa;
        private System.Windows.Forms.Button butaoAdicionarCartao;
        private System.Windows.Forms.Button analiseDaConta;
        private System.Windows.Forms.Button entrarDespesa;
    }
}