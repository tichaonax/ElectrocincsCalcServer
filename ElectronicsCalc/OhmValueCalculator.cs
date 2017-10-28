using System;

namespace ElectronicsCalc
{
    public class OhmValueCalculator : IValueCalculator
    {
        ValueMap _firstSignificantValue = new ValueMap(0, 0);
        ValueMap _secondSignificantValue = new ValueMap(0, 0);
        ValueMap _decimalMultiplier = new ValueMap(0, 0);
        string _toleranceValue = "-";

        public ValueData CalculateValue(string bandAColor, string bandBColor, string bandCColor, string bandDColor)
        {
            const int multiplierBase = 10;
            
            ColorCode.ColorCodeMap.TryGetValue(bandAColor, out _firstSignificantValue);
            ColorCode.ColorCodeMap.TryGetValue(bandBColor, out _secondSignificantValue);
            ColorCode.ColorCodeMap.TryGetValue(bandCColor, out _decimalMultiplier);
            Tolerance.ToleranceMap.TryGetValue(bandDColor, out _toleranceValue);
            
            var resistance = ((_firstSignificantValue.Value * multiplierBase) + (_secondSignificantValue.Value));

            if (ValidateInputs())
            {

                return
                    (new ValueData((resistance * (double)Math.Pow(multiplierBase, _decimalMultiplier.Multiplier)),
                        _toleranceValue));
            }
            else
            {
                throw new Exception("Invalid color code combination");
            }
        }

        public bool ValidateInputs()
        {
            return (_firstSignificantValue != null 
                && _secondSignificantValue != null
                && _decimalMultiplier != null
                && _toleranceValue != null);
        }
    }
}
