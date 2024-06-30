namespace AmrAmin.DesignPatterns.Creational.PrototypePattern;
using System.Drawing;

public interface IShape : ICloneable
{
    int X { get; set; }
    int Y { get; set; }
    int Width { get; set; }
    int Height { get; set; }
    Color Color { get; set; }
}