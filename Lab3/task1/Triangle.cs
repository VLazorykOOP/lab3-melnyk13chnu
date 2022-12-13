using System.Runtime.Versioning;

namespace pro100user;

public class Triangle
{
    private int a, b, c;
    private string color;

    public Triangle() {}

    public Triangle(int a, int b, int c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public Triangle(int a, int b, int c, string color)
    {
        this.a = a;
        this.b = b;
        this.c = c;
        this.color = color;
    }

    public int GetPerimeter()
    {
        return a + b + c;
    }

    public double GetArea()
    {
        int p = GetPerimeter() / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));  
    }
    
    public override string ToString()
    {
        return "Triangle {a: " + a + ", b: " + b + ", c: " + c + ", color: " + color + "}";
    }

    public int A
    {
        get => a;
        set => a = value;
    }
    
    public int B
    {
        get => a;
        set => a = value;
    }
    
    public int C
    {
        get => a;
        set => a = value;
    }

    public string Color => color;
}