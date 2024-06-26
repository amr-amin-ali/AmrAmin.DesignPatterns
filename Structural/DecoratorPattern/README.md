# Decorator Design Pattern

## Introduction
The Decorator design pattern is a structural pattern that allows you to dynamically add new responsibilities to an object without altering its structure. It provides a flexible alternative to subclassing for extending functionality.

## Problem Statement
Imagine we have a `Stream` class that is responsible for writing textual data to storage. Sometimes, we need to write the data in plain text, while other times, we need to write it in an encrypted format or compressed before writing it.

## The Decorator Pattern
The Decorator pattern solves this problem by allowing us to "wrap" the `Stream` class with additional functionality, such as encryption or compression, without modifying the core `Stream` class.

The key components of the Decorator pattern are:

1. **Component**: This is the interface or abstract class that defines the common operations for the objects being decorated. In our case, it would be the `IStream` interface.
2. **Concrete Component**: This is the implementation of the `IStream` interface, which in our case would be the `Stream` class.
3. **Decorator**: This is an abstract class that implements the `IStream` interface and holds a reference to a `Component` object. It forwards requests to the `Component` object and may perform additional operations before or after forwarding the request.
4. **Concrete Decorator**: These are the classes that extend the `Decorator` class and add specific responsibilities, such as `EncryptedStream` and `CompressedStream`.

## Code Example
Here's an example implementation of the Decorator pattern in C# for the `Stream` class:

```csharp
// Component interface
public interface IStream
{
    void Write(string data);
}

// Concrete Component
public class Stream : IStream
{
    public void Write(string data)
    {
        Console.WriteLine($"Writing data: {data}");
    }
}

// Decorator base class
public abstract class StreamDecorator : IStream
{
    protected IStream _stream;

    public StreamDecorator(IStream stream)
    {
        _stream = stream;
    }

    public virtual void Write(string data)
    {
        _stream.Write(data);
    }
}

// Concrete Decorators
public class EncryptedStream : StreamDecorator
{
    public EncryptedStream(IStream stream) : base(stream) { }

    public override void Write(string data)
    {
        string encryptedData = Encrypt(data);
        base.Write(encryptedData);
    }

    private string Encrypt(string data)
    {
        // Implement encryption logic
        return $"Encrypted: {data}";
    }
}

public class CompressedStream : StreamDecorator
{
    public CompressedStream(IStream stream) : base(stream) { }

    public override void Write(string data)
    {
        string compressedData = Compress(data);
        base.Write(compressedData);
    }

    private string Compress(string data)
    {
        // Implement compression logic
        return $"Compressed: {data}";
    }
}

// Usage example
public static void Main()
{
    IStream stream = new Stream();
    stream.Write("Hello, world!");

    IStream encryptedStream = new EncryptedStream(stream);
    encryptedStream.Write("Sensitive data");

    IStream compressedStream = new CompressedStream(stream);
    compressedStream.Write("Large data payload");
}
```

In this example, the `Stream` class is the Concrete Component, and the `StreamDecorator` class is the abstract Decorator. The `EncryptedStream` and `CompressedStream` classes are the Concrete Decorators that add encryption and compression functionality, respectively.

## Favor Composition over Inheritance
The Decorator pattern favors composition over inheritance. Instead of inheriting from the `Stream` class and modifying its behavior, we create new decorator classes that wrap the `Stream` class. This allows us to add or remove responsibilities dynamically, without modifying the core `Stream` class.

## When to Use the Decorator Pattern
The Decorator pattern is useful when you want to add responsibilities to an object dynamically, without affecting other objects of the same class. It's particularly useful when you have a core functionality that needs to be extended in various ways, and you want to avoid the complexity of creating a large inheritance hierarchy.

## When Not to Use the Decorator Pattern
The Decorator pattern may not be the best choice when the number of responsibilities to be added is small or the responsibilities are static. In such cases, a simpler approach, such as inheritance or composition, may be more appropriate.

## Best Practices
1. Ensure that the Decorator and Concrete Decorator classes maintain the same interface as the Component class, so that they can be used interchangeably.
2. Avoid creating a deep hierarchy of Decorators, as it can make the code harder to understand and maintain.
3. Consider using a fluent interface or a builder pattern to make it easier to create complex chains of Decorators.
4. Ensure that the Decorators are applied in the correct order, as the order can affect the final behavior.

## Conclusion
The Decorator design pattern is a powerful and flexible way to add responsibilities to an object dynamically, without modifying its core functionality. By favoring composition over inheritance, the Decorator pattern allows you to create complex and extensible systems with a clean and maintainable codebase.