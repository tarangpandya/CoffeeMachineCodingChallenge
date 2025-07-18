import React, { useState } from 'react';
import './CoffeeMachineDashboard.css';

interface Feature {
  id: string;
  name: string;
  description: string;
}

interface ApiResponse {
  name: string;
  message: string;
  modules: {
    brewing: boolean;
    grinding: boolean;
    wifi: boolean;
  };
}

const MAX_NAME_LENGTH = 20;

const CoffeeMachineDashboard: React.FC = () => {
  const [machineName, setMachineName] = useState('');
  const [selectedFeatures, setSelectedFeatures] = useState<string[]>(['brew']); // Initialize with brewing module
  const [error, setError] = useState<string>('');
  const [successMessage, setSuccessMessage] = useState<string>('');
  const [isCreating, setIsCreating] = useState(false);

  const features: Feature[] = [
    {
      id: 'brew',
      name: 'Brewing Module',
      description: 'Advanced brewing capabilities',
    },
    {
      id: 'grind',
      name: 'Grinding Module',
      description: 'Built-in bean grinding',
    },
    {
      id: 'wifi',
      name: 'WiFi Module',
      description: 'Smart connectivity features',
    },
  ];

  const handleNameChange = (event: React.ChangeEvent<HTMLInputElement>) => {
    setMachineName(event.target.value);
  };

  const handleFeatureToggle = (featureId: string) => {
    // Don't allow deselecting the brewing module
    if (featureId === 'brew') {
      return;
    }

    setSelectedFeatures((prevFeatures) => {
      if (prevFeatures.includes(featureId)) {
        return prevFeatures.filter((id) => id !== featureId);
      }
      return [...prevFeatures, featureId];
    });
  };

  const handleCreateMachine = async () => {
    if (!machineName.trim()) {
      setError('Please enter a machine name');
      return;
    }

    setError('');
    setIsCreating(true);

    try {
      const response = await fetch(
        'http://localhost:5096/api/CoffeeMachineBuilder/create',
        {
          method: 'POST',
          headers: {
            'Content-Type': 'application/json',
          },
          body: JSON.stringify({
            name: machineName,
            hasBrewingModule: selectedFeatures.includes('brew'),
            hasGrindingModule: selectedFeatures.includes('grind'),
            hasWifiModule: selectedFeatures.includes('wifi'),
          }),
        }
      );

      if (!response.ok) {
        throw new Error('Failed to create coffee machine');
      }

      const result: ApiResponse = await response.json();
      setSuccessMessage(result.message);

      // Reset form after successful creation
      setMachineName('');
      setSelectedFeatures(['brew']);
      setError('');

      // Clear success message after 5 seconds
      setTimeout(() => {
        setSuccessMessage('');
      }, 5000);
    } catch (err) {
      setError(
        err instanceof Error ? err.message : 'Failed to create coffee machine'
      );
    } finally {
      setIsCreating(false);
    }
  };

  return (
    <div className="coffee-dashboard">
      <h2>Welcome to your Coffee Machine Builder!</h2>
      <div className="input-group">
        <label htmlFor="machineName">Coffee Machine Name:</label>
        <input
          type="text"
          id="machineName"
          value={machineName}
          onChange={handleNameChange}
          placeholder="Enter machine name"
          className="machine-name-input"
          maxLength={MAX_NAME_LENGTH}
        />
        <div className="input-hint">
          {machineName.length}/{MAX_NAME_LENGTH} characters
        </div>
      </div>

      <div className="features-section">
        <label htmlFor="features">Select Features:</label>
        <div className="features-grid">
          {features.map((feature) => (
            <div key={feature.id} className="feature-item">
              <label className="feature-label">
                <input
                  type="checkbox"
                  checked={selectedFeatures.includes(feature.id)}
                  onChange={() => handleFeatureToggle(feature.id)}
                  disabled={feature.id === 'brew'}
                  className="feature-checkbox"
                />
                <span className="feature-name">{feature.name}</span>
                <span className="feature-description">
                  {feature.description}
                </span>
              </label>
            </div>
          ))}
        </div>
      </div>

      {error && <div className="error-message">{error}</div>}
      {successMessage && (
        <div className="success-message">{successMessage}</div>
      )}

      <button
        onClick={handleCreateMachine}
        disabled={isCreating}
        className="create-button"
      >
        {isCreating ? 'Creating...' : 'Create Coffee Machine'}
      </button>
    </div>
  );
};

export default CoffeeMachineDashboard;
