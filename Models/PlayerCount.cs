using System.Collections.Generic;

namespace boardgamegallerymodel.Models
{
    public class PlayerCount
    {
        public PlayerCount()
        {
            BoardGames = new List<BoardGame>();
        }
        public int Id { get; set; }
        public int MinPlayers { get; set; }
        public int MaxPlayers { get; set; }

        public ICollection<BoardGame> BoardGames { get; set; }
    }
}
