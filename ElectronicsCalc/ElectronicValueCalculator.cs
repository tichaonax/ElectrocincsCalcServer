using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Owin.Extensions;
using Nancy;
using Nancy.Owin;
using Owin;

namespace ElectronicsCalc
{
    public class ElectronicValueCalculator: NancyModule
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseNancy();
            app.UseStageMarker(PipelineStage.MapHandler);
        }

        public ElectronicValueCalculator()
        {
            Get["/"] = x => string.Format("Electronic Calculator Ready");

            Get["/ohms"] = x => string.Format("resistor calculator");

            Get["/farads"] = x => string.Format("capacitor calculator");

            Get["/ohms/{bandAColor}/{bandBColor}/{bandCColor}/{bandDColor}"] = parameters =>
            {
                var bandAColor = parameters.bandAColor;
                var bandBColor = parameters.bandBColor;
                var bandCColor = parameters.bandCColor;
                var bandDColor = parameters.bandDColor;

                var ohmValueCalculator = new OhmValueCalculator();
                return Response.AsJson((ValueData)ohmValueCalculator.CalculateValue(bandAColor, bandBColor, bandCColor, bandDColor));

            };

            Get["/farads/{bandAColor}/{bandBColor}/{bandCColor}/{bandDColor}"] = parameters =>
            {
                var bandAColor = parameters.bandAColor;
                var bandBColor = parameters.bandBColor;
                var bandCColor = parameters.bandCColor;
                var bandDColor = parameters.bandDColor;

                var capacitorValueCalculator = new CapacitorValueCalculator();
                return Response.AsJson((ValueData)capacitorValueCalculator.CalculateValue(bandAColor, bandBColor, bandCColor, bandDColor));

            };
        }

    }
}
