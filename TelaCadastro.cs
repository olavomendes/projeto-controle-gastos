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
using MySql.Data.MySqlClient;

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

                // CRIA A CONEXÃO COM O BANCO. LEMBRE-SE DE SUBSTITUIR OS CAMPOS PELOS DADOS
                // DO SEU BANCO LOCAL
                //conexao = new SqlConnection("Server=localhost;Database=teste;Uid=root;Pwd=root;");

                MySqlConnection conexao = new MySqlConnection("server=localhost;port=3306;User Id=root;database=teste;password=root");
                conexao.Open();

                //MessageBox.Show("Conectado");

                MySqlCommand comando = new MySqlCommand("INSERT INTO usuario (usuario, senha, email) VALUES (?, ?, ?)", conexao);

                comando.Parameters.Add("@usuario", MySqlDbType.VarChar, 45).Value = usuarioCadastroCampo.Text;
                comando.Parameters.Add("@senha", MySqlDbType.VarChar, 45).Value = senhaCadastroCampo.Text;
                comando.Parameters.Add("@email", MySqlDbType.VarChar, 45).Value = emailCadastroCampo.Text;

                comando.ExecuteNonQuery();

                conexao.Close();

                
            }
            // CAPTURA O ERRO, CASO AJA
            catch(Exception ex) {
                
                MessageBox.Show(ex.Message);

            }

            // APÓS A EXECUÇÃO, FECHA A CONEXÃO E REDEFINE OS VALORES
            finally {

                //conexao.Close();
                //conexao = null;
                //comando = null;

            }
        }

        private void sairCadastro_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
