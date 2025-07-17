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

### 3. **ModuleTests**

Tests individual modules:

- Interface implementation verification
- Module execution without exceptions
- All module types (Brewing, Grinding, WiFi)

### 4. **IntegrationTests**

End-to-end tests of the complete system:

- Full builder pattern workflow
- Multiple machine configurations
- Independent machine instances
- Fluent interface seamless operation

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

## Test Structure

The tests follow the **Arrange-Act-Assert (AAA)** pattern:

- **Arrange**: Set up test data and dependencies
- **Act**: Execute the method under test
- **Assert**: Verify the expected outcomes

## Key Testing Scenarios

1. **Builder Pattern Validation**

   - Fluent interface method chaining
   - Proper object construction
   - State management between builds

2. **Module Integration**

   - Module addition and execution
   - Different module combinations
   - Module interface compliance

3. **Error Handling**

   - Null input handling
   - Missing module scenarios
   - Exception prevention

4. **Independence Testing**
   - Multiple builder instances
   - Separate machine configurations
   - No shared state between builds

## Dependencies

- **xUnit 2.4.2**: Testing framework
- **Microsoft.NET.Test.Sdk 17.6.0**: Test SDK
- **xunit.runner.visualstudio 2.4.3**: Visual Studio test runner
- **coverlet.collector 6.0.0**: Code coverage collection

## Benefits of This Test Suite

1. **Comprehensive Coverage**: Tests all major components and scenarios
2. **Maintainability**: Clear test structure and naming conventions
3. **Regression Prevention**: Catches breaking changes early
4. **Documentation**: Tests serve as living documentation of expected behavior
5. **Confidence**: Ensures the builder pattern works correctly in all scenarios
