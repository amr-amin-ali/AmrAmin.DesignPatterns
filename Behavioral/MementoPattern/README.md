# AmrAmin.DesignPatterns.MementoPattern
## Design pattern for the undo mechanism
# Memento Pattern in C#

The Memento Pattern is a behavioral design pattern that allows an object to capture and externalize its internal state, so that the object can be restored to this state later, without violating encapsulation. This pattern is particularly useful when you need to provide undo/redo functionality in an application.

## Problem

Imagine you have a C# application where users can perform various actions that modify the state of an object. Over time, the object's state can become complex, with many interdependent variables. If the user wants to undo or redo their actions, you need a way to capture and restore the object's state without exposing its internal implementation details.

Directly exposing the object's internal state to the user or to other parts of the application would violate the principle of encapsulation, which is a fundamental tenet of object-oriented programming. Encapsulation helps to hide the internal implementation details of an object and provides a well-defined interface for interacting with the object.

## Solution

The Memento Pattern introduces three key roles:

1. **Originator**: The object whose state needs to be captured and restored.
2. **Memento**: The object that stores the internal state of the Originator.
3. **Caretaker**: The object that is responsible for managing the Memento objects, including creating, storing, and restoring them.

Here's how the pattern works:

1. The Originator creates a Memento object that encapsulates its current state.
2. The Caretaker stores the Memento object, typically in a stack or a queue.
3. When the user wants to undo or redo an action, the Caretaker retrieves the appropriate Memento object from storage and passes it back to the Originator, which then restores its state from the Memento.

By separating the responsibility of state management from the Originator, the Memento Pattern allows the Originator to remain focused on its core functionality, while the Caretaker handles the complexity of storing and restoring the Originator's state.

## Implementation

Here's a simple example in C# that demonstrates the Memento Pattern:

```csharp
public class Originator
{
    private string _state;

    public Originator(string state)
    {
        _state = state;
    }

    public void DoSomething(string newState)
    {
        Console.WriteLine($"Originator: Current state is {_state}");
        _state = newState;
        Console.WriteLine($"Originator: Changed state to {_state}");
    }

    public Memento Save()
    {
        return new Memento(_state);
    }

    public void Restore(Memento memento)
    {
        _state = memento.GetState();
        Console.WriteLine($"Originator: State restored to {_state}");
    }
}

public class Memento
{
    private string _state;

    public Memento(string state)
    {
        _state = state;
    }

    public string GetState()
    {
        return _state;
    }
}

public class Caretaker
{
    private List<Memento> _mementos = new List<Memento>();

    public void Backup(Originator originator)
    {
        Console.WriteLine("Caretaker: Saving Originator's state...");
        _mementos.Add(originator.Save());
    }

    public void Undo(Originator originator)
    {
        if (_mementos.Count == 0)
            return;

        Memento memento = _mementos.Last();
        _mementos.RemoveAt(_mementos.Count - 1);
        Console.WriteLine("Caretaker: Restoring state to previous version...");
        originator.Restore(memento);
    }

    public void Redo(Originator originator)
    {
        if (_mementos.Count == 0)
            return;

        Memento memento = _mementos[_mementos.Count - 1];
        _mementos.Add(originator.Save());
        Console.WriteLine("Caretaker: Restoring state to next version...");
        originator.Restore(memento);
    }
}

// Example usage
var originator = new Originator("Initial State");
var caretaker = new Caretaker();

caretaker.Backup(originator);
originator.DoSomething("State 1");
caretaker.Backup(originator);
originator.DoSomething("State 2");

caretaker.Undo(originator);
caretaker.Undo(originator);
caretaker.Redo(originator);
```

In this C# example, the `Originator` class represents the object whose state needs to be captured and restored. The `Memento` class encapsulates the Originator's state, and the `Caretaker` class is responsible for managing the Memento objects.

The `DoSomething` method in the `Originator` class changes the state of the object. The `Save` method creates a `Memento` object that stores the current state, and the `Restore` method allows the Originator to restore its state from a `Memento` object.

The `Caretaker` class provides methods for backing up the Originator's state, undoing changes, and redoing changes. The `Backup` method stores a `Memento` object in a list, the `Undo` method restores the previous state, and the `Redo` method restores the next state.

By using the Memento Pattern, you can encapsulate the Originator's state and provide undo/redo functionality without exposing the internal details of the Originator object.