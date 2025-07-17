using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachineDemo.ConsoleDemo
{
    public class BrewingModule : IModule
    {
        public string Name { get; set; } = "Brewing Module";
        public void Use()
        {
            Console.WriteLine("Brewing coffee...");
        }
    }   
}
