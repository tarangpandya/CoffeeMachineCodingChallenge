using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoffeeMachine.Api.Core;

namespace CoffeeMachine.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CoffeeMachineBuilderController : ControllerBase
    {
        private readonly ICoffeeMachineBuilder coffeeMachineBuilder;

        public CoffeeMachineBuilderController(ICoffeeMachineBuilder coffeeMachineBuilder)
        {
            this.coffeeMachineBuilder = coffeeMachineBuilder;
        }

        [HttpPost("create")]
        public IActionResult CreateCoffeeMachine()
        {
            ICoffeeMachine basicCoffeeMachine = coffeeMachineBuilder
                                               .Build();

            basicCoffeeMachine.Brew();
            return Ok(basicCoffeeMachine.ToString());
        }
    }
}