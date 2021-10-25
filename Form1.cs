using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PADARIA
{
    public partial class Form1 : Form
    {
        String usuario, senha;

        public Form1()
        {
            InitializeComponent();

            usuario = Properties.Settings.Default.Usuario;
            senha = Properties.Settings.Default.Senha;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtUsuario.Text == usuario && txtSenha.Text == senha)
                    {
                        MessageBox.Show(" Usuário e Senha Corretas");
                    }
                else
                    {
                        MessageBox.Show(" Usuário e Senha Incorretas");
                    }
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao finalizar o programa", "MENSAGEM IMPORTANTE");
                throw;
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
