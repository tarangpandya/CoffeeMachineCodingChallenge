using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeMachine.Api.Core
{
    public class WifiModule : IModule
    {
        public string Name { get; set; } = "Wifi Module";

        public string Use()
        {
            return "Connecting to the coffee machine via WiFi...";
        }
    }

}