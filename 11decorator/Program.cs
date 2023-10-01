using System;

//Component
public interface IFootballClub
{
    string GetName();
    string GetCity();
}

//ConcreteComponent
public class ConcreteClub : IFootballClub
{
    public string GetName()
    {
        return "";
    }
    public string GetCity()
    {
        return "";
    }
}

//Decorator
public class EnglandDecorator : IFootballClub
{
    protected readonly IFootballClub _fclub;

    public EnglandDecorator(IFootballClub fclub)
    {
        _fclub = fclub;
    }

    public string GetName()
    {
        return _fclub.GetName() + " Arsenal";
    }

    public string GetCity()
    {
        return _fclub.GetCity() + " London";
    }
}

public class ItalyDecorator : IFootballClub
{
    protected readonly IFootballClub _fclub;

    public ItalyDecorator(IFootballClub fclub)
    {
        _fclub = fclub;
    }

    public string GetName()
    {
        return _fclub.GetName() + " Juventus";
    }

    public string GetCity()
    {
        return _fclub.GetCity() + " Turin";
    }
}

class Program
{
    static void Main(string[] args)
    {
        IFootballClub fclub = new ConcreteClub();

        fclub = new EnglandDecorator(fclub);
        Console.WriteLine("Football club: " + fclub.GetName());
        Console.WriteLine("City of: " + fclub.GetCity());

        fclub = new ItalyDecorator(fclub);
        Console.WriteLine("Football club: " + fclub.GetName());
        Console.WriteLine("City of: " + fclub.GetCity());
    }
}


