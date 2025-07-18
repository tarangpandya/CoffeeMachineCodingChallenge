using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeMachine.Api.Core
{
    public interface IModule
    {
        public string Use();
        public string Name { get; set; }
    }
}