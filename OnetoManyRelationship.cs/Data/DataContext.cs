using Microsoft.EntityFrameworkCore;

namespace OnetoManyRelationship.cs.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> Options) : base(Options) { }

        public DbSet<User> users { get; set; }

        public DbSet<Character> characters { get; set; }
        //public object Character { get; internal set; }
    }
}