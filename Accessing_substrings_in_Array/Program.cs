internal class Program
{
    private static void Main(string[] args)
    {
        string[] listOfStats = {"Power: 10 atk dmg", "STR: 10u" ,"DEX: 90u", "Type: Projectile"};

        foreach (string a in listOfStats){
            int posindex = a.IndexOf(":");
            Console.WriteLine(a.Substring(posindex));
        }
    }
}