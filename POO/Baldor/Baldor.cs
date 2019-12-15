using System; // todos los que dicen system se comunican con el sistema operativo
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baldor
{
    class Baldor
    {
        private String formato;
        private NumberFormatInfo nfi;

        public Baldor() // constructor
        {
            nfi = new NumberFormatInfo();
            nfi.NumberGroupSeparator = ",";
            nfi.NumberDecimalSeparator = ".";

        }

        public String suma(params String[] v) 
 //cuando le pongo param significa que puede recibir desde 0 hasta n parámetros y se almacenará en "v"
        {
            String result = null;
            Double sum = 0;
            Boolean ok = true;
            for (int i = 0; i < v.Length; i++)
            {
                try
                {
                    Double x = Convert.ToDouble(v[i]);
                    sum += x;
                }
                catch (FormatException)
                {
                    ok = false;
                    break;
                }
            }
            if (ok) // si no se hace este if , retornaría null
            {
                result = sum.ToString(((formato != null) ? formato : ""), nfi);
            }
            return result;
        }


        public String resta(String s1, String s2)
        {
            String result = null;
            try
            {
                Double x1 = Convert.ToDouble(s1);
                Double x2 = Convert.ToDouble(s2);
                Double x = x1 - x2;
                result = x.ToString(((formato != null) ? formato : ""), nfi);
            }
            catch (FormatException ex)
            {
            }
            return result;
        }

        public void setFormato(String formato)
        {
            this.formato = formato;
            // uso:
            // baldor.setFormato("#,###,##0.00");
        }



    }
}
