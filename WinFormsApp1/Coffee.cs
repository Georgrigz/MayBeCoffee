using System;
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
    public partial class Coffee : Form
    {

        public void formfilling1()
        {
            CoffeeSize1 cf = new CoffeeSize1();
            cf.ShowDialog(this);
            ((UserForm)this.Owner).order += order;
            this.Close();
        }

        public void formfilling2()
        {
            CoffeeSize2 cf = new CoffeeSize2();
            cf.ShowDialog(this);
            ((UserForm)this.Owner).order += order;
            this.Close();
        }

        public void SyrupFilling()
        {
            SyrupForm sf = new SyrupForm();
            sf.ShowDialog(this);
            ((UserForm)this.Owner).order += order;
            this.Close();
        }

        public string order;
        public Coffee()
        {
            InitializeComponent();
        }        

        private void button1_Click(object sender, EventArgs e)
        {
            order += button1.Text;
            ((UserForm)this.Owner).order += order;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            order += button2.Text;
            ((UserForm)this.Owner).order += order;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            order += button3.Text;
            formfilling2();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            order += button4.Text;
            formfilling1();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            order += button5.Text;
            formfilling1();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            order += button7.Text;
            formfilling1();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            order += button8.Text;
            formfilling1();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            order += button12.Text;
            SyrupFilling();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            order += button6.Text;
            formfilling2();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            order += button9.Text;
            formfilling2();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            order += button10.Text;
            formfilling2();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            order += button11.Text;
            formfilling2();
        }
    }
}
