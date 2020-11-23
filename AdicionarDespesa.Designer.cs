namespace SOS
{
    partial class AdicionarDespesa
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
            this.nomeValor = new System.Windows.Forms.Label();
            this.campoValor = new System.Windows.Forms.TextBox();
            this.campoData = new System.Windows.Forms.TextBox();
            this.nomeData = new System.Windows.Forms.Label();
            this.nomeDescricao = new System.Windows.Forms.Label();
            this.campoDescricao = new System.Windows.Forms.TextBox();
            this.nomeCategoria = new System.Windows.Forms.Label();
            this.campoCategoria = new System.Windows.Forms.TextBox();
            this.nomeFormaDePagamento = new System.Windows.Forms.Label();
            this.campoFormaDePagamento = new System.Windows.Forms.TextBox();
            this.nomeNumeroDeParcelas = new System.Windows.Forms.Label();
            this.campoNumeroDeParcelas = new System.Windows.Forms.TextBox();
            this.nomeValorPago = new System.Windows.Forms.Label();
            this.campoValorPago = new System.Windows.Forms.TextBox();
            this.botãoAdicionarDespesa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nomeValor
            // 
            this.nomeValor.AutoSize = true;
            this.nomeValor.Location = new System.Drawing.Point(63, 19);
            this.nomeValor.Name = "nomeValor";
            this.nomeValor.Size = new System.Drawing.Size(31, 13);
            this.nomeValor.TabIndex = 0;
            this.nomeValor.Text = "Valor";
            this.nomeValor.Click += new System.EventHandler(this.nomeValor_Click);
            // 
            // campoValor
            // 
            this.campoValor.Location = new System.Drawing.Point(30, 35);
            this.campoValor.Name = "campoValor";
            this.campoValor.Size = new System.Drawing.Size(100, 20);
            this.campoValor.TabIndex = 1;
            this.campoValor.TextChanged += new System.EventHandler(this.campoValor_TextChanged);
            // 
            // campoData
            // 
            this.campoData.Location = new System.Drawing.Point(33, 80);
            this.campoData.Name = "campoData";
            this.campoData.Size = new System.Drawing.Size(100, 20);
            this.campoData.TabIndex = 2;
            this.campoData.TextChanged += new System.EventHandler(this.campoData_TextChanged);
            // 
            // nomeData
            // 
            this.nomeData.AutoSize = true;
            this.nomeData.Location = new System.Drawing.Point(63, 64);
            this.nomeData.Name = "nomeData";
            this.nomeData.Size = new System.Drawing.Size(30, 13);
            this.nomeData.TabIndex = 3;
            this.nomeData.Text = "Data";
            this.nomeData.Click += new System.EventHandler(this.nomeData_Click);
            // 
            // nomeDescricao
            // 
            this.nomeDescricao.AutoSize = true;
            this.nomeDescricao.Location = new System.Drawing.Point(51, 110);
            this.nomeDescricao.Name = "nomeDescricao";
            this.nomeDescricao.Size = new System.Drawing.Size(55, 13);
            this.nomeDescricao.TabIndex = 4;
            this.nomeDescricao.Text = "Descrição";
            this.nomeDescricao.Click += new System.EventHandler(this.nomeDescricao_Click);
            // 
            // campoDescricao
            // 
            this.campoDescricao.Location = new System.Drawing.Point(33, 126);
            this.campoDescricao.Name = "campoDescricao";
            this.campoDescricao.Size = new System.Drawing.Size(100, 20);
            this.campoDescricao.TabIndex = 5;
            this.campoDescricao.TextChanged += new System.EventHandler(this.campoDescricao_TextChanged);
            // 
            // nomeCategoria
            // 
            this.nomeCategoria.AutoSize = true;
            this.nomeCategoria.Location = new System.Drawing.Point(51, 156);
            this.nomeCategoria.Name = "nomeCategoria";
            this.nomeCategoria.Size = new System.Drawing.Size(52, 13);
            this.nomeCategoria.TabIndex = 6;
            this.nomeCategoria.Text = "Categoria";
            this.nomeCategoria.Click += new System.EventHandler(this.nomeCategoria_Click);
            // 
            // campoCategoria
            // 
            this.campoCategoria.Location = new System.Drawing.Point(33, 172);
            this.campoCategoria.Name = "campoCategoria";
            this.campoCategoria.Size = new System.Drawing.Size(100, 20);
            this.campoCategoria.TabIndex = 7;
            this.campoCategoria.TextChanged += new System.EventHandler(this.campoCategoria_TextChanged);
            // 
            // nomeFormaDePagamento
            // 
            this.nomeFormaDePagamento.AutoSize = true;
            this.nomeFormaDePagamento.Location = new System.Drawing.Point(30, 205);
            this.nomeFormaDePagamento.Name = "nomeFormaDePagamento";
            this.nomeFormaDePagamento.Size = new System.Drawing.Size(107, 13);
            this.nomeFormaDePagamento.TabIndex = 8;
            this.nomeFormaDePagamento.Text = "Forma de pagamento";
            this.nomeFormaDePagamento.Click += new System.EventHandler(this.nomeFormaDePagamento_Click);
            // 
            // campoFormaDePagamento
            // 
            this.campoFormaDePagamento.Location = new System.Drawing.Point(33, 221);
            this.campoFormaDePagamento.Name = "campoFormaDePagamento";
            this.campoFormaDePagamento.Size = new System.Drawing.Size(100, 20);
            this.campoFormaDePagamento.TabIndex = 9;
            this.campoFormaDePagamento.TextChanged += new System.EventHandler(this.campoFormaDePagamento_TextChanged);
            // 
            // nomeNumeroDeParcelas
            // 
            this.nomeNumeroDeParcelas.AutoSize = true;
            this.nomeNumeroDeParcelas.Location = new System.Drawing.Point(30, 253);
            this.nomeNumeroDeParcelas.Name = "nomeNumeroDeParcelas";
            this.nomeNumeroDeParcelas.Size = new System.Drawing.Size(102, 13);
            this.nomeNumeroDeParcelas.TabIndex = 10;
            this.nomeNumeroDeParcelas.Text = "Número de parcelas";
            // 
            // campoNumeroDeParcelas
            // 
            this.campoNumeroDeParcelas.Location = new System.Drawing.Point(33, 269);
            this.campoNumeroDeParcelas.Name = "campoNumeroDeParcelas";
            this.campoNumeroDeParcelas.Size = new System.Drawing.Size(100, 20);
            this.campoNumeroDeParcelas.TabIndex = 11;
            // 
            // nomeValorPago
            // 
            this.nomeValorPago.AutoSize = true;
            this.nomeValorPago.Location = new System.Drawing.Point(51, 300);
            this.nomeValorPago.Name = "nomeValorPago";
            this.nomeValorPago.Size = new System.Drawing.Size(64, 13);
            this.nomeValorPago.TabIndex = 12;
            this.nomeValorPago.Text = "Valor pago?";
            // 
            // campoValorPago
            // 
            this.campoValorPago.Location = new System.Drawing.Point(33, 316);
            this.campoValorPago.Name = "campoValorPago";
            this.campoValorPago.Size = new System.Drawing.Size(100, 20);
            this.campoValorPago.TabIndex = 13;
            // 
            // botãoAdicionarDespesa
            // 
            this.botãoAdicionarDespesa.Location = new System.Drawing.Point(30, 353);
            this.botãoAdicionarDespesa.Name = "botãoAdicionarDespesa";
            this.botãoAdicionarDespesa.Size = new System.Drawing.Size(107, 23);
            this.botãoAdicionarDespesa.TabIndex = 14;
            this.botãoAdicionarDespesa.Text = "Adicionar despesa";
            this.botãoAdicionarDespesa.UseVisualStyleBackColor = true;
            this.botãoAdicionarDespesa.Click += new System.EventHandler(this.botãoAdicionarDespesa_Click);
            // 
            // AdicionarDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(173, 391);
            this.Controls.Add(this.botãoAdicionarDespesa);
            this.Controls.Add(this.campoValorPago);
            this.Controls.Add(this.nomeValorPago);
            this.Controls.Add(this.campoNumeroDeParcelas);
            this.Controls.Add(this.nomeNumeroDeParcelas);
            this.Controls.Add(this.campoFormaDePagamento);
            this.Controls.Add(this.nomeFormaDePagamento);
            this.Controls.Add(this.campoCategoria);
            this.Controls.Add(this.nomeCategoria);
            this.Controls.Add(this.campoDescricao);
            this.Controls.Add(this.nomeDescricao);
            this.Controls.Add(this.nomeData);
            this.Controls.Add(this.campoData);
            this.Controls.Add(this.campoValor);
            this.Controls.Add(this.nomeValor);
            this.Name = "AdicionarDespesa";
            this.Text = "Despesa";
            this.Load += new System.EventHandler(this.AdicionarDespesa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nomeValor;
        private System.Windows.Forms.TextBox campoValor;
        private System.Windows.Forms.TextBox campoData;
        private System.Windows.Forms.Label nomeData;
        private System.Windows.Forms.Label nomeDescricao;
        private System.Windows.Forms.TextBox campoDescricao;
        private System.Windows.Forms.Label nomeCategoria;
        private System.Windows.Forms.TextBox campoCategoria;
        private System.Windows.Forms.Label nomeFormaDePagamento;
        private System.Windows.Forms.TextBox campoFormaDePagamento;
        private System.Windows.Forms.Label nomeNumeroDeParcelas;
        private System.Windows.Forms.TextBox campoNumeroDeParcelas;
        private System.Windows.Forms.Label nomeValorPago;
        private System.Windows.Forms.TextBox campoValorPago;
        private System.Windows.Forms.Button botãoAdicionarDespesa;
    }
}