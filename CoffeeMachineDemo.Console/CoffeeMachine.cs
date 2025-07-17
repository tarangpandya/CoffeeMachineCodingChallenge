using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachineDemo.ConsoleDemo
{
    public class CoffeeMachine : ICoffeeMachine
    {
        public CoffeeMachine(List<IModule> modules)
        {
                Modules = modules ?? [];
        }

        private List<IModule>? Modules { get; }

        public void Brew()
        {
            if (Modules == null || !Modules.Any(b => b is BrewingModule))
            {
                Console.WriteLine("No brewing feature available. Cannot brew coffee.");
                return;
            }

            Console.WriteLine("Starting the brewing process...");
        }

        public void ListModule()
        {
            Console.WriteLine("This coffee machine has the following Module:");
            Modules?.ForEach(feature => Console.WriteLine($"- {feature.Name}"));
        }
    }
}
