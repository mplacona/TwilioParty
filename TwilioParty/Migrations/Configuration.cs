using System.Collections.Generic;
using TwilioParty.Models;

namespace TwilioParty.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<TwilioParty.Models.TwilioPartyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(TwilioParty.Models.TwilioPartyContext context)
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
            var prizes = new List<Prize>
            {
                new Prize { Name = "T-Shirt", Quantity = 300},
                new Prize { Name = "Twilio Charger", Quantity = 30}
            };

            prizes.ForEach( p => context.Prizes.AddOrUpdate( s => s.Name, p));
            context.SaveChanges();
        }
    }
}
