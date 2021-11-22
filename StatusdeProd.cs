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
    public partial class StatusdeProdução : Form
    {
        public StatusdeProdução()
        {
            InitializeComponent();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.Close();
            login Inicio = new login();
            Inicio.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StatusPao Prod = new StatusPao();
            Prod.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Statuspaoqueijo Prod = new Statuspaoqueijo();
            Prod.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BoloChocolate Prod = new BoloChocolate();
            Prod.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            TesteStatusDeProducaoUnificado Unificado = new TesteStatusDeProducaoUnificado();
            Unificado.Show();
        }

        private void StatusdeProdução_Load(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }
    }
}