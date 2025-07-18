using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeMachine.Api.Core
{
    public interface ICoffeeMachineBuilder
    {
        ICoffeeMachineBuilder AddFeature(IModule module);
        ICoffeeMachine Build(string name);
    }
}