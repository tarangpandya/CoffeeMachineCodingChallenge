# Coffee Machine Builder Pattern Demo

This project demonstrates the **Builder Design Pattern** implementation in C# using a coffee machine example. The Builder pattern is a creational design pattern that provides a flexible way to construct complex objects step by step.

## What is the Builder Design Pattern?

The Builder pattern is used to construct complex objects step by step. It allows you to produce different types and representations of an object using the same construction code. Instead of creating objects directly with constructors, the Builder pattern uses a separate builder class to handle the construction process.

## Key Components in This Implementation

### 1. **Product** - `CoffeeMachine`

The complex object being built. It contains multiple modules/features that can be added during construction.

### 2. **Builder Interface** - `ICoffeeMachineBuilder`

Defines the contract for building coffee machines with different features.

```csharp
public interface ICoffeeMachineBuilder
{
    ICoffeeMachineBuilder AddFeature(IModule module);
    ICoffeeMachine Build();
}
```

### 3. **Concrete Builder** - `CoffeeMachineBuilder`

Implements the builder interface and provides the actual construction logic.

### 4. **Modules** - `IModule` implementations

- `BrewingModule` - Core brewing functionality (always included)
- `GrindingModule` - Bean grinding capability
- `WifiModule` - Wireless connectivity feature

## Why Use the Builder Pattern Here?

### 1. **Flexible Object Construction**

The coffee machine can be built with different combinations of features:

```csharp
// Basic coffee machine (brewing only)
ICoffeeMachine basicMachine = coffeeBuilder.Build();

// Coffee machine with grinding
ICoffeeMachine grindingMachine = coffeeBuilder
    .AddFeature(new GrindingModule())
    .Build();

// Advanced machine with multiple features
ICoffeeMachine advancedMachine = coffeeBuilder
    .AddFeature(new WifiModule())
    .AddFeature(new GrindingModule())
    .Build();
```

### 2. **Method Chaining (Fluent Interface)**

The builder returns itself (`return this;`) from each `AddFeature()` call, enabling a fluent, readable syntax.

### 3. **Separation of Concerns**

- The `CoffeeMachine` class focuses on functionality
- The `CoffeeMachineBuilder` class handles construction logic
- Modules are independent and can be mixed and matched

### 4. **Extensibility**

New modules can be easily added without modifying existing code:

```csharp
// Future features could include:
// - MilkFrotherModule
// - TimerModule
// - TemperatureControlModule
```

### 5. **Reusability**

The same builder can create multiple coffee machines with different configurations. The builder resets its state after each `Build()` call.

## Benefits of This Approach

1. **Readable Code**: The fluent interface makes the construction process clear and intuitive
2. **Flexibility**: Easy to create different variations of coffee machines
3. **Maintainability**: Changes to construction logic are isolated in the builder
4. **Testability**: Individual modules and builder steps can be tested independently
5. **Immutable Products**: Once built, the coffee machine's configuration is set
