using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO
{
    public partial class Form1 : Form
    {
        private Baldor1 baldor; //privado significa que solo servirá para esta clase

        public Form1()
        {
            InitializeComponent();
            baldor = new Baldor1(); //solicita recurso. principalemnte memoria
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String r = baldor.suma(textBox1.Text, textBox2.Text);

            if (r != null)
            {
                textBox3.Text = r;
            }

            else
            {
                MessageBox.Show("Valores Incorrectos");
            }
        }
    }
}
