using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElectronicsCalc.Bootstrap;
using Microsoft.Owin.Extensions;
using Nancy.Owin;
using Owin;

namespace ElectronicsCalc
{
    public class StartUp
    {
        public StartUp()
        {    
        }

        public void Configuration(IAppBuilder app)
        {

            app.UseNancy(new NancyOptions
            {
                Bootstrapper = new Bootstrapper()
            });

            app.UseStageMarker(PipelineStage.MapHandler);
        }
    }
}
