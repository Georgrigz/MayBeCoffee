﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class CoffeeSize1 : Form
    {

        public string order;
        public CoffeeSize1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            order += button3.Text;
            ((Coffee)this.Owner).order += " "+order;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            order += button1.Text;
            ((Coffee)this.Owner).order += " " + order;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            order += button2.Text;
            ((Coffee)this.Owner).order += " " + order;
            this.Close();
        }
    }
}
