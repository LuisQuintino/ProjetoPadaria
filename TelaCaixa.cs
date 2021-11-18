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
        float valortotal = 0, valorunittotal = 0;
        public TelaCaixa()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'database_padarianovoDataSet.produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter1.Fill(this.database_padarianovoDataSet.produto);
            // TODO: esta linha de código carrega dados na tabela 'database_padariaDataSet.produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.database_padariaDataSet.produto);

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
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
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

        private void produtoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.produtoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database_padariaDataSet);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "";

                }
                else
                {
                    //this.produtoTableAdapter.FillByIdProduto(this.database_padariaDataSet.produto, Convert.ToInt32(textBox1.Text));
                    this.produtoTableAdapter1.FillByIdProduto(this.database_padarianovoDataSet.produto, Convert.ToInt32(textBox1.Text));
                }
                

            }
            catch (Exception)
            {
                MessageBox.Show("Insira um código de barras válido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                txtValorUnit.Text = "0";
            }
        }

        private void txtValorTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQtd_TextChanged(object sender, EventArgs e)
        {
            /*int qtd, valorunit, valortotal;
            if (txtQtd.Text == "")
            {
                
                qtd = Convert.ToInt32(txtQtd.Text);
                valorunit = Convert.ToInt32(txtValorUnit.Text);
                if (qtd >= 1)
                {
                    valortotal = qtd * valorunit;
                    txtValorTotal.Text = valortotal.ToString();
                }
            }*/
           
        }

        private void txtnmproduto_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                txtnmproduto.Text = "";
            }
        }

        private void btnfecharvenda_Click(object sender, EventArgs e)
        {
            txtValorFinal.Text = txtValorTotal.Text;
            lbcupom.Items.Add("A sua compra fechou em R$" + txtValorTotal.Text + " Reais");
        }

        private void txtcancelarvenda_Click(object sender, EventArgs e)
        {
            lbcupom.Items.Clear();
            txtValorTotal.Text = "";
            txtnmproduto.Text = "";
            txtQtd.Text = "";
            txtValorUnit.Text = "";
            txtValorFinal.Text = "";
            textBox1.Text = "";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnadcproduto_Click(sender, e);
            }
        }

        private void cancelaritem_Click(object sender, EventArgs e)
        {
            lbcupom.Items.Remove(lbcupom.SelectedItem);
        }

        private void pesqproduto_Click(object sender, EventArgs e)
        {
            PesquisarProduto pesq = new PesquisarProduto();
            pesq.Show();
        }

        private void btnadcproduto_Click(object sender, EventArgs e)
        {
            float qtd, valorunit;
            if (txtQtd.Text == "")
            {
                txtQtd.Text = "1";
                qtd = 1;
                valorunit = float.Parse(txtValorUnit.Text);
                valortotal += ( valorunit * qtd);
                valorunittotal = (valorunit * qtd);
                txtValorTotal.Text = valortotal.ToString();
                lbcupom.Items.Add("* " + txtnmproduto.Text + " Quantidade -> " + txtQtd.Text + "; Valor unitario total ->" + valorunittotal.ToString());
            }
            else
            {
                qtd = float.Parse(txtQtd.Text);
                valorunit = float.Parse(txtValorUnit.Text);
                valortotal += (valorunit * qtd);
                valorunittotal = (valorunit * qtd);
                txtValorTotal.Text = valortotal.ToString();
                lbcupom.Items.Add("* " + txtnmproduto.Text + " Quantidade -> " + txtQtd.Text + "; Valor unitario total ->" + valorunittotal.ToString());
            }
        }
    }
}
