using AtchleyGameCenter.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace AtchleyGameCenter.DAL
{
    public class GameCenterContext : DbContext
    {

        public GameCenterContext() : base("GameCenterContext")
        {
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Signup> Signups { get; set; }
        public DbSet<Game> Games { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}