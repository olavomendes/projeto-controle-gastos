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
    }
}
