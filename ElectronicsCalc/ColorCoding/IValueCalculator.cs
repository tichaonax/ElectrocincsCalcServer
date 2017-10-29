using ElectronicsCalc.Models;

namespace ElectronicsCalc.ColorCoding
{
    /// <summary>
    /// Interface, possible future functionality to support capacitor color-coding
    ///  
    /// 1.	Resistor color-coding
    /// 2.	Capacitor color-coding
    /// 
    /// </summary>

    public interface IValueCalculator
    {
        /// <summary>

        /// Calculates the component value based on the band colors.

        /// </summary>

        /// <param name="bandAColor">The color of the first figure of component value band.</param>

        /// <param name="bandBColor">The color of the second significant figure band.</param>

        /// <param name="bandCColor">The color of the decimal multiplier band.</param>

        /// <param name="bandDColor">The color of the tolerance value band.</param>

        ValueData CalculateValue(string bandAColor, string bandBColor, string bandCColor, string bandDColor);

        bool ValidateInputs();
    }
}
