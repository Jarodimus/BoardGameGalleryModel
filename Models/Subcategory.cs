using System.Collections.Generic;

namespace boardgamegallerymodel.Models
{
    public class Subcategory
    {
        public Subcategory()
        {
            BoardGames = new List<BoardGameCategory>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<BoardGameCategory> BoardGames { get; set; }
    }
}
