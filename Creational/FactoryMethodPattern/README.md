# Factory Method Design Pattern

## Introduction
The Factory Method design pattern is a creational pattern that provides an interface for creating objects, but allows subclasses to decide which class to instantiate. This pattern is useful when you need to create objects without exposing the creation logic to the client, and when you want to provide a way to extend the object creation process.

## Explanation
In the Factory Method pattern, a factory class (often called the "creator") is responsible for creating objects of a specific type. The factory class defines a method, called the factory method, that encapsulates the object creation process. Subclasses of the factory class can override the factory method to create objects of a specific type.

The key components of the Factory Method pattern are:

1. **Product**: The interface or abstract class that defines the objects to be created.
2. **ConcreteProduct**: The specific implementation of the Product interface.
3. **Creator**: The abstract class that defines the factory method for creating Product objects.
4. **ConcreteCreator**: The subclass of the Creator that implements the factory method to create ConcreteProduct objects.

## Code Example
Let's consider a web framework example where a controller uses a view engine to render views. We'll use the Factory Method pattern to allow users to create their preferred view engine.

```csharp
// Product
public interface IViewEngine
{
    string RenderView(string viewName, object model);
}

// ConcreteProduct
public class RazorViewEngine : IViewEngine
{
    public string RenderView(string viewName, object model)
    {
        // Implement Razor view rendering logic
        UiSkelton.WriteIndentedText3($"Rendered {viewName} view using {nameof(RazorViewEngine)}");
        return $"Rendered {viewName} view using Razor";
    }
}
public class MustacheViewEngine : IViewEngine
{
    public string RenderView(string viewName, object model)
    {
        // Implement Mustache view rendering logic
        UiSkelton.WriteIndentedText3($"Rendered {viewName} view using {nameof(MustacheViewEngine)}");
        return $"Rendered {viewName} view using Mustache";
    }
}

// Creator
public abstract class ViewEngineFactory
{
    public abstract IViewEngine CreateViewEngine();
}

// ConcreteCreator
public class RazorViewEngineFactory : ViewEngineFactory
{
    public override IViewEngine CreateViewEngine()
    {
        return new RazorViewEngine();
    }
}
public class MustacheViewEngineFactory : ViewEngineFactory
{
    public override IViewEngine CreateViewEngine()
    {
        return new MustacheViewEngine();
    }
}

public class HomeController
{
    private readonly IViewEngine _viewEngine;

    public HomeController(ViewEngineFactory viewEngineFactory)
    {
        UiSkelton.WriteIndentedText2($"{nameof(HomeController)} is asking the view engine factory to create the view engine instance.");
        _viewEngine = viewEngineFactory.CreateViewEngine();
    }

    public string Index()
    {
        var model = new { Message = "Hello, world!" };
        return _viewEngine.RenderView("Index", model);
    }
}```

In this example, the `IViewEngine` interface defines the contract for rendering views, and the `RazorViewEngine` and `MustacheViewEngine` classes implement the specific view rendering logic. The `ViewEngineFactory` abstract class defines the factory method for creating `IViewEngine` instances, and the `RazorViewEngineFactory` and `MustacheViewEngineFactory` classes implement the factory method to create the corresponding view engine instances.

The `HomeController` class uses the `ViewEngineFactory` to create the appropriate `IViewEngine` instance, which it then uses to render the view.

## Usage Examples
Here's how you can use the `HomeController` class with different view engine factories:

```csharp
UiSkelton.DrawHeader("Use FactoryMethodPattern to test the ViewEngine example.");

UiSkelton.WriteIndentedText1("Use the Razor view engine");
var razorViewEngineFactory = new RazorViewEngineFactory();
UiSkelton.WriteIndentedText1("Call Home controller with the Razor view engine");
var homeController = new HomeController(razorViewEngineFactory);
var razorViewResult = homeController.Index(); // "Rendered Index view using Razor"


UiSkelton.WriteIndentedText1("Use the Mustache view engine");
var mustacheViewEngineFactory = new MustacheViewEngineFactory();
UiSkelton.WriteIndentedText1("Call Home controller with the Mustache view engine");
var homeController2 = new HomeController(mustacheViewEngineFactory);
var mustacheViewResult = homeController2.Index(); // "Rendered Index view using Mustache"

UiSkelton.DrawFooter();
```

In this example, we create instances of `HomeController` using different `ViewEngineFactory` implementations to obtain the desired view engine.

## Inheritance and Polymorphism
The Factory Method pattern relies on inheritance and polymorphism to provide flexibility in the object creation process. The `ViewEngineFactory` abstract class defines the interface for creating `IViewEngine` instances, and the `RazorViewEngineFactory` and `MustacheViewEngineFactory` subclasses implement the factory method to create the corresponding view engine instances.

This allows the `HomeController` class to work with different view engine implementations without knowing the specific details of how they are created. The controller only needs to know how to work with the `IViewEngine` interface, and the factory classes handle the object creation process.

## When to Use the Factory Method Pattern
The Factory Method pattern is useful in the following scenarios:

- When you want to create objects without exposing the creation logic to the client.
- When you want to provide a way to extend the object creation process.
- When you have a hierarchy of classes and you want to encapsulate the creation logic in one place.
- When you want to defer the decision of which class to instantiate to the subclasses.

## When Not to Use the Factory Method Pattern
The Factory Method pattern may not be the best choice in the following scenarios:

- When the creation logic is simple and straightforward, and doesn't require any extensibility or customization.
- When you don't anticipate the need to create different types of objects in the future.
- When the object creation process doesn't require any significant complexity or variation.

## Best Practices
When using the Factory Method pattern, consider the following best practices:

1. **Separate creation logic from usage logic**: Ensure that the creation logic is encapsulated in the factory classes, and the client code only interacts with the products through the `IProduct` interface.
2. **Avoid tight coupling**: Design the factory classes and product classes to be as loosely coupled as possible, to maintain flexibility and extensibility.
3. **Use appropriate naming conventions**: Use clear and descriptive names for the factory classes, product classes, and factory methods to improve code readability and maintainability.
4. **Consider using the Abstract Factory pattern**: If you need to create a family of related products, the Abstract Factory pattern might be a more suitable choice.
5. **Ensure thread-safety**: If the factory methods are accessed by multiple threads, ensure that the object creation process is thread-safe.

## Conclusion
The Factory Method design pattern is a powerful tool for creating objects without exposing the creation logic to the client. By leveraging inheritance and polymorphism, the Factory Method pattern provides a flexible and extensible way to create objects, making it easier to introduce new product types or change the creation process without affecting the client code.

The example presented in this README demonstrates how the Factory Method pattern can be applied in a web framework scenario, where different view engine implementations can be used interchangeably by the controller. This flexibility and modularity can be a significant advantage in larger, more complex applications that require dynamic object creation.

By following the best practices outlined in this README, you can effectively incorporate the Factory Method pattern into your C# projects and enjoy the benefits of improved code organization, maintainability, and extensibility.