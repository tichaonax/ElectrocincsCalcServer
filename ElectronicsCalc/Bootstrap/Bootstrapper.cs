using System.Collections.Generic;
using ElectronicsCalc.Api;
using ElectronicsCalc.Capacitance;
using ElectronicsCalc.Ohm;
using Nancy;
using Nancy.Bootstrapper;
using Nancy.TinyIoc;

namespace ElectronicsCalc.Bootstrap
{
    public class Bootstrapper : DefaultNancyBootstrapper
    {
        protected override IEnumerable<ModuleRegistration> Modules
        {
            get { yield return new ModuleRegistration(typeof(ElectronicValueCalculator)); }
        }

        protected override void ConfigureApplicationContainer(TinyIoCContainer container)
        {
        }

        protected override void ConfigureRequestContainer(TinyIoCContainer container, NancyContext context)
        {
            //manually register all dependancise
            container.Register<OhmValueCalculator>();
            container.Register<CapacitorValueCalculator>();
        }
    }
}
