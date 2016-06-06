using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Entity;
using Windows.Storage;
// Server=tcp:lazerektapidbserver.database.windows.net,1433;Data Source=lazerektapidbserver.database.windows.net;Initial Catalog=lazerektdb;Persist Security Info=False;User ID=lazerekt_dev;Password=LazAPIPass1337;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;
namespace Lazerekt.LazerektBaza.Modeli
{
    class LazerektDBContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<User> Users { get; set; }
        //public DbSet<Moderator> Moderators { get; set; }
        //public DbSet<Administrator> Administrators { get; set; }
        public DbSet<CrewMember> CrewMembers { get; set; }  
        public DbSet<Position> Positions { get; set; }
        public DbSet<Ship> Ships { get; set; }
        public DbSet<Suggestion> Suggetions { get; set; }     
        //public DbSet<Report> Reports { get; set; }
        public DbSet<Reason> Reasons { get; set; }
        public DbSet<SuggestionReport> SuggestionReports { get; set; }
        public DbSet<UserReport> UserReports { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlite($"Data source={@"db\Lazerekt.db"}");
        }
    }
}
