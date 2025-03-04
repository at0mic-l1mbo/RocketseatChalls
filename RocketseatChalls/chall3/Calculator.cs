namespace RocketseatChalls.chall3;

public class Calculator
{
    public double result;
    public double Sum(double a, double b)
    {
        result = a + b;
        return result;
    }

    public double Subtraction(double a, double b)
    {
        result = a - b;
        return result;
    }

    public double Multiply(double a, double b)
    {
        result = a * b;
        return result;
    }

    public double Divisor(double a, double b)
    {
        result = a / b;
        return result;
    }

    public double Median(double a, double b)
    {
        result = (a + b) / 2;
        return result;
    }
}
