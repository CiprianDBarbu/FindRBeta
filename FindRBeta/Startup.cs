using FindRBeta.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FindRBeta.Startup))]
namespace FindRBeta
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CreateAdminAndUserRoles();
        }

        private void CreateAdminAndUserRoles()
        {
            var ctx = new ApplicationDbContext();
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(ctx));
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(ctx));

            if(!roleManager.RoleExists("Admin"))
            {
                var role = new IdentityRole
                {
                    Name = "Admin"
                };
                roleManager.Create(role);

                var admin = new ApplicationUser();
                admin.UserName = "admin@admin.com";
                admin.Email = "admin@admin.com";

                var adminCreated = userManager.Create(admin, "Adminadmin1!");
                if(adminCreated.Succeeded)
                {
                    userManager.AddToRole(admin.Id, "Admin");
                }
            }

            if(!roleManager.RoleExists("Editor"))
            {
                var role = new IdentityRole
                {
                    Name = "Editor"
                };
                roleManager.Create(role);
            }
        }
    }
}
