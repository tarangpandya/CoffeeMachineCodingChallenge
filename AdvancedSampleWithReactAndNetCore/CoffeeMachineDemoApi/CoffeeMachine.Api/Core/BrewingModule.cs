using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.Api.Core
{
    public class BrewingModule : IModule
    {
        public string Name { get; set; } = "Brewing Module";
        public string Use()
        {
            return "Brewing coffee...";
        }
    }
}
