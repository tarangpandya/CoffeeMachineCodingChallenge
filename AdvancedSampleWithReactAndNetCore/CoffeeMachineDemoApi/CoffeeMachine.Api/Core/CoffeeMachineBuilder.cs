using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.Api.Core
{
    public class CoffeeMachineBuilder : ICoffeeMachineBuilder
    {
        public CoffeeMachineBuilder()
        {
            ResetFeatures();
        }

        public List<IModule> Modules { get; private set; } = new List<IModule>();

        private void ResetFeatures()
        {
            Modules = new List<IModule>();
        }

        public ICoffeeMachineBuilder AddFeature(IModule module)
        {
            Modules.Add(module);
            return this;
        }

        public ICoffeeMachine Build(string name)
        {
            IModule brewingFeature = new BrewingModule();
            Modules.Add(brewingFeature);
            ICoffeeMachine coffeeMachine = new CoffeeMachine(name, Modules);
            ResetFeatures(); // Reset features for the next build
            return coffeeMachine;
        }
    }
}
