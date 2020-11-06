using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOS
{
    public partial class Conta : Form
    {
        public Conta()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void contaUsuario_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void campoNomeUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void contaEmail_Click(object sender, EventArgs e)
        {

        }

        private void campoNomeEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void trocarSenha_Click(object sender, EventArgs e)
        {
            TrocarSenha troca = new TrocarSenha();
            troca.Show();
        }

        private void sairConta_Click(object sender, EventArgs e)
        {
            telaLogin sairConta = new telaLogin();
            this.Hide();
            sairConta.Show();

        }
    }
}
