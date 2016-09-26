using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OkazukiSampleApi.Models
{
    public class SampleApiContext : DbContext
    {
        public DbSet<Person> People { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var people = modelBuilder.Entity<Person>()
                .ToTable("People");
            people.Property(x => x.Name)
                .IsRequired();
            people.Property(x => x.Birthday)
                .IsRequired();
        }
    }
}