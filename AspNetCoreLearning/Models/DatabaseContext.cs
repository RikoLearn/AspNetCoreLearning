namespace AspNetCoreLearning.Models
{
    public class DatabaseContext: Microsoft.EntityFrameworkCore.DbContext
    {
        public DatabaseContext(Microsoft.EntityFrameworkCore.DbContextOptions<DatabaseContext> options):base(options)
        {
        }

        public Microsoft.EntityFrameworkCore.DbSet<Book> Books { get; set; }

    }
}
