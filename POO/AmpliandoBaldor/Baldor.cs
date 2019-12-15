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

        public String maximo(params String[] v)
        {
            String result = null;
            Double max = Double.MinValue;
            Boolean ok = true;

            for (int i = 0; i < v.Length; i++)
            {
                try
                {
                    Double x = Convert.ToDouble(v[i]);
                    max = x > max ? x : max; 
                }
                catch (FormatException)
                {
                    ok = false;
                    break;
                }
            }

            if (ok)
            {
                result = max.ToString(((formato != null) ? formato : ""), nfi);
            }

            return result;
        }

        public String minimo(params String[] v)
        {
            String result = null;
            Double min = Double.MaxValue;
            Boolean ok = true;

            for (int i = 0; i < v.Length; i++)
            {
                try
                {
                    Double x = Convert.ToDouble(v[i]);
                    min = x < min ? x : min;
                }
                catch (FormatException)
                {
                    ok = false;
                    break;
                }
            }

            if (ok)
            {
                result = min.ToString(((formato != null) ? formato : ""), nfi);
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
