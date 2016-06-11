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

            context.Filters.AddOrUpdate(
                filter => filter.Name,
                new Filter { Name = "aden"},
                new Filter { Name = "reyes" },
                new Filter { Name = "perpetua" },
                new Filter { Name = "inkwell" },
                new Filter { Name = "toaster" },
                new Filter { Name = "walden" },
                new Filter { Name = "hudson" },
                new Filter { Name = "gingham" },
                new Filter { Name = "mayfair" },
                new Filter { Name = "lofi" },
                new Filter { Name = "xpro2" },
                new Filter { Name = "_1977" },
                new Filter { Name = "brooklyn" },
                new Filter { Name = "nashville" },
                new Filter { Name = "lark" },
                new Filter { Name = "moon" },
                new Filter { Name = "clarendon" },
                new Filter { Name = "willow" }
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
