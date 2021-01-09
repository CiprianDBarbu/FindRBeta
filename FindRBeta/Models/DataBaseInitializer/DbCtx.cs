using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FindRBeta.Models.DataBaseInitializer
{
    public class DbCtx : DbContext
    {
        public DbCtx() : base("DbConnectionString")
        {
            Database.SetInitializer<DbCtx>(new Initp());
        }

        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Location> Locations { get; set; }
    }


    public class Initp : DropCreateDatabaseIfModelChanges<DbCtx>
    {
        //initialzer - seed for Database
        protected override void Seed(DbCtx context)
        {
            Location location1 = new Location { LocationId = 1, Country = "Romania", City = "Bucuresti", Placement = Zone.Central };
            Location location2 = new Location { LocationId = 2, Country = "Romania", City = "Cluj", Placement = Zone.Central };
            Location location3 = new Location { LocationId = 3, Country = "Romania", City = "Constanta", Placement = Zone.Periferial };
            Location location4 = new Location { LocationId = 4, Country = "Romania", City = "Iasi", Placement = Zone.Central };


            context.Locations.Add(location1);
            context.Locations.Add(location2);
            context.Locations.Add(location3);
            context.Locations.Add(location4);


            Profile profile1 = new Profile { ProfileId = 1, FirstName = "Andrei", LastName = "Popescu", Age = 19, GenderType = Gender.Male, LocationId = location1.LocationId };
            Profile profile2 = new Profile { ProfileId = 2, FirstName = "Alexanda", LastName = "Ionescu", Age = 20, GenderType = Gender.Female, LocationId = location1.LocationId };
            Profile profile3 = new Profile { ProfileId = 3, FirstName = "Daniel", LastName = "Baltariu", Age = 19, GenderType = Gender.Male, LocationId = location2.LocationId };
            Profile profile4 = new Profile { ProfileId = 4, FirstName = "Andreea", LastName = "Stanculescu", Age = 20, GenderType = Gender.Female, LocationId = location3.LocationId };
            Profile profile5 = new Profile { ProfileId = 5, FirstName = "Stefan", LastName = "Popescu", Age = 22, GenderType = Gender.Others, LocationId = location4.LocationId };

            context.Profiles.Add(profile1);
            context.Profiles.Add(profile2);
            context.Profiles.Add(profile3);
            context.Profiles.Add(profile4);
            context.Profiles.Add(profile5);

            context.SaveChanges();
            base.Seed(context);
        }
    }
}