using System;
public interface ICalculateInterface
{
    int Calculate(int value1, int value2);
}

class Minus : ICalculateInterface
{
    public int Calculate(int value1, int value2)
    {
        return value1 - value2;
    }
}

class Plus : ICalculateInterface
{
    public int Calculate(int value1, int value2)
    {
        return value1 + value2;
    }
}

class CalculateClient
{
    private ICalculateInterface calculateInterface;

    public CalculateClient(ICalculateInterface strategy)
    {
        calculateInterface = strategy;
    }

    public int Calculate(int value1, int value2)
    {
        return calculateInterface.Calculate(value1, value2);
    }
}

class Program
{
    static void Main(string[] args)
    {
        CalculateClient operation1 = new CalculateClient(new Plus());
        int result1 = operation1.Calculate(10, 5);
        Console.WriteLine($"10 + 5 = {result1}");

        CalculateClient operation2 = new CalculateClient(new Minus());
        int result2 = operation2.Calculate(10, 5);
        Console.WriteLine($"10 - 5 = {result2}");
    }
}
