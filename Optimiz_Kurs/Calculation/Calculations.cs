using DynamicExpresso;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimiz_Kurs.Calculation
{
    public class Calculations
    {
        public DataTable Calculate(double minT1, double minT2, double maxT1, double maxT2, Func<double, double, double> function, Func<double, double, bool> restrictions, double accuracy)
        {
            DataTable table = new DataTable();


            table.Columns.Add("T1", typeof(double));
            table.Columns.Add("T2", typeof(double));
            table.Columns.Add("Value", typeof(double));

            for (double i = minT1; i < maxT1; i += accuracy)
                for (double j = minT2; j < maxT2; j += accuracy)
                    if (restrictions(i, j))
                        table.Rows.Add(Math.Round(i, 3), Math.Round(j, 3), Math.Round(function(i, j), 0));
            return table;
        }
    }
}
