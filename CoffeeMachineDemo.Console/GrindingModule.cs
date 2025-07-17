using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachineDemo.ConsoleDemo
{
    public class GrindingModule : IModule
    {
        public string Name { get; set; } = "Grinding Module";
        public void Use()
        {
            Console.WriteLine("Grinding coffee beans...");
        }
    }
    
}
