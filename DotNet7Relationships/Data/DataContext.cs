using DotNet7Relationships.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNet7Relationships.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Character> Characters => Set<Character>();
        public DbSet<Backpack> Backpacks => Set<Backpack>();
        public DbSet<Weapon> Weapons => Set<Weapon>();
    }
}
