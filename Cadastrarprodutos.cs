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
    public partial class Cadastrarprodutos : Form
    {
        public Cadastrarprodutos()
        {
            InitializeComponent();
        }


        private void Cadastrarprodutos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'database_padarianovoDataSet.produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter1.Fill(this.database_padarianovoDataSet.produto);
            // TODO: esta linha de código carrega dados na tabela 'database_padariaDataSet.produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.database_padariaDataSet.produto);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if ( Convert.ToInt32(id_produtoTextBox.Text) > 0)
            {
                openFileDialog1.ShowDialog();
                Bitmap bmp = new Bitmap(openFileDialog1.FileName);
                Bitmap bmp2 = new Bitmap(bmp, pictureBox1.Size);
                pictureBox1.Image = bmp2;
                pictureBox1.Image.Save(Application.StartupPath.ToString() + "\\imagensprodutos\\" + id_produtoTextBox.Text + ".png", System.Drawing.Imaging.ImageFormat.Png);
                img_produtoTextBox.Text = Application.StartupPath.ToString() + "\\imagensprodutos\\" + id_produtoTextBox.Text + ".png";
                this.Validate();
                this.produtoBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.database_padariaDataSet);
            }
            else
            {
                MessageBox.Show("Salve primeiro o produto para depois inserir a imagem", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void produtoBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.produtoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database_padariaDataSet);

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            if (Convert.ToInt32(id_produtoTextBox.Text) > 0)
            {
                openFileDialog1.ShowDialog();
                Bitmap bmp = new Bitmap(openFileDialog1.FileName);
                Bitmap bmp2 = new Bitmap(bmp, pictureBox1.Size);
                pictureBox1.Image = bmp2;
                pictureBox1.Image.Save(Application.StartupPath.ToString() + "\\imagensprodutos\\" + id_produtoTextBox.Text + ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
                img_produtoTextBox.Text = Application.StartupPath.ToString() + "\\imagensprodutos\\" + id_produtoTextBox.Text + ".jpeg";
                this.Validate();
                this.produtoBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.database_padariaDataSet);
            }
            else
            {
                MessageBox.Show("Salve primeiro o produto para depois inserir a imagem", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
