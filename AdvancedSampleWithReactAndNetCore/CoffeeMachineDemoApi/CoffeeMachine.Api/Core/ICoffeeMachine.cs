using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.Api.Core
{
    public interface ICoffeeMachine
    {
        string Name { get; }
        string Brew();
        string ToString();
    }
}
