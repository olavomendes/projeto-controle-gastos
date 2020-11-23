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
using MySql.Data.MySqlClient;

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
            //Home fazerLogin = new Home();
            //this.Hide();
            //fazerLogin.Show();

            MySqlConnection conexao = new MySqlConnection("server=localhost;port=3306;User Id=root;database=teste;password=root");

            var comando = conexao.CreateCommand();

            MySqlCommand query = new MySqlCommand("select count(*) from usuario where usuario = '" + loginUsuario.Text + "' and senha = '" + loginSenha.Text + "'", conexao);
            conexao.Open();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(query);
            da.Fill(dataTable);

            foreach (DataRow list in dataTable.Rows)
            {

                if (Convert.ToInt32(list.ItemArray[0]) > 0)
                {
                    //MessageBox.Show("Usuário válido", "Validacao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Home home = new Home();
                    home.Show();
                
                }
                else
                {
                    MessageBox.Show("Usuário inválido", "Validacao", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            conexao.Close();

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
