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
    public partial class Despesas : Form
    {
        public Despesas()
        {
            InitializeComponent();
        }

        private void Despesas_Load(object sender, EventArgs e)
        {
           
        }   

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            MySqlConnection conexao = new MySqlConnection("server=localhost;port=3306;User Id=root;database=teste;password=root");

            var comando = conexao.CreateCommand();

            MySqlCommand query_todas_despesas = new MySqlCommand("select * from despesa", conexao);

            conexao.Open();

            DataTable dataTable = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(query_todas_despesas);
            da.Fill(dataTable);

            dataGridView1.DataSource = dataTable;



            conexao.Close();
        }
    }
}
