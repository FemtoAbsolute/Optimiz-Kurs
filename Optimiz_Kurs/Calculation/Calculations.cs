using DynamicExpresso;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimiz_Kurs.Calculation
{
    class Calculations
    {
        public DataTable Calculate(double minT1, double minT2, double maxT1, double maxT2, string function, string secondtypecond, double accuracy)
        {
            DataTable table = new DataTable();


            table.Columns.Add("T1", typeof(double));
            table.Columns.Add("T2", typeof(double));
            table.Columns.Add("Value", typeof(double));

            for (double i = minT1; i < maxT1; i+=accuracy)
                for (double j = minT2; j < maxT2; j+=accuracy)
                {
                    if (i+0.5*j <= 1)
                    {
                        double S = 1.0 * (2.0 * 1.0) * (Math.Pow((i - j), 2) + Math.Pow((1.0 * 1.0 - i), 2));
                        table.Rows.Add(Math.Round(i,2), Math.Round(j,2), Math.Round(S*100, 0));
                    }
                }
            return table;
        }
    }
}
