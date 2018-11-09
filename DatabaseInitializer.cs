using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using boardgamegallerymodel.Models;

namespace boardgamegallerymodel
{
    internal class DatabaseInitializer : DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {
            var strategy = new Category()
            {
                Name = "Strategy"
            };
            var family = new Category()
            {
                Name = "Family"
            };
            var fantasy = new Subcategory()
            {
                Name = "Fantasy"
            };
            var scifi = new Subcategory()
            {
                Name = "Science Fiction"
            };
            var horror = new Subcategory()
            {
                Name = "Horror"
            };
            var realtime = new Subcategory()
            {
                Name = "Real Time"
            };
            var coop = new Subcategory()
            {
                Name = "Cooperative"
            };
            var cphfg = new Manufacturer()
            {
                Name = "Cephalofair Games",
                Abbrev = "CG"
            };
            Manufacturer ffg = new Manufacturer()
            {
                Name = "Fantasy Flight Games",
                Abbrev = "FFG"
            };
            Manufacturer spin = new Manufacturer()
            {
                Name = "Spinmaster",
                Abbrev = "SM"
            };
            Mechanic hand = new Mechanic()
            {
                Name = "Hand Management",
                Description = "Hand management games feature cards that reward players when they play cards in certain sequences or groups."
            };
            Mechanic co_op = new Mechanic()
            {
                Name = "Cooperative",
                Description = "Unlike traditional games, cooperative games allow players to team up \"against the game\" and work together to win."
            };
            Mechanic rpg = new Mechanic()
            {
                Name = "Roleplaying",
                Description = "Roleplaying games enable players to take on a \"role\" as a character to explore a world or act out as that character."
            };
            var fivemin = new BoardGame()
            {
                Title = "5 Minute Dungeon",
                RegPrice = 14.95,
                SpecialPrice = 9.95,
                Manufacturer = spin,
            };
            fivemin.Mechanics.Add(hand);
            fivemin.Mechanics.Add(co_op);
            fivemin.AddCategory(family, new List<Subcategory> { fantasy, realtime });
            var ah3 = new BoardGame()
            {
                Title = "Arkham Horror 3rd Edition",
                RegPrice = 59.95,
                SpecialPrice = 49.95,
                Manufacturer = ffg,
                NewArrival = true
            };
            ah3.Mechanics.Add(co_op);
            ah3.AddCategory(strategy, new List<Subcategory> { horror, scifi, coop });
            var fallout = new BoardGame()
            {
                Title = "Fallout",
                RegPrice = 59.95,
                SpecialPrice = 50.99,
                Manufacturer = ffg
            };
            fallout.Mechanics.Add(co_op);
            fallout.Mechanics.Add(rpg);
            fallout.AddCategory(strategy, new List<Subcategory> { fantasy, scifi });
            var gloom = new BoardGame()
            {
                Title = "Gloomhaven",
                RegPrice = 159.99,
                SpecialPrice = 140.00,
                Manufacturer = cphfg
            };
            gloom.Mechanics.Add(co_op);
            gloom.Mechanics.Add(rpg);
            gloom.AddCategory(strategy, new List<Subcategory> { fantasy, coop });

            context.BoardGames.Add(ah3);
            context.BoardGames.Add(fallout);
            context.BoardGames.Add(gloom);
            context.BoardGames.Add(fivemin);
            context.SaveChanges();
        }
    }
}
