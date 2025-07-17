using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeMachineDemo.ConsoleDemo
{
    public interface ICoffeeMachineBuilder
    {
        ICoffeeMachineBuilder AddFeature(IModule module);
        ICoffeeMachine Build();
    }
        
}