using System;

class Program
{
    static void Main(string[] args)
    {
        Club club = new Club();
        club.Appoint("Arsen Venger");
        Console.WriteLine(club.CoachOfFootballClub.Name);

        // we will not be able to change the CoachOfFootballClub, since the object has already been created   
        club.CoachOfFootballClub = CoachOfFootballClub.getInstance("Jose Mourinho");
        Console.WriteLine(club.CoachOfFootballClub.Name);

        Console.ReadLine();
    }
}
class Club
{
    public CoachOfFootballClub CoachOfFootballClub { get; set; }
    public void Appoint(string osName)
    {
        CoachOfFootballClub = CoachOfFootballClub.getInstance(osName);
    }
}
class CoachOfFootballClub
{
    private static CoachOfFootballClub instance;

    public string Name { get; private set; }

    protected CoachOfFootballClub(string name)
    {
        this.Name = name;
    }
    public static CoachOfFootballClub getInstance(string name)
    {
        if (instance == null)
            instance = new CoachOfFootballClub(name);
        return instance;
    }
}

