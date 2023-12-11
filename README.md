# Backpropagation Neural Network for AND Gate

## Overview

This project implements a simple Backpropagation Neural Network to learn the logical AND gate using four inputs (A, B, C, D). The neural network is designed to produce the correct result for the AND operation based on the input values. The project is implemented in C# using the Backprop library.

## Project Description

The neural network is trained to perform the AND operation on four input values (A, B, C, D) and produce the corresponding output. The truth table for the AND gate is provided in the code comments.

```plaintext
A   B   C   D   Result (A AND B AND C AND D)
0   0   0   0   0
0   0   0   1   0
0   0   1   0   0
...
1   1   1   1   1
```

## Neural Network Initialization
The neural network is initialized with 4 input nodes, 16 hidden nodes, and 1 output node. The initialization is performed using the _neuralNetworkInitializeButton_Click_ event handler.

```csharp
nn = new NeuralNet(4, 16, 1);
```

## Learning Process
The learning process is triggered by the learnButton_Click event handler. The neural network is trained with different input combinations to learn the AND gate truth table.

```csharp
for (int i = 0; i < 100; i++)  // you can modify your epoch here
{
    // Training cases for different input combinations
    nn.setInputs(...);
    nn.setDesiredOutput(...);
    nn.learn();
    // ...
}
```

## User Interface
The user interface allows users to interact with the neural network. Buttons for each input (A, B, C, D) allow the user to set the input values. The runNeuron method calculates the neural network output based on the current input values.

## How to Use
- Click the "Initialize Neural Network" button to create the neural network.
- Click the "Learn" button to train the network with the AND gate truth table.
- Set individual input values using the corresponding buttons (0 or 1).
- The neural network output is displayed in the UI.

## License
This project is licensed under this developer, please ask for permission to use it.
