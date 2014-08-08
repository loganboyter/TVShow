namespace TvShow2.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TvShow2.Data.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TvShow2.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TvShow2.Data.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            TvShow Show1 = new TvShow("Adventure Time", "drugz4kidz");
            TvShow Show2 = new TvShow("Lost", "On an island");
            TvShow Show3 = new TvShow("Orange Is The New Black", "Piper isn't that badass");
            context.TvShows.AddOrUpdate(
                t => t.Title,
                Show1,
                Show2,
                Show3
                );
            //context.SaveChanges();
            //^ do this and then seed the data using Show1.Id, etc.
        }
    }
}
