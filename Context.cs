using boardgamegallerymodel.Models;
using System.Data.Entity;

namespace boardgamegallerymodel
{
    public class Context : DbContext
    {
        //Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BoardGameGalleryConnectionString;Integrated Security=True;MultipleActiveResultSets=True

        public Context()
        {
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Context>());
            //Database.SetInitializer(new CreateDatabaseIfNotExists<Context>());
            Database.SetInitializer(new DropCreateDatabaseAlways<Context>());
        }

        public DbSet<BoardGame> BoardGames { get; set; }
    }
}
