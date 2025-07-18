using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoffeeMachine.Api.Core;
using CoffeeMachine.Api.Models;

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
        public IActionResult CreateCoffeeMachine([FromBody] CreateCoffeeMachineRequest request)
        {
            var builder = coffeeMachineBuilder;

            if (string.IsNullOrEmpty(request.Name))
            {
                return BadRequest("Coffee machine name is required.");
            }

            if (!request.HasBrewingModule)
            {
                return BadRequest("Brewing module is required.");
            }

            if (request.HasGrindingModule)
            {
                builder.AddFeature(new GrindingModule());
            }
            if (request.HasWifiModule)
            {
                builder.AddFeature(new WifiModule());
            }

            ICoffeeMachine coffeeMachine = builder.Build(request.Name);

            return Ok(new
            {
                message = coffeeMachine.ToString(),
            });
        }
    }
}