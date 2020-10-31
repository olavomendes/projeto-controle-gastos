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

                // CRIA A CONEXÃO COM O BANCO. LEMBRE-SE DE SUBSTITUIR OS CAMPOS PELOS DADOS
                // DO SEU BANCO LOCAL
                conexao = new SqlConnection("Server=endereco;Database=database;Uid=usuario;Pwd=senha");

                // QUERO PARA INSERIR OS DADOS NO BD LOCAL
                strSQL = "INSERT INTO usuario(nome, senha, email) VALUES (@usuario, @senha, @email)";

                // COMANDO DA CONEXÃO
                comando = new SqlCommand(strSQL, conexao);

                // CAPTURA OS DADOS DIGITADOS PELO USUÁRIO
                comando.Parameters.AddWithValue("@usuario", usuarioCadastro.Text);
                comando.Parameters.AddWithValue("@senha", senhaCadastro.Text);
                comando.Parameters.AddWithValue("@email", emailCadastro.Text);

                // ABRE A CONEXÃO
                conexao.Open();
                // EXECUTA A QUERY
                comando.ExecuteNonQuery(); 
                
            }
            // CAPTURA O ERRO, CASO AJA
            catch(Exception ex) {
                
                MessageBox.Show(ex.Message);

            }

            // APÓS A EXECUÇÃO, FECHA A CONEXÃO E REDEFINE OS VALORES
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
