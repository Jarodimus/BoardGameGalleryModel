using boardgamegallerymodel.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace boardgamegallerymodel
{
    internal class DatabaseInitializer : DropCreateDatabaseAlways<Context>
    {
        protected override void Seed(Context context)
        {
            var party = new Category()
            {
                Name = "Party"
            };
            var war = new Category()
            {
                Name = "War Games"
            };
            var strategy = new Category()
            {
                Name = "Strategy"
            };
            var family = new Category()
            {
                Name = "Family"
            };
            var children = new Category()
            {
                Name = "Childrens"
            };



            var dexterity = new Subcategory()
            {
                Name = "Dexterity"
            };
            var political = new Subcategory()
            {
                Name = "Political"
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
            var minis = new Subcategory()
            {
                Name = "Miniatures"
            };
            var edu = new Subcategory()
            {
                Name = "Educational"
            };
            var humor = new Subcategory()
            {
                Name = "Humor"
            };
            var mystery = new Subcategory()
            {
                Name = "Mystery"
            };
            var adventure = new Subcategory()
            {
                Name = "Adventure"
            };


            var cphfg = new Manufacturer()
            {
                Name = "Cephalofair Games",
                Abbrev = "CG"
            };
            var ffg = new Manufacturer()
            {
                Name = "Fantasy Flight Games",
                Abbrev = "FFG"
            };
            var spin = new Manufacturer()
            {
                Name = "Spinmaster",
                Abbrev = "SM"
            };
            var stonem = new Manufacturer
            {
                Name = "Stonemaier Games",
                Abbrev = "smg"
            };

            var hand = new Mechanic()
            {
                Name = "Hand Management",
                Description = "Hand management games feature cards that reward players when they play cards in certain sequences or groups."
            };
            var co_op = new Mechanic()
            {
                Name = "Cooperative",
                Description = "Unlike traditional games, cooperative games allow players to team up \"against the game\" and work together to win."
            };
            var rpg = new Mechanic()
            {
                Name = "Roleplaying",
                Description = "Roleplaying games enable players to take on a \"role\" as a character to explore a world or act out as that character."
            };
            var dice = new Mechanic()
            {
                Name = "Dice Rolling",
                Description = "Games where dicerolling is a core mechanic to the game."
            };
            var set = new Mechanic()
            {
                Name = "Set Collection",
                Description = "The primary goal of a set collection mechanic is to encourage a player to collect a set of items."
            };
            var tile = new Mechanic()
            {
                Name = "Tile Placement",
                Description = "Tile Placement games feature placing a piece to score VPs, with the amount often based on adjacent pieces or pieces in the same group/cluster, and keying off non-spatial properties like color, \"feature completion\", cluster size etc.."
            };
            var partner = new Mechanic()
            {
                Name = "Partnerships",
                Description = "Games with partnerships offer players a set of rules for alliances and teams. Partners are often able to win as a team, or penalities are enforced for not respecting alliances."
            };
            var cardDraft = new Mechanic()
            {
                Name = "Card Drafting",
                Description = "Card drafting games are games in which players pick cards from a limited subset, such as a common pool, to gain some advantage (immediate or longterm) or to assemble hands of cards that are used to meet objectives within the game."
            };

            //var tile = new Mechanic()
            //{
            //    Name = "Tile Placement",
            //    Description = "Tile Placement games feature placing a piece to score VPs, with the amount often based on adjacent pieces or pieces in the same group/cluster, and keying off non-spatial properties like color, \"feature completion\", cluster size etc.."
            //};
            //var tile = new Mechanic()
            //{
            //    Name = "Tile Placement",
            //    Description = "Tile Placement games feature placing a piece to score VPs, with the amount often based on adjacent pieces or pieces in the same group/cluster, and keying off non-spatial properties like color, \"feature completion\", cluster size etc.."
            //};
            //var tile = new Mechanic()
            //{
            //    Name = "Tile Placement",
            //    Description = "Tile Placement games feature placing a piece to score VPs, with the amount often based on adjacent pieces or pieces in the same group/cluster, and keying off non-spatial properties like color, \"feature completion\", cluster size etc.."
            //};
            //var tile = new Mechanic()
            //{
            //    Name = "Tile Placement",
            //    Description = "Tile Placement games feature placing a piece to score VPs, with the amount often based on adjacent pieces or pieces in the same group/cluster, and keying off non-spatial properties like color, \"feature completion\", cluster size etc.."
            //};
            //var tile = new Mechanic()
            //{
            //    Name = "Tile Placement",
            //    Description = "Tile Placement games feature placing a piece to score VPs, with the amount often based on adjacent pieces or pieces in the same group/cluster, and keying off non-spatial properties like color, \"feature completion\", cluster size etc.."
            //};


            //var fivemin = new BoardGame()
            //{
            //    Title = "5 Minute Dungeon",
            //    RegPrice = 14.95,
            //    SpecialPrice = 9.95,
            //    Manufacturer = spin,
            //    NewArrival = true,
            //    Mechanics =
            //    {
            //        hand,
            //        co_op
            //    }
            //};

            var twoSeven = new PlayerCount
            {
                MinPlayers = 2,
                MaxPlayers = 7
            };

            var ludwig = new BoardGame()
            {
                Title = "Between Two Castles Of Mad King Ludwig",
                RegPrice = 45.00,
                SpecialPrice = 34.99,
                Manufacturer = stonem,
                NewArrival = false,
                PlayerCount = twoSeven,
                Contents = new string[] {
                    "147 Regular Room Tiles",
                    "48 Specialty Room Tiles",
                    "7 Throne Room Tiles",
                    "7 Player Aids",
                    "28 Royal Attendants",
                    "20 Bonus Cards",
                    "7 Castle Tokens",
                    "Scoring Sheets"
                },
                Mechanics =
                {
                    cardDraft,
                    partner,
                    tile
                }
            };
            
            //var ludwig = new BoardGame()
            //{

            //};

            //var ludwig = new BoardGame()
            //{

            //};

            //var ludwig = new BoardGame()
            //{

            //};

            //var ludwig = new BoardGame()
            //{

            //};

            //var ludwig = new BoardGame()
            //{

            //};

            //var ludwig = new BoardGame()
            //{

            //};

            //var ludwig = new BoardGame()
            //{

            //};

            //var ludwig = new BoardGame()
            //{

            //};

            //var ludwig = new BoardGame()
            //{

            //};

            //var ludwig = new BoardGame()
            //{

            //};

            //var ludwig = new BoardGame()
            //{

            //};

            //var ludwig = new BoardGame()
            //{

            //};

            //var ludwig = new BoardGame()
            //{

            //};

            //var ludwig = new BoardGame()
            //{

            //};



            var fivemin = new BoardGame()
            {
                Title = "5 Minute Dungeon",
                RegPrice = 14.95,
                SpecialPrice = 9.95,
                Manufacturer = spin,
                NewArrival = true,
                Mechanics =
                {
                    hand,
                    co_op
                }
            };
            fivemin.AddCategory(family, new List<Subcategory> { fantasy, realtime });

            var ah3 = new BoardGame()
            {
                Title = "Arkham Horror 3rd Edition",
                RegPrice = 59.95,
                SpecialPrice = 49.95,
                Manufacturer = ffg,
                NewArrival = true,
                Mechanics =
                {
                    co_op
                }
            };
            ah3.AddCategory(strategy, new List<Subcategory> { horror, scifi, coop });

            var fallout = new BoardGame()
            {
                Title = "Fallout",
                RegPrice = 59.95,
                SpecialPrice = 50.99,
                Manufacturer = ffg,
                NewArrival = true,
                Mechanics =
                {
                    rpg,
                    co_op
                }
            };
            fallout.AddCategory(strategy, new List<Subcategory> { fantasy, scifi });

            var gloom = new BoardGame()
            {
                Title = "Gloomhaven",
                RegPrice = 159.99,
                SpecialPrice = 140.00,
                Manufacturer = cphfg,
                NewArrival = true
            };
            gloom.Mechanics.Add(co_op);
            gloom.Mechanics.Add(rpg);
            gloom.AddCategory(strategy, new List<Subcategory> { fantasy, coop });

            context.BoardGames.Add(ludwig);
            context.BoardGames.Add(ah3);
            context.BoardGames.Add(fallout);
            context.BoardGames.Add(gloom);
            context.BoardGames.Add(fivemin);
            try
            {
                context.SaveChanges();
            } catch(Exception e)
            {
                Console.WriteLine(e.Message + "\n" + e.InnerException + "\n" + e.StackTrace);
                Console.ReadLine();
                context.Dispose();
            }
           
        }

        private void SeedManufacturers()
        {

        }
    }
}
