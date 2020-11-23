namespace SOS
{
    partial class AdicionarCartao
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
            this.numeroCartao = new System.Windows.Forms.Label();
            this.adicionarNumeroCartao = new System.Windows.Forms.TextBox();
            this.adicionarTipoCartao = new System.Windows.Forms.TextBox();
            this.adicionarBandeiraCartao = new System.Windows.Forms.TextBox();
            this.adicionarLimiteCartao = new System.Windows.Forms.TextBox();
            this.adicionarValorAtual = new System.Windows.Forms.TextBox();
            this.adicionarDiaFechamento = new System.Windows.Forms.TextBox();
            this.tipoCartao = new System.Windows.Forms.Label();
            this.bandeiraCartao = new System.Windows.Forms.Label();
            this.limiteCartao = new System.Windows.Forms.Label();
            this.valorAtualCartao = new System.Windows.Forms.Label();
            this.diaFechamentoCartao = new System.Windows.Forms.Label();
            this.butaoAdicionarCartao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numeroCartao
            // 
            this.numeroCartao.AutoSize = true;
            this.numeroCartao.Location = new System.Drawing.Point(77, 53);
            this.numeroCartao.Name = "numeroCartao";
            this.numeroCartao.Size = new System.Drawing.Size(44, 13);
            this.numeroCartao.TabIndex = 0;
            this.numeroCartao.Text = "Número";
            this.numeroCartao.Click += new System.EventHandler(this.numeroCartao_Click);
            // 
            // adicionarNumeroCartao
            // 
            this.adicionarNumeroCartao.Location = new System.Drawing.Point(56, 69);
            this.adicionarNumeroCartao.Name = "adicionarNumeroCartao";
            this.adicionarNumeroCartao.Size = new System.Drawing.Size(100, 20);
            this.adicionarNumeroCartao.TabIndex = 1;
            this.adicionarNumeroCartao.TextChanged += new System.EventHandler(this.adicionarNumeroCartao_TextChanged);
            // 
            // adicionarTipoCartao
            // 
            this.adicionarTipoCartao.Location = new System.Drawing.Point(56, 116);
            this.adicionarTipoCartao.Name = "adicionarTipoCartao";
            this.adicionarTipoCartao.Size = new System.Drawing.Size(100, 20);
            this.adicionarTipoCartao.TabIndex = 2;
            this.adicionarTipoCartao.TextChanged += new System.EventHandler(this.adicionarTipoCartao_TextChanged);
            // 
            // adicionarBandeiraCartao
            // 
            this.adicionarBandeiraCartao.Location = new System.Drawing.Point(56, 165);
            this.adicionarBandeiraCartao.Name = "adicionarBandeiraCartao";
            this.adicionarBandeiraCartao.Size = new System.Drawing.Size(100, 20);
            this.adicionarBandeiraCartao.TabIndex = 3;
            this.adicionarBandeiraCartao.TextChanged += new System.EventHandler(this.adicionarBandeiraCartao_TextChanged);
            // 
            // adicionarLimiteCartao
            // 
            this.adicionarLimiteCartao.Location = new System.Drawing.Point(56, 212);
            this.adicionarLimiteCartao.Name = "adicionarLimiteCartao";
            this.adicionarLimiteCartao.Size = new System.Drawing.Size(100, 20);
            this.adicionarLimiteCartao.TabIndex = 4;
            this.adicionarLimiteCartao.TextChanged += new System.EventHandler(this.adicionarLimiteCartao_TextChanged);
            // 
            // adicionarValorAtual
            // 
            this.adicionarValorAtual.Location = new System.Drawing.Point(56, 262);
            this.adicionarValorAtual.Name = "adicionarValorAtual";
            this.adicionarValorAtual.Size = new System.Drawing.Size(100, 20);
            this.adicionarValorAtual.TabIndex = 5;
            this.adicionarValorAtual.TextChanged += new System.EventHandler(this.adicionarValorAtual_TextChanged);
            // 
            // adicionarDiaFechamento
            // 
            this.adicionarDiaFechamento.Location = new System.Drawing.Point(56, 311);
            this.adicionarDiaFechamento.Name = "adicionarDiaFechamento";
            this.adicionarDiaFechamento.Size = new System.Drawing.Size(100, 20);
            this.adicionarDiaFechamento.TabIndex = 6;
            this.adicionarDiaFechamento.TextChanged += new System.EventHandler(this.adicionarDiaFechamento_TextChanged);
            // 
            // tipoCartao
            // 
            this.tipoCartao.AutoSize = true;
            this.tipoCartao.Location = new System.Drawing.Point(87, 100);
            this.tipoCartao.Name = "tipoCartao";
            this.tipoCartao.Size = new System.Drawing.Size(28, 13);
            this.tipoCartao.TabIndex = 7;
            this.tipoCartao.Text = "Tipo";
            this.tipoCartao.Click += new System.EventHandler(this.tipoCartao_Click);
            // 
            // bandeiraCartao
            // 
            this.bandeiraCartao.AutoSize = true;
            this.bandeiraCartao.Location = new System.Drawing.Point(77, 149);
            this.bandeiraCartao.Name = "bandeiraCartao";
            this.bandeiraCartao.Size = new System.Drawing.Size(49, 13);
            this.bandeiraCartao.TabIndex = 8;
            this.bandeiraCartao.Text = "Bandeira";
            this.bandeiraCartao.Click += new System.EventHandler(this.bandeiraCartao_Click);
            // 
            // limiteCartao
            // 
            this.limiteCartao.AutoSize = true;
            this.limiteCartao.Location = new System.Drawing.Point(77, 196);
            this.limiteCartao.Name = "limiteCartao";
            this.limiteCartao.Size = new System.Drawing.Size(54, 13);
            this.limiteCartao.TabIndex = 9;
            this.limiteCartao.Text = "Limite(R$)";
            this.limiteCartao.Click += new System.EventHandler(this.limiteCartao_Click);
            // 
            // valorAtualCartao
            // 
            this.valorAtualCartao.AutoSize = true;
            this.valorAtualCartao.Location = new System.Drawing.Point(73, 246);
            this.valorAtualCartao.Name = "valorAtualCartao";
            this.valorAtualCartao.Size = new System.Drawing.Size(58, 13);
            this.valorAtualCartao.TabIndex = 10;
            this.valorAtualCartao.Text = "Valor Atual";
            this.valorAtualCartao.Click += new System.EventHandler(this.valorAtualCartao_Click);
            // 
            // diaFechamentoCartao
            // 
            this.diaFechamentoCartao.AutoSize = true;
            this.diaFechamentoCartao.Location = new System.Drawing.Point(62, 295);
            this.diaFechamentoCartao.Name = "diaFechamentoCartao";
            this.diaFechamentoCartao.Size = new System.Drawing.Size(82, 13);
            this.diaFechamentoCartao.TabIndex = 11;
            this.diaFechamentoCartao.Text = "Dia fechamento";
            this.diaFechamentoCartao.Click += new System.EventHandler(this.diaFechamentoCartao_Click);
            // 
            // butaoAdicionarCartao
            // 
            this.butaoAdicionarCartao.Location = new System.Drawing.Point(56, 337);
            this.butaoAdicionarCartao.Name = "butaoAdicionarCartao";
            this.butaoAdicionarCartao.Size = new System.Drawing.Size(97, 23);
            this.butaoAdicionarCartao.TabIndex = 12;
            this.butaoAdicionarCartao.Text = "Adicionar cartão";
            this.butaoAdicionarCartao.UseVisualStyleBackColor = true;
            this.butaoAdicionarCartao.Click += new System.EventHandler(this.butaoAdicionarCartao_Click);
            // 
            // AdicionarCartao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 395);
            this.Controls.Add(this.butaoAdicionarCartao);
            this.Controls.Add(this.diaFechamentoCartao);
            this.Controls.Add(this.valorAtualCartao);
            this.Controls.Add(this.limiteCartao);
            this.Controls.Add(this.bandeiraCartao);
            this.Controls.Add(this.tipoCartao);
            this.Controls.Add(this.adicionarDiaFechamento);
            this.Controls.Add(this.adicionarValorAtual);
            this.Controls.Add(this.adicionarLimiteCartao);
            this.Controls.Add(this.adicionarBandeiraCartao);
            this.Controls.Add(this.adicionarTipoCartao);
            this.Controls.Add(this.adicionarNumeroCartao);
            this.Controls.Add(this.numeroCartao);
            this.Name = "AdicionarCartao";
            this.Text = "Adicionar cartao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numeroCartao;
        private System.Windows.Forms.TextBox adicionarNumeroCartao;
        private System.Windows.Forms.TextBox adicionarTipoCartao;
        private System.Windows.Forms.TextBox adicionarBandeiraCartao;
        private System.Windows.Forms.TextBox adicionarLimiteCartao;
        private System.Windows.Forms.TextBox adicionarValorAtual;
        private System.Windows.Forms.TextBox adicionarDiaFechamento;
        private System.Windows.Forms.Label tipoCartao;
        private System.Windows.Forms.Label bandeiraCartao;
        private System.Windows.Forms.Label limiteCartao;
        private System.Windows.Forms.Label valorAtualCartao;
        private System.Windows.Forms.Label diaFechamentoCartao;
        private System.Windows.Forms.Button butaoAdicionarCartao;
    }
}