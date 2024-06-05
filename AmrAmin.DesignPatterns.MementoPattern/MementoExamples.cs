namespace AmrAmin.DesignPatterns.MementoPattern;
using System;

using AmrAmin.DesignPatterns.MementoPattern.EditorExample;
using AmrAmin.DesignPatterns.MementoPattern.GangOfFourExample;

public static class MementoExamples
{
    public static void RunGangOfFourExample()
    {

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
    }
    public static void RunEditorExample()
    {
        var editor = new Editor();
        var history = new History();
        Console.WriteLine(" __________________________________________________________________________________");
        Console.WriteLine("/                                                                                  \\");
        Console.WriteLine("|  Use MementoPattern to test the 'undo' functionality in the editor example:       |");
        Console.WriteLine("|                                                                                   |");
        Console.WriteLine("|                                                                                   |");
        Console.WriteLine("|                                    [START]                                        |");
        Console.WriteLine("|                                                                                   |");
        Console.WriteLine("|   Write \" 1. First word.\" word in the editor                                      |");
        editor.SetContent("|             1. First word.                                                        |");
        history.Push(editor.CreateState());
        Console.WriteLine("|   Write \" 2. Second word.\" word in the editor                                     |");
        editor.SetContent("|             2. Second word                                                        |");
        history.Push(editor.CreateState());
        Console.WriteLine("|   Write \" 3. Third word.\" word in the editor                                      |");
        editor.SetContent("|             3. Third word.                                                        |");
        Console.WriteLine("|   Do UNDO                                                                         |");
        editor.Restore(history.Pop());
        Console.WriteLine("|   What is in the editor  ?                                                        |");
        Console.WriteLine(editor.GetContent());// should print " 2. Second word."
        Console.WriteLine("|   Do UNDO                                                                         |");
        editor.Restore(history.Pop());
        Console.WriteLine("|   What is in the editor ?                                                         |");
        Console.WriteLine(editor.GetContent());// should print " 1. First word." 
        Console.WriteLine("|                                                                                   |");
        Console.WriteLine("|                                    [END]                                          |");
        Console.WriteLine("\\===================================================================================/");
    }
}
