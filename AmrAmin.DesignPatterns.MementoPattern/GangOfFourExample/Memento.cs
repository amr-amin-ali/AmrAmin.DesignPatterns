﻿namespace AmrAmin.DesignPatterns.MementoPattern.GangOfFourExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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