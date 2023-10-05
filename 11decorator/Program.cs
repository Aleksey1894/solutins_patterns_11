using System;

//Component
public interface FootballTeam
{
    string GetName();
    string GetCity();

    string GetCountry();
}

//ConcreteComponent
public class ConcreteClub : FootballTeam
{
    public string GetName()
    {
        return "Name ";
    }
    public string GetCity()
    {
        return "City ";
    }
    public string GetCountry()
    {
        return "Country ";
    }
}

//Decorator
public class LiverpoolTeam : FootballTeam
{
    protected readonly FootballTeam _fclub;

    public LiverpoolTeam(FootballTeam fclub)
    {
        _fclub = fclub;
    }

    public string GetName()
    {
        return _fclub.GetName() + " Liverpool";
    }

    public string GetCity()
    {
        return _fclub.GetCity() + " Liverpool";
    }
    public string GetCountry()
    {
        return _fclub.GetCountry() + " Englang";
    }
}

public class JuventusTeam : FootballTeam
{
    protected readonly FootballTeam _fclub;

    public JuventusTeam(FootballTeam fclub)
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
    public string GetCountry()
    {
        return _fclub.GetCountry() + " Italy";
    }
}

class Program
{
    static void Main(string[] args)
    {
        FootballTeam fclub = new ConcreteClub();

        fclub = new LiverpoolTeam(fclub);
        Console.WriteLine(fclub.GetName());
        Console.WriteLine(fclub.GetCity());
        Console.WriteLine(fclub.GetCountry());

        fclub = new JuventusTeam(fclub);
        Console.WriteLine(fclub.GetName());
        Console.WriteLine(fclub.GetCity());
        Console.WriteLine(fclub.GetCountry());
    }
}



