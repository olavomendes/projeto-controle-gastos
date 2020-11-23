namespace SOS
{
    partial class Analise
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.graficoAnalise = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.botaoReceitaDoMes = new System.Windows.Forms.Button();
            this.BotaoLimiteDoCartao = new System.Windows.Forms.Button();
            this.butaoNumeroPrestacao = new System.Windows.Forms.Button();
            this.BotaoValorDasFaturas = new System.Windows.Forms.Button();
            this.botaoValorDaDespesa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.graficoAnalise)).BeginInit();
            this.SuspendLayout();
            // 
            // graficoAnalise
            // 
            chartArea3.Name = "ChartArea1";
            this.graficoAnalise.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.graficoAnalise.Legends.Add(legend3);
            this.graficoAnalise.Location = new System.Drawing.Point(450, 77);
            this.graficoAnalise.Name = "graficoAnalise";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.graficoAnalise.Series.Add(series3);
            this.graficoAnalise.Size = new System.Drawing.Size(300, 300);
            this.graficoAnalise.TabIndex = 0;
            this.graficoAnalise.Text = "Gráfico";
            // 
            // botaoReceitaDoMes
            // 
            this.botaoReceitaDoMes.Location = new System.Drawing.Point(136, 129);
            this.botaoReceitaDoMes.Name = "botaoReceitaDoMes";
            this.botaoReceitaDoMes.Size = new System.Drawing.Size(181, 23);
            this.botaoReceitaDoMes.TabIndex = 1;
            this.botaoReceitaDoMes.Text = "Receita do mês";
            this.botaoReceitaDoMes.UseVisualStyleBackColor = true;
            this.botaoReceitaDoMes.Click += new System.EventHandler(this.botaoReceitaDoMes_Click);
            // 
            // BotaoLimiteDoCartao
            // 
            this.BotaoLimiteDoCartao.Location = new System.Drawing.Point(136, 172);
            this.BotaoLimiteDoCartao.Name = "BotaoLimiteDoCartao";
            this.BotaoLimiteDoCartao.Size = new System.Drawing.Size(181, 23);
            this.BotaoLimiteDoCartao.TabIndex = 2;
            this.BotaoLimiteDoCartao.Text = "Limite do cartão / cartão";
            this.BotaoLimiteDoCartao.UseVisualStyleBackColor = true;
            this.BotaoLimiteDoCartao.Click += new System.EventHandler(this.BotaoLimiteDoCartao_Click);
            // 
            // butaoNumeroPrestacao
            // 
            this.butaoNumeroPrestacao.Location = new System.Drawing.Point(136, 215);
            this.butaoNumeroPrestacao.Name = "butaoNumeroPrestacao";
            this.butaoNumeroPrestacao.Size = new System.Drawing.Size(181, 23);
            this.butaoNumeroPrestacao.TabIndex = 3;
            this.butaoNumeroPrestacao.Text = "Numero de prestação / despesa";
            this.butaoNumeroPrestacao.UseVisualStyleBackColor = true;
            this.butaoNumeroPrestacao.Click += new System.EventHandler(this.butaoNumeroPrestacao_Click);
            // 
            // BotaoValorDasFaturas
            // 
            this.BotaoValorDasFaturas.Location = new System.Drawing.Point(136, 259);
            this.BotaoValorDasFaturas.Name = "BotaoValorDasFaturas";
            this.BotaoValorDasFaturas.Size = new System.Drawing.Size(181, 23);
            this.BotaoValorDasFaturas.TabIndex = 4;
            this.BotaoValorDasFaturas.Text = "Valor das faturas de crédito pagas";
            this.BotaoValorDasFaturas.UseVisualStyleBackColor = true;
            this.BotaoValorDasFaturas.Click += new System.EventHandler(this.BotaoValorDasFaturas_Click);
            // 
            // botaoValorDaDespesa
            // 
            this.botaoValorDaDespesa.Location = new System.Drawing.Point(136, 305);
            this.botaoValorDaDespesa.Name = "botaoValorDaDespesa";
            this.botaoValorDaDespesa.Size = new System.Drawing.Size(181, 23);
            this.botaoValorDaDespesa.TabIndex = 5;
            this.botaoValorDaDespesa.Text = "Valor da despesa";
            this.botaoValorDaDespesa.UseVisualStyleBackColor = true;
            this.botaoValorDaDespesa.Click += new System.EventHandler(this.botaoValorDaDespesa_Click);
            // 
            // Analise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botaoValorDaDespesa);
            this.Controls.Add(this.BotaoValorDasFaturas);
            this.Controls.Add(this.butaoNumeroPrestacao);
            this.Controls.Add(this.BotaoLimiteDoCartao);
            this.Controls.Add(this.botaoReceitaDoMes);
            this.Controls.Add(this.graficoAnalise);
            this.Name = "Analise";
            this.Text = "Análise financeira";
            this.Load += new System.EventHandler(this.analise_Load);
            ((System.ComponentModel.ISupportInitialize)(this.graficoAnalise)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart graficoAnalise;
        private System.Windows.Forms.Button botaoReceitaDoMes;
        private System.Windows.Forms.Button BotaoLimiteDoCartao;
        private System.Windows.Forms.Button butaoNumeroPrestacao;
        private System.Windows.Forms.Button BotaoValorDasFaturas;
        private System.Windows.Forms.Button botaoValorDaDespesa;
    }
}