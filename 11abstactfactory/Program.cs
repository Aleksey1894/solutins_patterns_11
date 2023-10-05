using System;

public abstract class FootballTeam
{
    public abstract string GetName();
    public abstract string Coach();

    public List<string> Players;

    public void TeamInfo()
    {
        Console.WriteLine("Name: " + GetName());
        Console.WriteLine("Coach: " + Coach());
        Console.WriteLine("Players:");
        foreach (var player in Players)
        {
            Console.WriteLine("- " + player);
        }
    }

}

public class LiverpoolTeam : FootballTeam
{
    public override string GetName() => "Liverpool";
    public override string Coach() => "Klopp";

    public LiverpoolTeam()
    {
        Players = new List<string> { "Allison", "va Dijk", "Robertson", "Alexander-Arnold", "Konate", "Alcantara",
            "MacAllister", "Jones", "Elliot", "Salah", "Diaz" };
    }

}

public class JuventusTeam : FootballTeam
{
    public override string GetName() => "Juventus";
    public override string Coach() => "Allegri";

    public JuventusTeam()
    {
        Players = new List<string> { "Szczesny", "De Sciglio", "Rugani", "Sandro", "Danilo", "Vea",
            "Rabio", "Pogba", "Locatelli", "Chiesa", "Milik" };
    }
}

public abstract class FootballTeamFactory
{
    public abstract FootballTeam CreateTeam();
}

public class LiverpoolFactory : FootballTeamFactory
{
    public override FootballTeam CreateTeam() => new LiverpoolTeam();
}
public class JuventusFactory : FootballTeamFactory
{
    public override FootballTeam CreateTeam() => new JuventusTeam();
}

class Program
{
    static void Main(string[] args)
    {
        FootballTeamFactory liverpoolFactory = new LiverpoolFactory();
        FootballTeamFactory juventusFactory = new JuventusFactory();

        FootballTeam LiverpoolTeam = liverpoolFactory.CreateTeam();
        FootballTeam JuventusTeam = juventusFactory.CreateTeam();

        Console.WriteLine("Information about F.C.Liverpool:");
        LiverpoolTeam.TeamInfo();

        Console.WriteLine("Information about F.C.Juventus:");
        JuventusTeam.TeamInfo();
    }
}
