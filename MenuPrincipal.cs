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
            this.Close();
            StatusdeProdução Status = new StatusdeProdução();
            Status.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*TelaCaixa Caixa = new TelaCaixa();
            Caixa.Show();*/
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cadastrocolaborador Funcionario = new Cadastrocolaborador();
            Funcionario.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CadastroCliente Cliente = new CadastroCliente();
            Cliente.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            login Inicio = new login();
            Inicio.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cadastrarprodutos cadastroprodutos = new Cadastrarprodutos();
            cadastroprodutos.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aguardando Atualização.","Aviso", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
