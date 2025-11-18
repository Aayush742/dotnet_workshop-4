class Program
{
    public static void Main(string[] args)
    {
        Player p1 = new Player();
        Player p2 = new Player("Munal", 5, "Good");
        Console.WriteLine($"{p2.playerName} {p2.level} {p2.health}");
    }
}