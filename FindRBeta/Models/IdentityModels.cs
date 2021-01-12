using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace FindRBeta.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer<ApplicationDbContext>(new Initp());
        }

        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Housing> Housings { get; set; }
        public DbSet<Ad> Ads { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }


    public class Initp : DropCreateDatabaseIfModelChanges<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            if (!roleManager.RoleExists("Editor"))
            {
                roleManager.Create(new IdentityRole("Editor"));
            }
            var user1 = new ApplicationUser
            {
                UserName = "ciprian1@email.com",
                Email = "ciprian1@email.com"
            };
            var userCreated1 = userManager.Create(user1, "Testtest1!");
            if (userCreated1.Succeeded)
            {
                userManager.AddToRole(user1.Id, "Editor");
            }



            var user2 = new ApplicationUser
            {
                UserName = "ciprian2@email.com",
                Email = "ciprian2@email.com"
            };
            var userCreated2 = userManager.Create(user2, "Testtest1!");
            if (userCreated2.Succeeded)
            {
                userManager.AddToRole(user2.Id, "Editor");
            }


            var user3 = new ApplicationUser
            {
                UserName = "ciprian3@email.com",
                Email = "ciprian3@email.com"
            };
            var userCreated3 = userManager.Create(user3, "Testtest1!");
            if (userCreated3.Succeeded)
            {
                userManager.AddToRole(user3.Id, "Editor");
            }




            var user4 = new ApplicationUser
            {
                UserName = "ciprian4@email.com",
                Email = "ciprian4@email.com"
            };
            var userCreated4 = userManager.Create(user4, "Testtest1!");
            if (userCreated4.Succeeded)
            {
                userManager.AddToRole(user4.Id, "Editor");
            }




            var user5 = new ApplicationUser
            {
                UserName = "ciprian5@email.com",
                Email = "ciprian5@email.com"
            };
            var userCreated5 = userManager.Create(user5, "Testtest1!");
            if (userCreated5.Succeeded)
            {
                userManager.AddToRole(user5.Id, "Editor");
            }


            //Location SEED
            context.Locations.Add(new Location { LocationId = 1, Country = "Romania", City = "Alba-Iulia", Placement = Zone.Central });
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




            //Housing SEED
            context.Housings.Add(new Housing { HousingId = 1, Link = "https://www.olx.ro/oferta/garsoniera-de-inchiriat-IDeq6lo.html#bb6f20793c;promoted", Price = 1100, NoOfRooms = 1, LocationId = 15 });
            context.Housings.Add(new Housing { HousingId = 2, Link = "https://www.olx.ro/oferta/inchiriez-apartament-2-camere-studio-coresi-avantgarden-brasov-IDer4E6.html#c48a4bf265;promoted", Price = 1900, NoOfRooms = 2, LocationId = 16 });
            context.Housings.Add(new Housing { HousingId = 3, Link = "https://www.olx.ro/oferta/chirie-apartament-3-camere-lujerului-IDenLrR.html#0ede99b094;promoted", Price = 1900, NoOfRooms = 3, LocationId = 19 });
            context.Housings.Add(new Housing { HousingId = 4, Link = "https://www.olx.ro/oferta/chirie-apartament-3-camere-unirii-camera-de-comert-caut-coleg-IDeh0B5.html#0ede99b094;promoted", Price = 950, NoOfRooms = 3, LocationId = 19 });
            context.Housings.Add(new Housing { HousingId = 5, Link = "https://www.olx.ro/oferta/garsoniera-chirie-IDdVUEb.html#0abeddb25a;promoted", Price = 900, NoOfRooms = 1, LocationId = 19 });
            context.Housings.Add(new Housing { HousingId = 6, Link = "https://www.storia.ro/ro/oferta/urgent-gars-prima-chirie-in-residence-militari-1000lei-IDk6GY.html", Price = 1000, NoOfRooms = 1, LocationId = 19 });
            context.Housings.Add(new Housing { HousingId = 7, Link = "https://www.olx.ro/oferta/garsoniera-chirie-IDerhis.html#0ede99b094", Price = 1000, NoOfRooms = 1, LocationId = 20 });
            context.Housings.Add(new Housing { HousingId = 8, Link = "https://www.storia.ro/ro/oferta/apartament-2-camere-chirie-rond-pipera-penny-IDlJYz.html", Price = 2500, NoOfRooms = 2, LocationId = 20 });
            context.Housings.Add(new Housing { HousingId = 9, Link = "https://www.storia.ro/ro/oferta/apartament-cu-4-camere-162-mp-3-terase-garaj-zona-strazii-buna-IDlyrS.html", Price = 4000, NoOfRooms = 4, LocationId = 25 });
            context.Housings.Add(new Housing { HousingId = 10, Link = "https://www.olx.ro/oferta/inchiriez-apartament-2-camere-manastur-IDeq6Pn.html#2a0d862cf5;promoted", Price = 2000, NoOfRooms = 2, LocationId = 25 });
            context.Housings.Add(new Housing { HousingId = 11, Link = "https://www.storia.ro/ro/oferta/apartament-2-camere-semidecomandat-gheorgheni-aleea-padis-IDkiYO.html", Price = 1500, NoOfRooms = 2, LocationId = 26 });
            context.Housings.Add(new Housing { HousingId = 12, Link = "https://www.olx.ro/oferta/inchiriere-apartament-IDereOH.html#9d238f6d60;promoted", Price = 2400, NoOfRooms = 4, LocationId = 27 });
            context.Housings.Add(new Housing { HousingId = 13, Link = "https://www.olx.ro/oferta/inchiriez-apartament-2-camere-la-casa-zona-centrala-promenada-mall-IDedZlj.html#93e8e400cc;promoted", Price = 1200, NoOfRooms = 2, LocationId = 61 });
            context.Housings.Add(new Housing { HousingId = 14, Link = "https://www.olx.ro/oferta/chirie-fara-garantie-pe-termne-scurt-comisioane-0-IDdqorY.html#4e1af1f3e1;promoted", Price = 1000, NoOfRooms = 1, LocationId = 75 });
            context.Housings.Add(new Housing { HousingId = 15, Link = "https://www.olx.ro/oferta/apartament-2-camere-linistit-langa-iulius-mall-IDdYaml.html#4e1af1f3e1;promoted", Price = 1600, NoOfRooms = 2, LocationId = 75 });



            //Ads SEED
            context.Ads.Add(new Ad { AdId = 1, ProfileId = 1, Housing = context.Housings.Find(3), HousingYear = 2021, HousingMonth = "09", HousingDay = "15" });
            context.Ads.Add(new Ad { AdId = 2, ProfileId = 2, Housing = context.Housings.Find(4), HousingYear = 2021, HousingMonth = "10", HousingDay = "01" });
            context.Ads.Add(new Ad { AdId = 3, ProfileId = 4, Housing = context.Housings.Find(5), HousingYear = 2021, HousingMonth = "10", HousingDay = "01" });
            context.Ads.Add(new Ad { AdId = 4, ProfileId = 5, Housing = context.Housings.Find(7), HousingYear = 2021, HousingMonth = "09", HousingDay = "01" });


            Profile profile1 = new Profile { ProfileId = 1, FirstName = "Andrei", LastName = "Popescu", Age = 19, GenderType = Gender.Male, LocationId = 19, AplicationUserName = "ciprian1@email.com" };
            Profile profile2 = new Profile { ProfileId = 2, FirstName = "Alexanda", LastName = "Ionescu", Age = 20, GenderType = Gender.Female, LocationId = 27, AplicationUserName = "ciprian2@email.com" };
            Profile profile3 = new Profile { ProfileId = 3, FirstName = "Daniel", LastName = "Baltariu", Age = 19, GenderType = Gender.Male, LocationId = 28, AplicationUserName = "ciprian3@email.com" };
            Profile profile4 = new Profile { ProfileId = 4, FirstName = "Andreea", LastName = "Stanculescu", Age = 20, GenderType = Gender.Female, LocationId = 19, AplicationUserName = "ciprian4@email.com" };
            Profile profile5 = new Profile { ProfileId = 5, FirstName = "Stefan", LastName = "Popescu", Age = 22, GenderType = Gender.Others, LocationId = 75, AplicationUserName = "ciprian5@email.com" };

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