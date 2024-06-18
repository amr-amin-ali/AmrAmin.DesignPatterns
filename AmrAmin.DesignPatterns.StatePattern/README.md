# State Pattern in C#
> Programming against interface

## Introduction
The State Pattern is a behavioral design pattern that allows an object to alter its behavior when its internal state changes. In the context of your application, the State Pattern can be used to manage the different tools that can be used on the `Canvas` class.

## Problem Statement
In your application, you have an `ITool` interface with two methods, `MouseUp` and `MouseDown`, that define the behavior of different tools that can be used on a `Canvas` class. You have two concrete implementations of this interface: `BrushTool` and `SelectionTool`. The `Canvas` class needs to be able to use these different tools and their respective behaviors, but it shouldn't have to worry about the implementation details of each tool.

## Solution: State Pattern
The State Pattern can be used to encapsulate the different tool behaviors and make the `Canvas` class more flexible and easier to maintain. Here's how you can implement it:

1. **ITool Interface**:
   ```csharp
   public interface ITool
   {
       void MouseDown();
       void MouseUp();
   }
   ```

2. **Concrete Tool Classes**:
   ```csharp
   public class BrushTool : ITool
   {
       public void MouseDown()
       {
           // Implement Brush tool behavior on mouse down
       }

       public void MouseUp()
       {
           // Implement Brush tool behavior on mouse up
       }
   }

   public class SelectionTool : ITool
   {
       public void MouseDown()
       {
           // Implement Selection tool behavior on mouse down
       }

       public void MouseUp()
       {
           // Implement Selection tool behavior on mouse up
       }
   }
   ```

3. **Canvas Class**:
   ```csharp
   public class Canvas
   {
       private ITool currentTool;

       public void SetTool(ITool tool)
       {
           this.currentTool = tool;
       }

       public void MouseDown()
       {
           this.currentTool.MouseDown();
       }

       public void MouseUp()
       {
           this.currentTool.MouseUp();
       }
   }
   ```

In this implementation, the `Canvas` class has a `currentTool` property that holds the current `ITool` implementation. The `SetTool` method allows the `Canvas` to switch between different tool behaviors, and the `MouseDown` and `MouseUp` methods simply delegate the handling of the events to the current tool.

This approach has several benefits:

1. **Flexibility**: The `Canvas` class doesn't need to know the specific implementation details of each tool. It only needs to know how to interact with the `ITool` interface.
2. **Extensibility**: Adding new tools is easy - you just need to create a new class that implements the `ITool` interface, and the `Canvas` class can start using it.
3. **Maintainability**: If the behavior of a specific tool needs to be changed, you only need to update the corresponding `ITool` implementation, and the `Canvas` class doesn't need to be modified.

## Usage Example
Here's an example of how you can use the `Canvas` class with the different tools:

```csharp
var canvas = new Canvas();

// Set the current tool to the BrushTool
canvas.SetTool(new BrushTool());
canvas.MouseDown();
canvas.MouseUp();

// Set the current tool to the SelectionTool
canvas.SetTool(new SelectionTool());
canvas.MouseDown();
canvas.MouseUp();
```

In this example, the `Canvas` class is able to use the different tool behaviors without needing to know the implementation details of each tool.

## Conclusion
The State Pattern is a powerful design pattern that can help you create more flexible and maintainable code, especially when dealing with different behaviors or states within your application. In the context of your `Canvas` class and tool management, the State Pattern allows you to encapsulate the tool-specific logic and make the `Canvas` class more adaptable to changes and new tool requirements.
And this acheive the `Open-Closed` principle so you can extend the functiona;ity without modifying your existing code.