// See https://aka.ms/new-console-template for more information
using CoffeeMachineDemo.ConsoleDemo;

ICoffeeMachineBuilder coffeeBuilder = new CoffeeMachineBuilder();


ICoffeeMachine basicCoffeeMachine = coffeeBuilder
                                    .Build();
basicCoffeeMachine.ListModule();
basicCoffeeMachine.Brew();


ICoffeeMachine coffeeMachine = coffeeBuilder
                                .AddFeature(new GrindingModule())
                                .Build();
coffeeMachine.ListModule();
coffeeMachine.Brew();

ICoffeeMachine coffeeMachineWithWifi = coffeeBuilder
                                        .AddFeature(new WifiModule())
                                        .Build();
coffeeMachineWithWifi.ListModule();
coffeeMachineWithWifi.Brew();


ICoffeeMachine mostAdvancedCoffeeMachine = coffeeBuilder
                                        .AddFeature(new WifiModule())
                                        .AddFeature(new GrindingModule())
                                        .Build();
mostAdvancedCoffeeMachine.ListModule();
mostAdvancedCoffeeMachine.Brew();