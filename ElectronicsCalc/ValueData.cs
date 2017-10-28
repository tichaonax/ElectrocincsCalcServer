using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicsCalc
{
    /// <summary>
    /// The return value includes the resistance and the tolerance
    /// Exampbe 100 Ohms +-5%
    /// </summary>
    public class ValueData
    {
        public double Value { get; set; }
        public string Tolerance { get; set; }

        public ValueData(double value, string tolerance)
        {
            Value = value;
            Tolerance = tolerance;
        }

    }
}
