using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Baldor1
    {
        public String suma(String s1, String s2) //va recibir 2 string
        {
            String result = null;

            try
            {
                double x1 = Convert.ToDouble(s1);
                double x2 = Convert.ToDouble(s2);

                result = "" + (x1 + x2);
            }
            catch (FormatException ex)
            {

                
            }

            return result; //es string para que retorne el texto que va ir en el textbox
        }
    }
}
