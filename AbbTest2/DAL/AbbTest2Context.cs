using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using AbbTest2.Models;


namespace AbbTest2.DAL
{
    public class AbbTest2Context : DbContext
    {
        public AbbTest2Context() : base("AbbTest2Context")
        {

        }

        public DbSet<Motor> Motors { get; set; }
        public DbSet<Measure> Measures { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}