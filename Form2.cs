using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PANDOKS_V1._0
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            StatusdeProdução Status = new StatusdeProdução();
            Status.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 Caixa = new Form3();
            Caixa.Show();
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form9 Funcionario = new Form9();
            Funcionario.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form8 Cliente = new Form8();
            Cliente.Show();
        }
    }
}
