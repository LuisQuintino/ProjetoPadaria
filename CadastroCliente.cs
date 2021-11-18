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
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'database_padarianovoDataSet.cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter1.Fill(this.database_padarianovoDataSet.cliente);
            // TODO: esta linha de código carrega dados na tabela 'database_padariaDataSet.cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.database_padariaDataSet.cliente);

        }

        private void clienteBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database_padariaDataSet);
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            this.clienteBindingSource1.AddNew();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.database_padarianovoDataSet);
        }

        private void btndeletar_Click(object sender, EventArgs e)
        {
            clienteBindingSource1.RemoveCurrent();
        }

        private void btnanterior_Click(object sender, EventArgs e)
        {
            clienteBindingSource1.MoveLast();
        }

        private void btnproximo_Click(object sender, EventArgs e)
        {
            clienteBindingSource1.MoveNext();
        }
    }
}
