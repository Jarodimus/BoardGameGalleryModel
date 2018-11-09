using System.Collections.Generic;

namespace boardgamegallerymodel.Models
{
    public class BoardGameCategory
    {
        public BoardGameCategory()
        {
            Subcategories = new List<Subcategory>();
        }

        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int BoardGameId { get; set; }

        public ICollection<Subcategory> Subcategories { get; set; }
        public Category Category { get; set; }
    }
}
