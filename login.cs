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

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database_padariaDataSet.colaborador' table. You can move, or remove it, as needed.
            this.colaboradorTableAdapter.Fill(this.database_padariaDataSet.colaborador);

        }

        private void btnENTRAR_Click_1(object sender, EventArgs e)
        {
            int result = colaboradorTableAdapter.FillByColaboradorLogin(database_padariaDataSet.colaborador, mxtLOGIN.Text, txbSENHA.Text);
            if (result == 1)
            {
                MenuPrincipal menu = new MenuPrincipal();
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
    }
}
