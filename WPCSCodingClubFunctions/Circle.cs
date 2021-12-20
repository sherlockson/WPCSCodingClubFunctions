public class Circle
{
    private double diameter;
    private double radius;
    private string color;

    public Circle()
    {
        this.diameter = 10.0;
    }

    public Circle(double diameter, string color)
    {
        this.diameter = diameter;
        this.color = color;
    }

    public double Area()
    {
        double solution = Math.PI * Math.Pow(diameter / 2, 2);
        return solution;
    }
}

