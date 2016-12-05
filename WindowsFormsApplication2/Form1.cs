using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            double i = double.Parse(num.Text);
            kilobox.Text = i.ToString();
            Box2.Text = (i * 1000).ToString();
            Box3.Text = (i / 1000).ToString();
            Box4.Text = (i * 2.2046).ToString();

        }

        private void kum_CheckedChanged(object sender, EventArgs e)
        {
            double i = double.Parse(num.Text);
            kilobox.Text = (i / 1000).ToString();
            Box2.Text = (i).ToString();
            Box3.Text = (i / 1000000).ToString();
            Box4.Text = (i * 0.0022046).ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tun_CheckedChanged(object sender, EventArgs e)
        {
            double i = double.Parse(num.Text);
            kilobox.Text = (i * 1000).ToString();
            Box2.Text = (i * 1000000).ToString();
            Box3.Text = (i).ToString();
            Box4.Text = (i * 2204.6).ToString();
        }

        private void pon_CheckedChanged(object sender, EventArgs e)
        {
            double i = double.Parse(num.Text);
            kilobox.Text = (i * 0.453592).ToString();
            Box2.Text = (i * 453.59237).ToString();
            Box3.Text = (i * 0.000454).ToString();
            Box4.Text = (i).ToString();
        }
    }
}
