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
    public partial class TelaCaixa : Form
    {
        public TelaCaixa()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Close();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.label7.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
