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


namespace EstadoPerdidasGanancias
{
    public partial class Form1 : Form
    {
        private Baldor.Baldor baldor;
        public Form1()
        {
            InitializeComponent();
            baldor = new Baldor.Baldor();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //baldor.setFormato("#,##0.00");
            String r = baldor.resta(textBox1.Text, textBox2.Text);

            String r1 = baldor.resta(r,textBox3.Text);

            String r2 = baldor.IGV(r1); //también puedo enviar como string : "0.18" ó "0,18" ó 0.18.ToString(dependiendo)

            String r3 = baldor.resta(r1,r2);


            
            if (r != null)
            {
                baldor.setFormato("#,##0.00");
                textBox5.Text = r;
            }

            if (r1 != null)
            {
                textBox6.Text = r1;
            }

            if (r2 != null)
            {
                textBox7.Text = r2;
            }

            if (r3 != null)
            {
                textBox4.Text = r3;
            }

            else
            {
                MessageBox.Show("Valores Incorrectos");
            }
        }
    }
}
