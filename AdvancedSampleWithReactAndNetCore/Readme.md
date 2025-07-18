# Coffee Machine Builder Application

This solution consists of two main parts:

1. A .NET Core Web API (Backend)
2. A React + TypeScript UI (Frontend)

## Prerequisites

Before running the application, ensure you have the following installed:

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0) or later
- [Node.js](https://nodejs.org/) (v22 or later)
- [Yarn](https://yarnpkg.com/getting-started/install) (You can install it by running `npm install -g yarn`)
- A code editor (recommended: [Visual Studio Code](https://code.visualstudio.com/) or [Visual Studio](https://visualstudio.microsoft.com/))

## Setup and Running the Application

### Backend (CoffeeMachineDemoApi)

1. Navigate to the API project directory:

   ```bash
   cd AdvancedSampleWithReactAndNetCore/CoffeeMachineDemoApi
   ```

2. Restore the NuGet packages:

   ```bash
   dotnet restore
   ```

3. Build the solution:

   ```bash
   dotnet build
   ```

4. Run the API:
   ```bash
   cd CoffeeMachine.Api
   dotnet run
   ```

The API will start running on `http://localhost:5096` by default.

### Frontend (coffeemachine-demo-ui)

1. Navigate to the UI project directory:

   ```bash
   cd AdvancedSampleWithReactAndNetCore/coffeemachine-demo-ui
   ```

2. Install dependencies:

   ```bash
   yarn install
   ```

3. Start the development server:
   ```bash
   yarn dev
   ```

The UI application will start running on `http://localhost:5173` by default.

## Using the Application

1. Ensure both the backend API and frontend UI are running
2. Open your browser and navigate to `http://localhost:5173`
3. Use the Coffee Machine Builder interface to:
   - Enter a name for your coffee machine
   - Select desired modules (Brewing module is required and pre-selected)
   - Click "Create Coffee Machine" to build your machine

## Features

- Create custom coffee machines with different modules
- Required brewing module (always enabled)
- Optional modules:
  - Grinding Module
  - WiFi Module
- Real-time validation
- Success/Error notifications

## Development

### API Development

- The API is built using .NET Core Web API
- Located in `AdvancedSampleWithReactAndNetCore/CoffeeMachineDemoApi`
- Uses builder pattern for coffee machine construction

### UI Development

- Built with React + TypeScript + Vite
- Located in `AdvancedSampleWithReactAndNetCore/coffeemachine-demo-ui`
- Uses modern React patterns and hooks

## Troubleshooting

### Common Issues

1. **API not running:**

   - Check if the port 5096 is available
   - Ensure .NET SDK is properly installed
   - Try running with `dotnet run --urls "http://localhost:5096"`

2. **UI not connecting to API:**

   - Verify API is running and accessible
   - Check browser console for CORS errors
   - Ensure API URL in UI code matches the running API instance

3. **Node modules issues:**
   - Delete `node_modules` folder and `yarn.lock` file, then run `yarn install` again
   - Ensure Node.js version is compatible
   - Try clearing Yarn cache with `yarn cache clean` if issues persist

For any other issues, please check the respective error logs or create an issue in the repository.
