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
    public partial class StatusdeProdução : Form
    {
        public StatusdeProdução()
        {
            InitializeComponent();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StatusPao Prod = new StatusPao();
            Prod.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Statuspaoqueijo Prod = new Statuspaoqueijo();
            Prod.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BoloChocolate Prod = new BoloChocolate();
            Prod.Show();
        }
    }
}