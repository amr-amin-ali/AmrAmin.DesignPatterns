namespace AmrAmin.DesignPatterns.Behavioral.MementoPattern.GangOfFourExample;
using System;

public class Originator
{
    private string _state;

    public Originator(string state)
    {
        _state = state;
    }

    public void DoSomething(string newState)
    {
        Console.WriteLine($"|         Originator: Current state is {_state}");
        _state = newState;
        Console.WriteLine($"|         Originator: Changed state to {_state}");
    }

    public Memento Save()
    {
        return new Memento(_state);
    }

    public void Restore(Memento memento)
    {
        _state = memento.GetState();
        Console.WriteLine($"|         Originator: State restored to {_state}");
    }
}