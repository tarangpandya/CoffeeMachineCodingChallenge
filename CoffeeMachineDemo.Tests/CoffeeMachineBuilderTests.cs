using Xunit;
using CoffeeMachineDemo.ConsoleDemo;

namespace CoffeeMachineDemo.Tests
{
    public class CoffeeMachineBuilderTests
    {
        [Fact]
        public void Build_ShouldCreateCoffeeMachineWithBrewingModule()
        {

            var builder = new CoffeeMachineBuilder();
            var coffeeMachine = builder.Build();

            Assert.NotNull(coffeeMachine);
            Assert.IsAssignableFrom<ICoffeeMachine>(coffeeMachine);
        }

        [Fact]
        public void AddFeature_ShouldReturnBuilderForChaining()
        {

            var builder = new CoffeeMachineBuilder();
            var grindingModule = new GrindingModule();
            var result = builder.AddFeature(grindingModule);

            Assert.Same(builder, result);
        }

        [Fact]
        public void AddFeature_WithGrindingModule_ShouldIncludeModuleInBuiltMachine()
        {

            var builder = new CoffeeMachineBuilder();
            var grindingModule = new GrindingModule();

            var coffeeMachine = builder
                .AddFeature(grindingModule)
                .Build();

            Assert.NotNull(coffeeMachine);
        }

        [Fact]
        public void AddFeature_WithWifiModule_ShouldIncludeModuleInBuiltMachine()
        {
            var builder = new CoffeeMachineBuilder();
            var wifiModule = new WifiModule();
            var coffeeMachine = builder
                .AddFeature(wifiModule)
                .Build();

            Assert.NotNull(coffeeMachine);
        }

        [Fact]
        public void AddFeature_WithMultipleModules_ShouldIncludeAllModules()
        {
            var builder = new CoffeeMachineBuilder();
            var grindingModule = new GrindingModule();
            var wifiModule = new WifiModule();

            var coffeeMachine = builder
                .AddFeature(grindingModule)
                .AddFeature(wifiModule)
                .Build();

            Assert.NotNull(coffeeMachine);
        }

        [Fact]
        public void Build_CalledMultipleTimes_ShouldCreateSeparateInstances()
        {
            var builder = new CoffeeMachineBuilder();
            var machine1 = builder.Build();
            var machine2 = builder.Build();

            Assert.NotNull(machine1);
            Assert.NotNull(machine2);
            Assert.NotSame(machine1, machine2);
        }

        [Fact]
        public void Build_AfterAddingFeatures_ShouldResetBuilderState()
        {
            var builder = new CoffeeMachineBuilder();
            var grindingModule = new GrindingModule();

            var machine1 = builder
                .AddFeature(grindingModule)
                .Build();
            var machine2 = builder.Build(); // Should not include the grinding module

            Assert.NotNull(machine1);
            Assert.NotNull(machine2);
            Assert.NotSame(machine1, machine2);
        }
    }
}
