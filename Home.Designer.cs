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
            this.SuspendLayout();
            // 
            // acessarConta
            // 
            this.acessarConta.Location = new System.Drawing.Point(713, 12);
            this.acessarConta.Name = "acessarConta";
            this.acessarConta.Size = new System.Drawing.Size(75, 23);
            this.acessarConta.TabIndex = 0;
            this.acessarConta.Text = "Conta";
            this.acessarConta.UseVisualStyleBackColor = true;
            this.acessarConta.Click += new System.EventHandler(this.acessarConta_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.acessarConta);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button acessarConta;
    }
}