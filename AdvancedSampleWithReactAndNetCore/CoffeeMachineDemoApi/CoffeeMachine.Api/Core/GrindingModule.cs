using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.Api.Core
{
    public class GrindingModule : IModule
    {
        public string Name { get; set; } = "Grinding Module";
        public string Use()
        {
            return "Grinding coffee beans...";
        }
    }

}
