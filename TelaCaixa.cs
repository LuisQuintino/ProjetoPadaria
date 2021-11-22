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
        float valortotal = 0, valorunittotal = 0, qtdtotal = 0;
        Timer t = new Timer();
        login logincompartilhado = null;
        
        public TelaCaixa()
        {
            InitializeComponent();
        }
        public TelaCaixa(login teste)
        {
            logincompartilhado = teste;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'database_padarianovoDataSet.produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter1.Fill(this.database_padarianovoDataSet.produto);
            // TODO: esta linha de código carrega dados na tabela 'database_padariaDataSet.produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.database_padariaDataSet.produto);
            t.Interval = 1000;
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();
            txtNomeOperador.Text = logincompartilhado.LoginTxtNome;
            
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {
            button23.Enabled = false;
            Application.Exit();
            Close();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            this.Close();
            login Inicio = new login();
            Inicio.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            
           //this.label7.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        private void t_Tick(object sender, EventArgs e)
        {
            //get current time
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            //time
            string time = "";

            //padding leading zero
            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":";

            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";

            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }

            //update label
            label7.Text = time;
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
            txtValorUnit.Enabled = false;
            txtValorUnit.ReadOnly = true;
            if (textBox1.Text == "")
            {
                txtValorUnit.Text = "0";
            }
        }

        private void txtValorTotal_TextChanged(object sender, EventArgs e)
        {
            txtValorTotal.Enabled = false;
            txtValorTotal.ReadOnly = true;
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
            txtnmproduto.Enabled = false;
            txtnmproduto.ReadOnly = true;
            if (textBox1.Text == "")
            {
                txtnmproduto.Text = "";
            }
        }

        private void btnfecharvenda_Click(object sender, EventArgs e)
        {
            txtValorFinal.Text = Convert.ToString(valortotal);
            txtTotalQtd.Text = qtdtotal.ToString();
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
            txtTotalQtd.Text = "";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

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

        private void TelaCaixa_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                pesqproduto_Click(sender, e);
            }
            if (e.KeyCode == Keys.Enter)
            {
                btnadcproduto_Click(sender, e);
            }
            if (e.KeyCode == Keys.F8)
            {
                cancelaritem_Click(sender, e);
            }
            if (e.KeyCode == Keys.F11)
            {
                txtcancelarvenda_Click(sender, e);
            }
            if(e.KeyCode == Keys.F10)
            {
                btnfecharvenda_Click(sender, e);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            txtTotalQtd.Enabled = false;
        }

        private void button22_Click(object sender, EventArgs e)
        {
        }

        private void txtValorFinal_TextChanged(object sender, EventArgs e)
        {
            txtValorFinal.Enabled = false;
        }

        private void lbcupom_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbcupom.Enabled = false;
        }

        private void txtNomeOperador_TextChanged(object sender, EventArgs e)
        {
            txtNomeOperador.Enabled = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnadcproduto_Click(object sender, EventArgs e)
        {
            float qtd, valorunit;
            try
            {
            if (txtQtd.Text == "")
            {
                txtQtd.Text = "1";
                qtd = 1;
                valorunit = float.Parse(txtValorUnit.Text);
                valortotal += ( valorunit * qtd);
                valorunittotal = (valorunit * qtd);
                qtdtotal++;
                txtValorTotal.Text = valorunittotal.ToString();
                lbcupom.Items.Add("* " + txtnmproduto.Text + " Quantidade -> " + txtQtd.Text + "; Valor unitario total ->" + valorunittotal.ToString());
                
            }
            else
            {
                qtd = float.Parse(txtQtd.Text);
                valorunit = float.Parse(txtValorUnit.Text);
                valortotal += (valorunit * qtd);
                valorunittotal = (valorunit * qtd);
                qtdtotal = qtdtotal + qtd;
                txtValorTotal.Text = valorunittotal.ToString();
                lbcupom.Items.Add("* " + txtnmproduto.Text + " Quantidade -> " + txtQtd.Text + "; Valor unitario total ->" + valorunittotal.ToString());
            }
            }
            catch (Exception)
            {
                MessageBox.Show("Insira um código de barras  válido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
