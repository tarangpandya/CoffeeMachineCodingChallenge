using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.Api.Core
{
    public class CoffeeMachine : ICoffeeMachine
    {
        public CoffeeMachine(List<IModule> modules)
        {
            Modules = modules ?? [];
        }

        private List<IModule>? Modules { get; }

        public string Brew()
        {
            if (Modules == null || !Modules.Any(b => b is BrewingModule))
            {
                return "No brewing feature available. Cannot brew coffee.";
            }

            return "Starting the brewing process...";
        }

        public override string ToString()
        {
            if (Modules == null || !Modules.Any())
                return string.Empty;

            return $"This coffee machine has the following Module: {string.Join(", ", Modules.Select(feature => feature.Name))}";
        }
    }
}
