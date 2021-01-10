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
            context.Locations.Add(new Location { LocationId = 1, Country = "Romania", City = "Alba-Iulia", Placement = Zone.Central});
            context.Locations.Add(new Location { LocationId = 2, Country = "Romania", City = "Alba-Iulia", Placement = Zone.Periferial });
            context.Locations.Add(new Location { LocationId = 3, Country = "Romania", City = "Alexandria", Placement = Zone.Central });
            context.Locations.Add(new Location { LocationId = 4, Country = "Romania", City = "Alexandria", Placement = Zone.Periferial });
            context.Locations.Add(new Location { LocationId = 5, Country = "Romania", City = "Arad", Placement = Zone.Central });
            context.Locations.Add(new Location { LocationId = 6, Country = "Romania", City = "Arad", Placement = Zone.Periferial });
            context.Locations.Add(new Location { LocationId = 7, Country = "Romania", City = "Bacau", Placement = Zone.Central });
            context.Locations.Add(new Location { LocationId = 8, Country = "Romania", City = "Bacau", Placement = Zone.Periferial });
            context.Locations.Add(new Location { LocationId = 9, Country = "Romania", City = "Baia Mare", Placement = Zone.Central });
            context.Locations.Add(new Location { LocationId = 10, Country = "Romania", City = "Baia Mare", Placement = Zone.Periferial });
            context.Locations.Add(new Location { LocationId = 11, Country = "Romania", City = "Bistrita", Placement = Zone.Central });
            context.Locations.Add(new Location { LocationId = 12, Country = "Romania", City = "Bistrita", Placement = Zone.Periferial });
            context.Locations.Add(new Location { LocationId = 13, Country = "Romania", City = "Botosani", Placement = Zone.Central });
            context.Locations.Add(new Location { LocationId = 14, Country = "Romania", City = "Botosani", Placement = Zone.Periferial });
            context.Locations.Add(new Location { LocationId = 15, Country = "Romania", City = "Brasov", Placement = Zone.Central });
            context.Locations.Add(new Location { LocationId = 16, Country = "Romania", City = "Brasov", Placement = Zone.Periferial });
            context.Locations.Add(new Location { LocationId = 17, Country = "Romania", City = "Braila", Placement = Zone.Central });
            context.Locations.Add(new Location { LocationId = 18, Country = "Romania", City = "Braila", Placement = Zone.Periferial });
            context.Locations.Add(new Location { LocationId = 19, Country = "Romania", City = "Bucuresti", Placement = Zone.Central });
            context.Locations.Add(new Location { LocationId = 20, Country = "Romania", City = "Bucuresti", Placement = Zone.Periferial });
            context.Locations.Add(new Location { LocationId = 21, Country = "Romania", City = "Buzau", Placement = Zone.Central });
            context.Locations.Add(new Location { LocationId = 22, Country = "Romania", City = "Buzau", Placement = Zone.Periferial });
            context.Locations.Add(new Location { LocationId = 23, Country = "Romania", City = "Calarasi", Placement = Zone.Central });
            context.Locations.Add(new Location { LocationId = 24, Country = "Romania", City = "Calarasi", Placement = Zone.Periferial });
            context.Locations.Add(new Location { LocationId = 25, Country = "Romania", City = "Cluj-Napoca", Placement = Zone.Central });
            context.Locations.Add(new Location { LocationId = 26, Country = "Romania", City = "Cluj-Napoca", Placement = Zone.Periferial });
            context.Locations.Add(new Location { LocationId = 27, Country = "Romania", City = "Constanta", Placement = Zone.Central });
            context.Locations.Add(new Location { LocationId = 28, Country = "Romania", City = "Constanta", Placement = Zone.Periferial });
            context.Locations.Add(new Location { LocationId = 29, Country = "Romania", City = "Craiova", Placement = Zone.Central });
            context.Locations.Add(new Location { LocationId = 30, Country = "Romania", City = "Craiova", Placement = Zone.Periferial });
            context.Locations.Add(new Location { LocationId = 31, Country = "Romania", City = "Deva", Placement = Zone.Central });
            context.Locations.Add(new Location { LocationId = 32, Country = "Romania", City = "Deva", Placement = Zone.Periferial });
            context.Locations.Add(new Location { LocationId = 33, Country = "Romania", City = "Drobeta-Turnu-Severin", Placement = Zone.Central });
            context.Locations.Add(new Location { LocationId = 34, Country = "Romania", City = "Drobeta-Turnu-Severin", Placement = Zone.Periferial });
            context.Locations.Add(new Location { LocationId = 35, Country = "Romania", City = "Focsani", Placement = Zone.Central });
            context.Locations.Add(new Location { LocationId = 36, Country = "Romania", City = "Focsani", Placement = Zone.Periferial });
            context.Locations.Add(new Location { LocationId = 37, Country = "Romania", City = "Galati", Placement = Zone.Central });
            context.Locations.Add(new Location { LocationId = 38, Country = "Romania", City = "Galati", Placement = Zone.Periferial });
            context.Locations.Add(new Location { LocationId = 39, Country = "Romania", City = "Giurgiu", Placement = Zone.Central });
            context.Locations.Add(new Location { LocationId = 40, Country = "Romania", City = "Giurgiu", Placement = Zone.Periferial });
            context.Locations.Add(new Location { LocationId = 41, Country = "Romania", City = "Iasi", Placement = Zone.Central });
            context.Locations.Add(new Location { LocationId = 42, Country = "Romania", City = "Iasi", Placement = Zone.Periferial });
            context.Locations.Add(new Location { LocationId = 43, Country = "Romania", City = "Miercurea Ciuc", Placement = Zone.Central });
            context.Locations.Add(new Location { LocationId = 44, Country = "Romania", City = "Miercurea Ciuc", Placement = Zone.Periferial });
            context.Locations.Add(new Location { LocationId = 45, Country = "Romania", City = "Oradea", Placement = Zone.Central });
            context.Locations.Add(new Location { LocationId = 46, Country = "Romania", City = "Oradea", Placement = Zone.Periferial });
            context.Locations.Add(new Location { LocationId = 47, Country = "Romania", City = "Piatra Neamt", Placement = Zone.Central });
            context.Locations.Add(new Location { LocationId = 48, Country = "Romania", City = "Piatra Neamt", Placement = Zone.Periferial });
            context.Locations.Add(new Location { LocationId = 49, Country = "Romania", City = "Pitesti", Placement = Zone.Central });
            context.Locations.Add(new Location { LocationId = 50, Country = "Romania", City = "Pitesti", Placement = Zone.Periferial });
            context.Locations.Add(new Location { LocationId = 51, Country = "Romania", City = "Ploiesti", Placement = Zone.Central });
            context.Locations.Add(new Location { LocationId = 52, Country = "Romania", City = "Ploiest", Placement = Zone.Periferial });
            context.Locations.Add(new Location { LocationId = 53, Country = "Romania", City = "Ramnicu Valcea", Placement = Zone.Central });
            context.Locations.Add(new Location { LocationId = 54, Country = "Romania", City = "Ramnicu Valcea", Placement = Zone.Periferial });
            context.Locations.Add(new Location { LocationId = 55, Country = "Romania", City = "Resita", Placement = Zone.Central });
            context.Locations.Add(new Location { LocationId = 56, Country = "Romania", City = "Resita", Placement = Zone.Periferial });
            context.Locations.Add(new Location { LocationId = 57, Country = "Romania", City = "Satu Mare", Placement = Zone.Central });
            context.Locations.Add(new Location { LocationId = 58, Country = "Romania", City = "Satu Mare", Placement = Zone.Periferial });
            context.Locations.Add(new Location { LocationId = 59, Country = "Romania", City = "Sfantu Gheorghe", Placement = Zone.Central });
            context.Locations.Add(new Location { LocationId = 60, Country = "Romania", City = "Sfantu Gheorghe", Placement = Zone.Periferial });
            context.Locations.Add(new Location { LocationId = 61, Country = "Romania", City = "Sibiu", Placement = Zone.Central });
            context.Locations.Add(new Location { LocationId = 62, Country = "Romania", City = "Sibiu", Placement = Zone.Periferial });
            context.Locations.Add(new Location { LocationId = 63, Country = "Romania", City = "Slatina", Placement = Zone.Central });
            context.Locations.Add(new Location { LocationId = 64, Country = "Romania", City = "Slatina", Placement = Zone.Periferial });
            context.Locations.Add(new Location { LocationId = 65, Country = "Romania", City = "Slobozia", Placement = Zone.Central });
            context.Locations.Add(new Location { LocationId = 66, Country = "Romania", City = "Slobozia", Placement = Zone.Periferial });
            context.Locations.Add(new Location { LocationId = 67, Country = "Romania", City = "Suceava", Placement = Zone.Central });
            context.Locations.Add(new Location { LocationId = 68, Country = "Romania", City = "Suceava", Placement = Zone.Periferial });
            context.Locations.Add(new Location { LocationId = 69, Country = "Romania", City = "Targoviste", Placement = Zone.Central });
            context.Locations.Add(new Location { LocationId = 70, Country = "Romania", City = "Targoviste", Placement = Zone.Periferial });
            context.Locations.Add(new Location { LocationId = 71, Country = "Romania", City = "Targu Jiu", Placement = Zone.Central });
            context.Locations.Add(new Location { LocationId = 72, Country = "Romania", City = "Targu Jiu", Placement = Zone.Periferial });
            context.Locations.Add(new Location { LocationId = 73, Country = "Romania", City = "Targu Mures", Placement = Zone.Central });
            context.Locations.Add(new Location { LocationId = 74, Country = "Romania", City = "Targu Mures", Placement = Zone.Periferial });
            context.Locations.Add(new Location { LocationId = 75, Country = "Romania", City = "Timisoara", Placement = Zone.Central });
            context.Locations.Add(new Location { LocationId = 76, Country = "Romania", City = "Timisoara", Placement = Zone.Periferial });
            context.Locations.Add(new Location { LocationId = 77, Country = "Romania", City = "Tulcea", Placement = Zone.Central });
            context.Locations.Add(new Location { LocationId = 78, Country = "Romania", City = "Tulcea", Placement = Zone.Periferial });
            context.Locations.Add(new Location { LocationId = 79, Country = "Romania", City = "Vaslui", Placement = Zone.Central });
            context.Locations.Add(new Location { LocationId = 80, Country = "Romania", City = "Vaslui", Placement = Zone.Periferial });
            context.Locations.Add(new Location { LocationId = 81, Country = "Romania", City = "Zalau", Placement = Zone.Central });
            context.Locations.Add(new Location { LocationId = 82, Country = "Romania", City = "Zalau", Placement = Zone.Periferial });







            Profile profile1 = new Profile { ProfileId = 1, FirstName = "Andrei", LastName = "Popescu", Age = 19, GenderType = Gender.Male, LocationId = 19 };
            Profile profile2 = new Profile { ProfileId = 2, FirstName = "Alexanda", LastName = "Ionescu", Age = 20, GenderType = Gender.Female, LocationId = 27 };
            Profile profile3 = new Profile { ProfileId = 3, FirstName = "Daniel", LastName = "Baltariu", Age = 19, GenderType = Gender.Male, LocationId = 28 };
            Profile profile4 = new Profile { ProfileId = 4, FirstName = "Andreea", LastName = "Stanculescu", Age = 20, GenderType = Gender.Female, LocationId = 19 };
            Profile profile5 = new Profile { ProfileId = 5, FirstName = "Stefan", LastName = "Popescu", Age = 22, GenderType = Gender.Others, LocationId = 75 };

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