using System.Collections.Generic;

namespace boardgamegallerymodel.Models
{
    public class Category
    {
        public Category()
        {
            BoardGames = new List<BoardGameCategory>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<BoardGameCategory> BoardGames { get; set; }
    }
}
