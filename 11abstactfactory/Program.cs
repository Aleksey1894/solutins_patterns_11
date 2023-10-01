using System;

public abstract class Team
{
    public abstract string GetName();
}

public class Team1 : Team
{
    public override string GetName()
    {
        return "Chelsea";
    }
}

public class Team2 : Team
{
    public override string GetName()
    {
        return "Dynamo";
    }
}

public abstract class TeamFactory
{
    public abstract Team CreateTeam();
}

public class Team1Factory : TeamFactory
{
    public override Team CreateTeam()
    {
        return new Team1();
    }
}

public class Team2Factory : TeamFactory
{
    public override Team CreateTeam()
    {
        return new Team2();
    }
}

class Program
{
    static void Main(string[] args)
    {
        TeamFactory team1Factory = new Team1Factory();
        TeamFactory team2Factory = new Team2Factory();

        Team team1 = team1Factory.CreateTeam();
        Team team2 = team2Factory.CreateTeam();

        if (IsTeam1Winner())
        {
            Console.WriteLine($"{team1.GetName()} win!");
        }
        else
        {
            Console.WriteLine($"{team2.GetName()} win!");
        }
    }
    static bool IsTeam1Winner()
    {
        return new Random().Next(2) == 0;
    }
}
