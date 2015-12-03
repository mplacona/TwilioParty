using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace TwilioParty.Models
{
    public class TwilioPartyContext : DbContext
    {
        public TwilioPartyContext() : base("TwilioPartyContext") { }

        public DbSet<Prize> Prizes { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}