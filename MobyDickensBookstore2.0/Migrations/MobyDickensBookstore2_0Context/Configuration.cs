namespace MobyDickensBookstore2._0.Migrations.MobyDickensBookstore2_0Context
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MobyDickensBookstore2._0.Models.MobyDickensBookstore2_0Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\MobyDickensBookstore2_0Context";
            ContextKey = "MobyDickensBookstore2._0.Models.MobyDickensBookstore2_0Context";
        }

        protected override void Seed(MobyDickensBookstore2._0.Models.MobyDickensBookstore2_0Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
