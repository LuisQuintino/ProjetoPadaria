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
    }
}
