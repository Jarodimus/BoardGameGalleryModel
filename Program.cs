using boardgamegallerymodel.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace boardgamegallerymodel
{
    class Program
    {

        static void Main(string[] args)
        {
            using (var context = new Context())
            {
                var boardGames = context.BoardGames
                    .Include(bg => bg.Manufacturer)
                    .Include(bg => bg.Mechanics)
                    .ToList();

                foreach (var game in boardGames)
                {
                    Console.WriteLine(game.Title);
                    Console.WriteLine(game.Manufacturer.Name);
                    var mechs = game.Mechanics.Select(m => m.Name).ToList();
                    var mechanicsDisplayText = String.Join(", ", mechs);
                    Console.WriteLine(mechanicsDisplayText);
                    Console.WriteLine();
                }
                Console.ReadLine();
                context.Dispose();
            }
        }
        
    }
}
