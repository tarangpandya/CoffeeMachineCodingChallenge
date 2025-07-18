using Xunit;
using CoffeeMachineDemo.ConsoleDemo;

namespace CoffeeMachineDemo.Tests
{
    public class CoffeeMachineTests
    {
        [Fact]
        public void Constructor_WithNullModules_ShouldInitializeWithEmptyList()
        {
            var coffeeMachine = new CoffeeMachine(null!);

            // Assert
            Assert.NotNull(coffeeMachine);
        }

        [Fact]
        public void Constructor_WithEmptyModulesList_ShouldInitializeSuccessfully()
        {
            var modules = new List<IModule>();
            var coffeeMachine = new CoffeeMachine(modules);

            // Assert
            Assert.NotNull(coffeeMachine);
        }

        [Fact]
        public void Constructor_WithModules_ShouldInitializeSuccessfully()
        {
            var modules = new List<IModule>
            {
                new BrewingModule(),
                new GrindingModule()
            };
            var coffeeMachine = new CoffeeMachine(modules);

            // Assert
            Assert.NotNull(coffeeMachine);
        }

        [Fact]
        public void Brew_WithBrewingModule_ShouldExecuteSuccessfully()
        {
            var modules = new List<IModule>
            {
                new BrewingModule()
            };
            var coffeeMachine = new CoffeeMachine(modules);
            coffeeMachine.Brew();
        }

        [Fact]
        public void Brew_WithoutBrewingModule_ShouldHandleGracefully()
        {
            var modules = new List<IModule>
            {
                new GrindingModule(),
                new WifiModule()
            };
            var coffeeMachine = new CoffeeMachine(modules);
            coffeeMachine.Brew();
        }

        [Fact]
        public void ListModule_ShouldExecuteWithoutException()
        {
            var modules = new List<IModule>
            {
                new BrewingModule(),
                new GrindingModule(),
                new WifiModule()
            };
            var coffeeMachine = new CoffeeMachine(modules);
            coffeeMachine.ListModule();
        }
    }
}
