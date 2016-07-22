namespace AspNetIdentity.Migrations
{
    using Infrastructure;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AspNetIdentity.Infrastructure.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AspNetIdentity.Infrastructure.AppDbContext context)
        {
            var manager = new UserManager<User>(new UserStore<User>(new AppDbContext()));

            var user = new User()
            {
                UserName = "SuperUser",
                Email = "super.userh@mail.com",
                EmailConfirmed = true,
                FirstName = "Super",
                LastName = "Man",
                Level = 1,
                JoinDate = DateTime.Now.AddYears(-1)
            };

            manager.Create(user, "P@ssw0rd!");
        } //
    }
}
