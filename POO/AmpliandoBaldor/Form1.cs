using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Baldor;

namespace AmpliandoBaldor
{
    public partial class Form1 : Form
    {
        private Baldor.Baldor baldor; //

        public Form1()
        {
            InitializeComponent();//
            baldor = new Baldor.Baldor();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string r = baldor.maximo(textBox1.Text, textBox2.Text,textBox3.Text);

            if (r != null)
            {
                textBox4.Text = r;
            }
            else
            {
                MessageBox.Show("Valores incorrectos!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string r = baldor.suma(textBox1.Text, textBox2.Text, textBox3.Text);
            string r1 = baldor.divide(r,"3");
            if (r != null)
            {
                textBox4.Text = r1;
            }
            else
            {
                MessageBox.Show("Valores incorrectos!");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string r = baldor.minimo(textBox1.Text, textBox2.Text, textBox3.Text);

            if (r != null)
            {
                textBox4.Text = r;
            }
            else
            {
                MessageBox.Show("Valores incorrectos!");
            }
        }
    }
}
