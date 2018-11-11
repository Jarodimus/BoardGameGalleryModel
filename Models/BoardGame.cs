using System.Collections.Generic;

namespace boardgamegallerymodel.Models
{
    public class BoardGame
    {
        public BoardGame()
        {
            Mechanics = new List<Mechanic>();
            Categories = new List<BoardGameCategory>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string ProductNumber { get; set; }
        public double RegPrice { get; set; }
        public double SpecialPrice { get; set; }
        public string ImageName { get; set; }
        public int ManufacturerId { get; set; }
        public string DescriptionHtml { get; set; }
        public string[] Contents { get; set; }
        public bool Wishlisted { get; set; }
        public bool NewArrival { get; set; }
       
        //public int PlayerCountId { get; set; }
        //[ForeignKey("PlayerCountId")]
        public PlayerCount PlayerCount { get; set; }
        //public int DesignerId { get; set; }
        //[ForeignKey("DesignerId")]
        public Designer Designer { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public ICollection<Mechanic> Mechanics { get; set; }
        public ICollection<BoardGameCategory> Categories { get; set; }

        public string TitleText
        {
            get
            {
                if (NewArrival)
                {
                    return Title + " (New Arrival)";
                }
                else
                {
                    return Title;
                }
            }
        }

        public void AddCategory(Category category, List<Subcategory> subcategories)
        {
            Categories.Add(new BoardGameCategory()
            {
                Category = category,
                Subcategories = subcategories
            });
        }

        public void AddPlayerCount(int minPlayers, int maxPlayers)
        {
            PlayerCount = new PlayerCount
            {
                MinPlayers = minPlayers,
                MaxPlayers = maxPlayers
            };
        }
    }
}
