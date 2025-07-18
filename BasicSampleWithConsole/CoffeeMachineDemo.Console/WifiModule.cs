using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeMachineDemo.ConsoleDemo
{
    public class WifiModule : IModule
    {
        public string Name { get; set; } = "Wifi Module";

        public void Use()
        {
            Console.WriteLine("Connecting to the coffee machine via WiFi...");
        }
    }

}