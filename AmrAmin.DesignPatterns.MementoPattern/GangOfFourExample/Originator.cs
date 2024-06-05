namespace AmrAmin.DesignPatterns.MementoPattern.GangOfFourExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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