namespace AmrAmin.DesignPatterns.MementoPattern.GangOfFourExample;
using System;
using System.Collections.Generic;
using System.Linq;

public class Caretaker
{
    private readonly List<Memento> _mementos = new List<Memento>();

    public void Backup(Originator originator)
    {
        Console.WriteLine("|          Caretaker: Saving Originator's state...");
        _mementos.Add(originator.Save());
    }

    public void Undo(Originator originator)
    {
        if (_mementos.Count == 0)
        {
            return;
        }

        Memento memento = _mementos.Last();
        _mementos.RemoveAt(_mementos.Count - 1);
        Console.WriteLine("|          Caretaker: Restoring state to previous version...");
        originator.Restore(memento);
    }

    public void Redo(Originator originator)
    {
        if (_mementos.Count == 0)
        {
            return;
        }

        Memento memento = _mementos[_mementos.Count - 1];
        _mementos.Add(originator.Save());
        Console.WriteLine("|          Caretaker: Restoring state to next version...");
        originator.Restore(memento);
    }
}