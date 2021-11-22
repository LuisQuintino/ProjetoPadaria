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
    public partial class TesteStatusDeProducaoUnificado : Form
    {
        public TesteStatusDeProducaoUnificado()
        {
            InitializeComponent();
        }

        private void producaoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.producaoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database_padarianovoDataSet);

        }

        private void TesteStatusDeProducaoUnificado_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'database_padarianovoDataSet.produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.database_padarianovoDataSet.produto);
            // TODO: esta linha de código carrega dados na tabela 'database_padarianovoDataSet.produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.database_padarianovoDataSet.produto);
            // TODO: esta linha de código carrega dados na tabela 'database_padarianovoDataSet.producao'. Você pode movê-la ou removê-la conforme necessário.
            this.producaoTableAdapter.Fill(this.database_padarianovoDataSet.producao);

        }

        private void id_colaboradorTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void qtd_producaoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void kg_producaoLabel_Click(object sender, EventArgs e)
        {

        }

        private void kg_producaoCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void un_producaoLabel_Click(object sender, EventArgs e)
        {

        }

        private void un_producaoCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void id_produtoLabel_Click(object sender, EventArgs e)
        {

        }

        private void id_produtoTextBox_TextChanged(object sender, EventArgs e)
        {
            this.produtoTableAdapter.FillByIdProduto(this.database_padarianovoDataSet.produto, Convert.ToInt32(id_produtoTextBox.Text));

        }

        private void qtd_producaoLabel_Click(object sender, EventArgs e)
        {

        }

        private void nome_produtoTextBox_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnproximo_Click(object sender, EventArgs e)
        {
            this.producaoBindingSource.MoveNext();
        }

        private void btnanterior_Click(object sender, EventArgs e)
        {
            this.producaoBindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.producaoTableAdapter.UpdateQueryStatusDeProdu(data_producaoDateTimePicker.Value, time_producaoDateTimePicker.Value, Convert.ToInt32(qtd_producaoTextBox.Text), kg_producaoCheckBox.Checked, un_producaoCheckBox.Checked, Convert.ToInt32(id_colaboradorTextBox.Text), Convert.ToInt32(id_produtoTextBox.Text));

        }

        private void id_producaoTextBox_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
