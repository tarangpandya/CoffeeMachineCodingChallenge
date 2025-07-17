using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeMachineDemo.ConsoleDemo
{
    public interface IModule
    {
        public void Use();
        public string Name { get; set; }
    }
}