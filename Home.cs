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
    public partial class Home : Form
    {
        public Home()   
        {
            InitializeComponent();
        }

        private void acessarConta_Click(object sender, EventArgs e)
        {
            Conta entrarConta = new Conta();
            this.Hide();
            entrarConta.Show();

        }

        private void adicionarDespesa_Click(object sender, EventArgs e)
        {
            AdicionarDespesa adicionarDespesa = new AdicionarDespesa();
            adicionarDespesa.Show();
        }

        private void butaoAdicionarCartao_Click(object sender, EventArgs e)
        {
            AdicionarCartao adicionarCartao = new AdicionarCartao();
            adicionarCartao.Show();
        }

        private void analiseDaConta_Click(object sender, EventArgs e)
        {
            Analise entrarAnalise = new Analise();
            entrarAnalise.Show();
        }

        private void entrarDespesa_Click(object sender, EventArgs e)
        {
            Despesas entrarDespesas = new Despesas();
            entrarDespesas.Show();
        }
    }
}
