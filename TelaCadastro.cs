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
        SqlCommand comando;
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

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@usuario", usuarioCadastro.Text);
                comando.Parameters.AddWithValue("@senha", senhaCadastro.Text);
                comando.Parameters.AddWithValue("@email", emailCadastro.Text);


                conexao.Open();
                comando.ExecuteNonQuery(); 
                
            }
            catch(Exception ex) {
                
                MessageBox.Show(ex.Message);

            }
            
            finally {

                conexao.Close();
                conexao = null;
                comando = null;

            }
        }

        private void sairCadastro_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
