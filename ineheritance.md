# C# Interface Examples

This project demonstrates various implementations of interfaces in C#, targeting .NET Framework 4.8.

## Examples Included

### 1. Sequential Value Generator (ISeri Interface)
- Demonstrates a simple value generator with increment operations
- Features:
  - `getNext()`: Increments value by 10
  - `getNext2()`: Increments value by 5
  - `Reset()`: Resets to initial value
  - `SetStart()`: Sets a new starting value

### 2. Basic Printer-Scanner (Ip, Is Interfaces)
- Shows basic interface implementation for print and scan operations
- Includes an additional non-interface method `dope()`
- Direct method implementation approach

### 3. Interface Inheritance (Ip, Is Interfaces)
- Demonstrates interface inheritance where Is inherits from Ip
- Implements `Method1()` and `Method7()`
- Shows interface-based reference usage

### 4. Explicit Interface Implementation
- Shows explicit interface implementation technique
- Demonstrates how to handle method name conflicts
- Examples of proper interface casting for method access

## Technical Details
- C# Version: 7.3
- Target Framework: .NET Framework 4.8

## Usage Examples

Each interface implementation includes a corresponding Program class with usage examples. To run different examples, uncomment the desired section and comment out others.

## Notes
- The code includes examples of both implicit and explicit interface implementations
- Demonstrates different interface design patterns and best practices
- Shows proper method access through interface references
