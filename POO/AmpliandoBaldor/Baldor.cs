using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Baldor
{
    class Baldor
    {
        private String formato;
        private NumberFormatInfo nfi;

        public Baldor()
        {
            nfi = new NumberFormatInfo();
            nfi.NumberGroupSeparator = ",";
            nfi.NumberDecimalSeparator = ".";
        }

        public String suma(params String[] v)
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

            if (ok)
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

        public String multiplica(String s1, String s2)
        {
            String result = null;
            try
            {
                Double x1 = Convert.ToDouble(s1);
                Double x2 = Convert.ToDouble(s2);
                Double x = x1 * x2;
                result = x.ToString(((formato != null) ? formato : ""), nfi);
            }
            catch (FormatException ex)
            {
            }

            return result;
        }

        public String divide(String s1, String s2)
        {
            String result = null;
            try
            {
                Double x1 = Convert.ToDouble(s1);
                Double x2 = Convert.ToDouble(s2);
                Double x = x1 / x2;
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
