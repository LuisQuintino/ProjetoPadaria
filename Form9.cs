﻿using System;
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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void maskedTextBox6_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database_padariaDataSet.colaborador' table. You can move, or remove it, as needed.
            this.colaboradorTableAdapter.Fill(this.database_padariaDataSet.colaborador);

        }

        private void colaboradorBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.colaboradorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database_padariaDataSet);
        }

        private void nome_colaboradorTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnanterior_Click(object sender, EventArgs e)
        {
            colaboradorBindingSource.MovePrevious();
        }

        private void btnproximo_Click(object sender, EventArgs e)
        {
            colaboradorBindingSource.MoveNext();
        }

        private void btndeletar_Click(object sender, EventArgs e)
        {
            colaboradorBindingSource.RemoveCurrent();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.colaboradorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database_padariaDataSet);
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            colaboradorBindingSource.AddNew();
        }
    }
}
