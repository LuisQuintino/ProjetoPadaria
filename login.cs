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
    public partial class login : Form
    {

        public login()
        {
            InitializeComponent();
        }
        public string LoginTxtNome
        {
            get { return this.txtNome.Text; }
            set { this.txtNome.Text = value; }
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'database_padarianovoDataSet.colaborador'. Você pode movê-la ou removê-la conforme necessário.
            this.colaboradorTableAdapter1.Fill(this.database_padarianovoDataSet.colaborador);
            // TODO: This line of code loads data into the 'database_padariaDataSet.colaborador' table. You can move, or remove it, as needed.
            this.colaboradorTableAdapter.Fill(this.database_padariaDataSet.colaborador);

        }

        private void btnENTRAR_Click_1(object sender, EventArgs e)
        {
            int result = colaboradorTableAdapter1.FillByLogin(database_padarianovoDataSet.colaborador, mxtLOGIN.Text, txbSENHA.Text);
            if (result == 1)
            {
                MenuPrincipal menu = new MenuPrincipal();
                TelaCaixa tela = new TelaCaixa(this);
                tela.Show();
                menu.Show();
                this.Visible = false;
            }
            else
                MessageBox.Show("Usuário e Senha Invalido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCANCELAR_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txbSENHA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnENTRAR_Click_1(sender, e);
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
