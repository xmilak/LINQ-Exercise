using System.Globalization;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGames = new List<string>()
           { "Zelda", "Fortnite", "Borderlands", "Metal Gear Solid", "Ratchet and Clank", "Zak", "Fallout", "Marathon", "Minecraft" };

            
            //Organize by length of name
            
            var videoGameOrder = videoGames.OrderBy(name => name.Length);

            foreach( var videoGameList in videoGameOrder) 
            {
                Console.WriteLine(videoGameList);
            }

            //OR in a single line, like so. 
             videoGameOrder.OrderBy(name =>name.Length).ToList().ForEach(Console.WriteLine); 
             


        }

    }
}
