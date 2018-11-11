using System.Collections.Generic;

namespace boardgamegallerymodel.Models
{
    public class Designer
    {
        public Designer()
        {
            BoardGames = new List<BoardGame>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<BoardGame> BoardGames { get; set; }
    }
}
