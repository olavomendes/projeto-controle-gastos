using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SOS
{
    public partial class TelaCadastro : Form
    {

        SqlConnection conexao;
        SqlCommand commando;
        SqlDataAdapter da;
        SqlDataReader dr;

        string strSQL;
        public TelaCadastro()
        {
            InitializeComponent();
        }

        private void TelaCadastro_Load(object sender, EventArgs e)
        {

        }

        private void usuarioCadastro_Click(object sender, EventArgs e)
        {

        }

        private void senhaCadastro_Click_1(object sender, EventArgs e)
        {

        }

        private void usuarioCadastroCampo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void emailCadastroCampo_TextChanged(object sender, EventArgs e)
        {

        }

        private void senhaCadastroCampo_TextChanged(object sender, EventArgs e)
        {

        }

        private void cadastrarUsuario_Click(object sender, EventArgs e)
        {
            try {

                conexao = new SqlConnection("Server=endereco;Database=database;Uid=usuario;Pwd=senha");
                
                strSQL = "INSERT INTO usuario(nome, senha, email) VALUES (@usuario, @senha, @email)";

                commando = new SqlCommand(strSQL, conexao);

                commando.Parameters.AddWithValue("@usuario", usuarioCadastro.Text);
                commando.Parameters.AddWithValue("@senha", senhaCadastro.Text);
                commando.Parameters.AddWithValue("@email", emailCadastro.Text);


                conexao.Open();
                commando.ExecuteNonQuery(); 
                
            }
            catch(Exception ex) {
                
                MessageBox.Show(ex.Message);

            }
            
            finally {

                conexao.Close();
                commando.Clone();
                conexao = null;
                commando = null;

            }
        }

        private void sairCadastro_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
