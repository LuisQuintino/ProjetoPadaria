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
    public partial class StatusPao : Form
    {
        public StatusPao()
        {
            InitializeComponent();
        }

        private void producaoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.producaoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database_padarianovoDataSet);

        }

        private void producaoBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.producaoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database_padarianovoDataSet);

        }

        private void StatusPao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'database_padarianovoDataSet.producao'. Você pode movê-la ou removê-la conforme necessário.
            this.producaoTableAdapter.Fill(this.database_padarianovoDataSet.producao);
            id_produtoTextBox.Text = "3";
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.producaoTableAdapter.UpdateQueryPaoFrances(data_producaoDateTimePicker.Value, time_producaoDateTimePicker.Value, Convert.ToInt32(qtd_producaoTextBox.Text), kg_producaoCheckBox.Checked, un_producaoCheckBox.Checked, Convert.ToInt32(id_colaboradorTextBox.Text), Convert.ToInt32(id_produtoTextBox.Text));
        }

        private void id_producaoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_producaoLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
