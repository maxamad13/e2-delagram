namespace Delagram.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Delagram.DAL.DelagramContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Delagram.DAL.DelagramContext context)
        {
            //  This method will be called after migrating to the latest version.

            context.Posts.AddOrUpdate(
                post => post.ImageUrl,
                new Post {Caption = "Hello Kitty", ImageUrl = "https://placekitten.com/400/300", Time = DateTime.UtcNow},
                new Post { Caption = "Hello Kitty Again", ImageUrl = "https://placekitten.com/200/150", Time = DateTime.UtcNow }
            );

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
        }
    }
}
