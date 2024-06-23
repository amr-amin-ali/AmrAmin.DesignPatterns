# The Strategy Pattern in C#

## Overview

The Strategy Pattern is a behavioral design pattern that allows you to define a family of algorithms, encapsulate each one, and make them interchangeable. It enables the selection of an algorithm at runtime, without the client code having to know the details of that algorithm.

The key idea behind the Strategy Pattern is to separate the algorithm from the context in which it is used. This provides flexibility, as the algorithm can be changed independently from the code that uses it.


## Intent
The Strategy Pattern "defines a family of algorithms, encapsulates each one, and makes them interchangeable. Strategy lets the algorithm vary independently from clients that use it," as described by the Gang of Four in their book "Design Patterns: Elements of Reusable Object-Oriented Software."

## Applicability
Use the Strategy Pattern when:

1. You have multiple algorithms or behaviors for a particular task, and you want to be able to select the appropriate one at runtime.
2. You have a class with a lot of conditional logic based on the algorithm or behavior being used, and you want to simplify this logic by encapsulating each algorithm or behavior into its own class.
3. The algorithms or behaviors you're using can vary independently from the clients that use them.



## Example: Calculating Shipping Costs

Imagine you have an e-commerce application that needs to calculate shipping costs for various types of products. The shipping cost calculation can vary depending on the product type, delivery location, or other factors.

Here's an example implementation of the Strategy Pattern in C#:

```csharp
// Strategy Interface
public interface IShippingStrategy
{
    double CalculateShippingCost(DeliveryAddress address);
}

// Concrete Strategies
public class ElectronicShippingStrategy : IShippingStrategy
{
    public double CalculateShippingCost(DeliveryAddress address)
    {
        // Logic to calculate shipping cost for electronic products
        return 10.0;
    }
}

public class BookShippingStrategy : IShippingStrategy
{
    public double CalculateShippingCost(DeliveryAddress address)
    {
        // Logic to calculate shipping cost for books
        return 5.0;
    }
}

public class ClothingShippingStrategy : IShippingStrategy
{
    public double CalculateShippingCost(DeliveryAddress address)
    {
        // Logic to calculate shipping cost for clothing
        return 7.5;
    }
}

// Context
public class ShippingCalculator
{
    private IShippingStrategy _shippingStrategy;

    public void SetShippingStrategy(IShippingStrategy strategy)
    {
        _shippingStrategy = strategy;
    }

    public double CalculateShippingCost(DeliveryAddress address)
    {
        return _shippingStrategy.CalculateShippingCost(address);
    }
}
```

In this example:

1. The `IShippingStrategy` interface defines the contract for shipping cost calculation.
2. The concrete `ShippingStrategy` implementations (`ElectronicShippingStrategy`, `BookShippingStrategy`, and `ClothingShippingStrategy`) encapsulate the shipping cost calculation logic for each product type.
3. The `ShippingCalculator` class (the context) holds a reference to the `IShippingStrategy` and delegates the shipping cost calculation to the appropriate strategy.

This approach provides the same benefits as the C# example:

- **Flexibility**: The shipping cost calculation logic can be easily extended or modified by adding new `IShippingStrategy` implementations, without affecting the `ShippingCalculator` class or the client code.
- **Maintainability**: The code is more modular and easier to maintain, as the shipping cost calculation logic is separated from the `ShippingCalculator` class.
- **Testability**: Each `IShippingStrategy` implementation can be tested independently, making the overall system more testable.

## Similarities and Differences between Strategy and State Patterns

The Strategy and State Patterns share some similarities, but they also have distinct differences.

Similarities:
- Both patterns involve the encapsulation of related algorithms or behaviors.
- Both patterns allow the client to switch between different implementations at runtime.
- Both patterns promote the principle of separation of concerns, where the implementation details are hidden from the client.

Differences:
- **Context**: In the Strategy Pattern, the context (e.g., `ShippingCalculator`) holds a reference to the strategy and delegates the execution of the algorithm to the strategy. In the State Pattern, the context (e.g., `Order`) holds a reference to the state and the state itself encapsulates the behavior.
- **Purpose**: The Strategy Pattern is used to encapsulate different algorithms, while the State Pattern is used to encapsulate different states of an object and their corresponding behaviors.
- **State Changes**: In the State Pattern, the context's state can change during the lifetime of the object, while in the Strategy Pattern, the strategy is typically set at the beginning and remains the same throughout the object's lifetime.


- The _Strategy Pattern_ **_focuses on encapsulating different algorithms or behaviors_**, while the _State Pattern_ **_focuses on encapsulating different states_** of an object and the behavior associated with those states.
- In the _Strategy Pattern_, the **_client_** explicitly selects the strategy to use, whereas in the _State Pattern_, the **_object itself_** changes its internal state and the associated behavior.
- The _Strategy Pattern_ is more about interchangeability of algorithms, while the _State Pattern_ is more about managing the different states of an object.
  
  The key difference is that the Strategy Pattern is about choosing an algorithm, while the State Pattern is about managing the state of an object and the associated behavior.



In summary, the Strategy Pattern focuses on encapsulating different algorithms, while the State Pattern focuses on encapsulating different states and their corresponding behaviors. The choice between the two patterns depends on the specific requirements of your application.