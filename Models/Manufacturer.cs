using System.Collections.Generic;

namespace boardgamegallerymodel.Models
{
    public class Manufacturer
    {
        public Manufacturer()
        {
            BoardGames = new List<BoardGame>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Abbrev { get; set; }

        public ICollection<BoardGame> BoardGames { get; set; }
    }
}
