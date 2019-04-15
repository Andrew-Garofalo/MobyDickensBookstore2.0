namespace MobyDickensBookstore2._0.Migrations.ApplicationDbContext
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using MobyDickensBookstore2._0.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MobyDickensBookstore2._0.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\ApplicationDbContext";
            ContextKey = "MobyDickensBookstore2._0.Models.ApplicationDbContext";
        }

        protected override void Seed(MobyDickensBookstore2._0.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            var userStore = new UserStore<ApplicationUser>(context);
            var userManager = new UserManager<ApplicationUser>(userStore);

            if (!context.Users.Any(u => u.UserName == "admin@MobyDickensBookstore.com"))
            {
                var user = new ApplicationUser
                {
                    UserName = "admin@MobyDickensBookstore.com",
                    Email = "admin@MobyDickensBookstore.com"
                };
                IdentityResult result = userManager.Create(user, "Password12#");

                context.Roles.AddOrUpdate(r => r.Name, new IdentityRole { Name = "Admin" });
                context.SaveChanges();

                userManager.AddToRole(user.Id, "Admin");
                context.SaveChanges();
            }

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
