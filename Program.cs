using System;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;

namespace boardgamegallerymodel
{
    class Program
    {

        static void Main(string[] args)
        {
            using (var context = new Context())
            {
                //context.Database.Delete();
                //context.Database.Create();
                //context.Database.Initialize(false);
                context.Database.Log = (message) => Debug.WriteLine(message);

                var boardGameId = 1;
                var bGame = context.BoardGames.Find(boardGameId);

                Console.WriteLine(bGame.Title + " (Find)");

                var boardGames = context.BoardGames
                    .Include(bg => bg.Mechanics)
                    .Where(bg => bg.NewArrival == true)
                    .OrderByDescending(bg => bg.Title)
                    .ThenBy(bg => bg.RegPrice)
                    .ToList();

                foreach (var game in boardGames)
                {
                    Console.WriteLine(game.Title);
                    foreach (var mech in game.Mechanics)
                    {
                        Console.Write($"{mech.Name}, ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Success!");
                Console.ReadLine();
            }
        }
        
    }
}
