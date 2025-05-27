using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesarrolloT2
{
    public class Cajero
    {
        public double IngresoMonto(double monto)
        {
            double m = monto;
            if (m < 0)
            {
                return 0.0;
            }
            return m;
        }
    }
}
