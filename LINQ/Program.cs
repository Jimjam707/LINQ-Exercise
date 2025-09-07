namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Video games in order by name length: ");
            Console.WriteLine();

            var names = new List<string>
            {
                "Mario Kart", "Stardew Valley", "Oldschool RuneScape", "Deadlock", "007: GoldenEye", "Raft",
                "Hunt: Showdown", "Escape from Tarkov",
            };
            
            var sortedNames = names.OrderBy(name => name.Length).ToList();
            
            sortedNames.ForEach(name => Console.WriteLine(name));
        }
    }
}
