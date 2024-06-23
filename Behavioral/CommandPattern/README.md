# Command Design Pattern

The Command Design Pattern is a behavioral design pattern that encapsulates a request as an object, thereby allowing you to parameterize clients with different requests, queue or log requests, and support undoable operations.

## The Command Design Pattern

The Command Design Pattern consists of four main components:

1. **Command**: An interface or abstract class that defines the contract for executing an operation.
2. **Concrete Command**: An implementation of the Command interface that performs a specific operation.
3. **Invoker**: The object that is responsible for invoking the command.
4. **Receiver**: The object that performs the operation when the command is executed.

Here's an example implementation in C#:

```csharp
// Command interface
public interface ICommand
{
    void Execute();
}

// Concrete Command
public class LightOnCommand : ICommand
{
    private Light _light;

    public LightOnCommand(Light light)
    {
        _light = light;
    }

    public void Execute()
    {
        _light.TurnOn();
    }
}

// Invoker
public class RemoteControl
{
    private ICommand _command;

    public void SetCommand(ICommand command)
    {
        _command = command;
    }

    public void PressButton()
    {
        _command.Execute();
    }
}

// Receiver
public class Light
{
    public void TurnOn()
    {
        Console.WriteLine("Light is on.");
    }

    public void TurnOff()
    {
        Console.WriteLine("Light is off.");
    }
}

// Usage
var light = new Light();
var lightOnCommand = new LightOnCommand(light);
var remoteControl = new RemoteControl();
remoteControl.SetCommand(lightOnCommand);
remoteControl.PressButton(); // Output: Light is on.
```

In this example, the `LightOnCommand` is a concrete implementation of the `ICommand` interface, which encapsulates the request to turn on a light. The `RemoteControl` class acts as the invoker, and the `Light` class is the receiver.

## Composite Command

The Composite Command pattern is an extension of the Command pattern, where a single command can represent a group of commands. This allows for the execution of multiple commands as a single unit.

Here's an example implementation in C#:

```csharp
// Composite Command
public class MacroCommand : ICommand
{
    private List<ICommand> _commands = new List<ICommand>();

    public void Add(ICommand command)
    {
        _commands.Add(command);
    }

    public void Execute()
    {
        foreach (var command in _commands)
        {
            command.Execute();
        }
    }
}

// Usage
var light = new Light();
var lightOnCommand = new LightOnCommand(light);
var lightOffCommand = new LightOffCommand(light);

var macroCommand = new MacroCommand();
macroCommand.Add(lightOnCommand);
macroCommand.Add(lightOffCommand);

var remoteControl = new RemoteControl();
remoteControl.SetCommand(macroCommand);
remoteControl.PressButton(); // Turns light on, then off.
```

In this example, the `MacroCommand` class is a composite command that can execute a group of commands.

## Undoable Command

The Undoable Command pattern extends the Command pattern to support undo and redo operations. This involves adding a `Undo()` method to the `ICommand` interface and implementing it in the concrete command classes.

Here's an example implementation in C#:

```csharp
// Undoable Command
public interface IUndoableCommand : ICommand
{
    void Undo();
}

public class LightOnCommand : IUndoableCommand
{
    private Light _light;

    public LightOnCommand(Light light)
    {
        _light = light;
    }

    public void Execute()
    {
        _light.TurnOn();
    }

    public void Undo()
    {
        _light.TurnOff();
    }
}

// Invoker with Undo/Redo support
public class RemoteControl
{
    private IUndoableCommand _currentCommand;
    private Stack<IUndoableCommand> _undoStack = new Stack<IUndoableCommand>();
    private Stack<IUndoableCommand> _redoStack = new Stack<IUndoableCommand>();

    public void SetCommand(IUndoableCommand command)
    {
        _currentCommand = command;
    }

    public void PressButton()
    {
        _currentCommand.Execute();
        _undoStack.Push(_currentCommand);
        _redoStack.Clear();
    }

    public void Undo()
    {
        if (_undoStack.Count > 0)
        {
            var command = _undoStack.Pop();
            command.Undo();
            _redoStack.Push(command);
        }
    }

    public void Redo()
    {
        if (_redoStack.Count > 0)
        {
            var command = _redoStack.Pop();
            command.Execute();
            _undoStack.Push(command);
        }
    }
}

// Usage
var light = new Light();
var lightOnCommand = new LightOnCommand(light);
var remoteControl = new RemoteControl();
remoteControl.SetCommand(lightOnCommand);
remoteControl.PressButton(); // Light is on
remoteControl.Undo(); // Light is off
remoteControl.Redo(); // Light is on
```

In this example, the `LightOnCommand` class implements the `IUndoableCommand` interface, which adds the `Undo()` method. The `RemoteControl` class now manages an undo and redo stack to support these operations.

## When to Use the Command Design Pattern

- When you want to parameterize objects with actions to perform.
- When you want to queue or log requests, or support undoable operations.
- When you need a more flexible alternative to a series of if-else or switch-case statements.

## When Not to Use the Command Design Pattern

- When the actions to be performed are simple and don't require any additional logic or state.
- When you don't need to support undo/redo or other advanced features provided by the Command pattern.

## Similarities and Differences Between Command and State Patterns

Similarities:
- Both patterns encapsulate behavior in an object.
- Both patterns allow for the decoupling of the invoker and the receiver of the behavior.

Differences:
- The Command pattern encapsulates a request, while the State pattern encapsulates the state of an object.
- In the Command pattern, the invoker is responsible for executing the command, while in the State pattern, the context object is responsible for delegating to the appropriate state object.
- The Command pattern is typically used to support undo/redo operations, while the State pattern is used to manage the different states of an object.
- The Command pattern is more focused on the action to be performed, while the State pattern is more focused on the internal state of the object.

## Conclusion

The Command Design Pattern is a powerful tool for encapsulating requests and decoupling the invoker from the receiver. It provides a flexible and extensible way to manage complex sequences of actions, support undo/redo operations, and more. Understanding the Command pattern and its variations, such as Composite Command and Undoable Command, can be a valuable addition to any developer's design pattern toolbox.