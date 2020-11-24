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
    public partial class AdicionarCartao : Form
    {
        public AdicionarCartao()
        {
            InitializeComponent();
        }

        private void numeroCartao_Click(object sender, EventArgs e)
        {

        }

        private void adicionarNumeroCartao_TextChanged(object sender, EventArgs e)
        {

        }

        private void tipoCartao_Click(object sender, EventArgs e)
        {

        }

        private void adicionarTipoCartao_TextChanged(object sender, EventArgs e)
        {

        }

        private void bandeiraCartao_Click(object sender, EventArgs e)
        {

        }

        private void adicionarBandeiraCartao_TextChanged(object sender, EventArgs e)
        {

        }

        private void limiteCartao_Click(object sender, EventArgs e)
        {

        }

        private void adicionarLimiteCartao_TextChanged(object sender, EventArgs e)
        {

        }

        private void valorAtualCartao_Click(object sender, EventArgs e)
        {

        }

        private void adicionarValorAtual_TextChanged(object sender, EventArgs e)
        {

        }

        private void diaFechamentoCartao_Click(object sender, EventArgs e)
        {

        }

        private void adicionarDiaFechamento_TextChanged(object sender, EventArgs e)
        {

        }

        private void butaoAdicionarCartao_Click(object sender, EventArgs e)
        {
            try
            {

                // CRIA A CONEXÃO COM O BANCO. LEMBRE-SE DE SUBSTITUIR OS CAMPOS PELOS DADOS
                // DO SEU BANCO LOCAL
                //conexao = new SqlConnection("Server=localhost;Database=teste;Uid=root;Pwd=root;");

                MySqlConnection conexao = new MySqlConnection("server=localhost;port=3306;User Id=root;database=teste;password=root");
                conexao.Open();

                //MessageBox.Show("Conectado");

                MySqlCommand comando = new MySqlCommand("INSERT INTO cartao (numero, tipo, bandeira, limite, valor_atual) VALUES (?, ?, ?, ?, ?)", conexao);

                comando.Parameters.Add("@numero", MySqlDbType.Double).Value = adicionarNumeroCartao.Text;
                comando.Parameters.Add("@tipo", MySqlDbType.VarChar, 45).Value = adicionarTipoCartao.Text;
                comando.Parameters.Add("@bandeira", MySqlDbType.VarChar, 45).Value = adicionarBandeiraCartao.Text;
                comando.Parameters.Add("@limite", MySqlDbType.Decimal, 45).Value = adicionarLimiteCartao.Text;
                comando.Parameters.Add("@valor_atual", MySqlDbType.Decimal, 45).Value = adicionarValorAtual.Text;
          

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
    }
}
