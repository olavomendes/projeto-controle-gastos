using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOS
{
    public partial class telaLogin : Form
    {
        private string e;

        public telaLogin()
        {
            InitializeComponent();
        }

        private void entrarLogin_Click(object sender, EventArgs e)
        {

        }

        private void SOS_Load(object sender, EventArgs e)
        {

        }

        private void usuario_Click(object sender, EventArgs e)
        {

        }

        private void senha_Click_1(object sender, EventArgs e)
        {

        }

        private void loginCadastro_Click(object sender, EventArgs e)
        {
            TelaCadastro Cadastro = new TelaCadastro();
            Cadastro.Show();
        }

        private void loginUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
