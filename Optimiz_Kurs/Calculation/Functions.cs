using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimiz_Kurs.Calculation
{
    public static class Functions
    {
        public static double f0(double T1, double T2) => (1.0 * (2.0 * 1.0) * (Math.Pow(T1 - T2, 2) + Math.Pow(1.0 * 1.0 - T1, 2))) * 100;

        public static double f1(double T1, double T2) => Math.Pow(T2 - T1, 2) + Math.Pow(T1 + T2 - 10, 2) / 9;
    }
}
