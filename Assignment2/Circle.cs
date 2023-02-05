using System;

public class Circle
{
    public int radius { get; set; }

    public Circle(int radius)
    {
        radius = 1;
    }
	
    public Circle()
    {
       radius= 1;
    }

    public int GetRadius()
    {
        return radius;
    }

    public void SetRadius(int radius)
    {
        this.radius = radius;
    }

    public double GetCircumference()
    {
        double circumference;
        circumference = 2 * 3.14 * radius;
        return circumference;
    }

    public double GetArea()
    {
        double area;
        area = 3.14 * radius * radius;
        return area;
    }
}
