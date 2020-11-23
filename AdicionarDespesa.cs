using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace SOS
{
    public partial class AdicionarDespesa : Form
    {
        public AdicionarDespesa()
        {
            InitializeComponent();
        }

        private void nomeValor_Click(object sender, EventArgs e)
        {

        }

        private void campoValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void nomeData_Click(object sender, EventArgs e)
        {

        }

        private void campoData_TextChanged(object sender, EventArgs e)
        {

        }

        private void nomeDescricao_Click(object sender, EventArgs e)
        {

        }

        private void campoDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void nomeCategoria_Click(object sender, EventArgs e)
        {

        }

        private void campoCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void nomeFormaDePagamento_Click(object sender, EventArgs e)
        {

        }

        private void campoFormaDePagamento_TextChanged(object sender, EventArgs e)
        {

        }

        private void botãoAdicionarDespesa_Click(object sender, EventArgs e)
        {
            try
            {

                // CRIA A CONEXÃO COM O BANCO. LEMBRE-SE DE SUBSTITUIR OS CAMPOS PELOS DADOS
                // DO SEU BANCO LOCAL
                //conexao = new SqlConnection("Server=localhost;Database=teste;Uid=root;Pwd=root;");

                MySqlConnection conexao = new MySqlConnection("server=localhost;port=3306;User Id=root;database=teste;password=root");
                conexao.Open();

                //MessageBox.Show("Conectado");

                MySqlCommand comando = new MySqlCommand("INSERT INTO despesa (valor, categoria, forma_pagamento, numero_parcelas, status_pagamento) VALUES (?, ?, ?, ?, ?)", conexao);

                comando.Parameters.Add("@valor", MySqlDbType.Int32).Value = campoValor.Text;
                //comando.Parameters.Add("@data", MySqlDbType.DateTime).Value = campoData.Text;
                comando.Parameters.Add("@categoria", MySqlDbType.VarChar, 45).Value = campoCategoria.Text;
                comando.Parameters.Add("@forma_pagamento", MySqlDbType.VarChar, 45).Value = campoFormaDePagamento.Text;
                comando.Parameters.Add("@numero_parcelas", MySqlDbType.VarChar, 45).Value = campoNumeroDeParcelas.Text;
                comando.Parameters.Add("@status_pagamento", MySqlDbType.Bit, 1).Value = campoValorPago.Text;
                
                comando.ExecuteNonQuery();

                conexao.Close();


            }
            // CAPTURA O ERRO, CASO AJA
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

            // APÓS A EXECUÇÃO, FECHA A CONEXÃO E REDEFINE OS VALORES
            finally
            {

                //conexao.Close();
                //conexao = null;
                //comando = null;

            }
        }

        private void AdicionarDespesa_Load(object sender, EventArgs e)
        {

        }
    }
}
