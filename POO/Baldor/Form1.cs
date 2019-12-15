using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baldor
{
    public partial class Form1 : Form
    {
        private Baldor baldor; //declararlo a nivel de clase

        public Form1()
        {
            InitializeComponent();
            baldor = new Baldor(); // se instancia en el constructor
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baldor.setFormato("#,###,##0.00");
            //string r = baldor.suma("1200","1300","1000");
            //string[] v = { "1200", "1300", "1000" };
            string[] v = new string[10000]; //la suma de los primeros 1000 valores

            for (int i = 0; i < v.Length; i++)
            {
                v[i] = "" + i;
            }


            string r = baldor.suma(v);

            if (r != null)
            {
                textBox1.Text = r;
            }
            else
            {
                MessageBox.Show("Valores incorrectos!");
            }
        }
    }
}
