# Coffee Machine Demo - Unit Tests

This project contains comprehensive unit tests for the Coffee Machine Builder Pattern implementation using xUnit and .NET 9.0.

## Test Coverage

### 1. **CoffeeMachineBuilderTests**

Tests the builder pattern implementation:

- Building coffee machines with different configurations
- Method chaining (fluent interface)
- Builder state reset after building
- Multiple builds from the same builder

### 2. **CoffeeMachineTests**

Tests the core coffee machine functionality:

- Constructor behavior with different module lists
- Brewing functionality with and without brewing module
- Module listing functionality

## Running the Tests

### Using Visual Studio

1. Open the solution in Visual Studio
2. Build the solution (Ctrl+Shift+B)
3. Open Test Explorer (Test → Test Explorer)
4. Click "Run All Tests"

### Using .NET CLI

```bash
# Navigate to the solution directory
cd c:\tarsarena\GitHub\CoffeeMachineCodingChallenge

# Run all tests
dotnet test

# Run tests with detailed output
dotnet test --verbosity normal

# Run tests with coverage
dotnet test --collect:"XPlat Code Coverage"
```

### Using PowerShell

```powershell
# Navigate to the test project directory
Set-Location "c:\tarsarena\GitHub\CoffeeMachineCodingChallenge\CoffeeMachineDemo.Tests"

# Restore packages and run tests
dotnet restore
dotnet test
```
