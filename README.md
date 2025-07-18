# Coffee Machine Builder System

A modular coffee machine management system that demonstrates the Builder design pattern with two different implementations.

## Project Overview

This system allows you to create and manage coffee machines with various modules:

- Required Brewing Module (standard in all machines)
- Optional Grinding Module
- Optional WiFi Module (for smart features)

The system is designed with extensibility in mind, making it easy to add new modules and features in the future.

## Solution Structure

The repository contains two different implementations:

### 1. Basic Console Application

Located in `/BasicSampleWithConsole`

- Demonstrates the core Builder pattern implementation
- Command-line interface
- Written in .NET Core
- Perfect for understanding the basic concepts

### 2. Advanced Web Application

Located in `/AdvancedSampleWithReactAndNetCore`

- Full-stack implementation with modern technologies
- Frontend:
  - React with TypeScript
  - Modern UI components
  - Real-time validation
  - Interactive module selection
- Backend:
  - .NET Core Web API
  - Builder pattern implementation
  - RESTful endpoints
  - Modular architecture

## Key Features

- Modular coffee machine creation
- Flexible component selection
- Extensible architecture
- Clean and maintainable code
- Implementation of Builder design pattern

## Implementation Details

The system uses the Builder pattern to create coffee machines, allowing for:

- Step-by-step construction
- Optional module addition
- Clear separation of concerns
- Easy extensibility for future modules

## Getting Started

Each implementation has its own detailed setup instructions. Please refer to:

- `/BasicSampleWithConsole/README.md` for the console application
- `/AdvancedSampleWithReactAndNetCore/README.md` for the web application

## Design Decisions

1. **Builder Pattern**: Chosen for its flexibility in creating complex objects
2. **Modular Architecture**: Ensures easy addition of new features
3. **Separation of Concerns**: Clear distinction between core logic and presentation
4. **Modern Stack**: Uses current best practices and technologies

## Contributing

Feel free to submit issues, fork the repository, and create pull requests for any improvements.
