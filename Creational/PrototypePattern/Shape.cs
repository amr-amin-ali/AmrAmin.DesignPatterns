namespace AmrAmin.DesignPatterns.Creational.PrototypePattern;
using System.Drawing;

public class Shape : IShape
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public Color Color { get; set; }

    public Shape() { }
    public Shape(int x, int y, int width, int height, Color color)
    {
        X = x;
        Y = y;
        Width = width;
        Height = height;
        Color = color;
    }

    public Shape Clone()
    {
        return new Shape
        {
            X = this.X,
            Y = this.Y,
            Width = this.Width,
            Height = this.Height,
            Color = this.Color
        };
    }
}