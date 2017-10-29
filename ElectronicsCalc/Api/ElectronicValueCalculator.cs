using ElectronicsCalc.Capacitance;
using ElectronicsCalc.Models;
using ElectronicsCalc.Ohm;
using Nancy;

namespace ElectronicsCalc.Api
{
    public class ElectronicValueCalculator: NancyModule
    {
        private readonly OhmValueCalculator _ohmValueCalculator;
        private readonly CapacitorValueCalculator _capacitorValueCalculator;
        
        public ElectronicValueCalculator(OhmValueCalculator ohmValueCalculator, CapacitorValueCalculator capacitorValueCalculator)
        {
            _ohmValueCalculator = ohmValueCalculator;
            _capacitorValueCalculator = capacitorValueCalculator;

            Get["/"] = x => string.Format("Electronic Calculator Ready");

            Get["/ohms"] = x => string.Format("resistor calculator");

            Get["/farads"] = x => string.Format("capacitor calculator");

            Get["/ohms/{bandAColor}/{bandBColor}/{bandCColor}/{bandDColor}"] = parameters =>
            {
                var bandAColor = parameters.bandAColor;
                var bandBColor = parameters.bandBColor;
                var bandCColor = parameters.bandCColor;
                var bandDColor = parameters.bandDColor;
                
                return Response.AsJson((ValueData)_ohmValueCalculator.CalculateValue(bandAColor, bandBColor, bandCColor, bandDColor));
            };

            Get["/farads/{bandAColor}/{bandBColor}/{bandCColor}/{bandDColor}"] = parameters =>
            {
                var bandAColor = parameters.bandAColor;
                var bandBColor = parameters.bandBColor;
                var bandCColor = parameters.bandCColor;
                var bandDColor = parameters.bandDColor;
                
                return Response.AsJson((ValueData)_capacitorValueCalculator.CalculateValue(bandAColor, bandBColor, bandCColor, bandDColor));

            };
        }

    }
}
