using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using SalesWebApp.Models;

[assembly: OwinStartupAttribute(typeof(SalesWebApp.Startup))]
namespace SalesWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            createRolesandUsers();
        }

        private void createRolesandUsers()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));


            // Cek apakah role admin sudah ada asdasd
            if (!roleManager.RoleExists("Back Office"))
            {

                // Jika tidak ada buat role-nya
                var role = new IdentityRole();
                role.Name = "Back Office";
                roleManager.Create(role);

                //Buat default user admin				
                var user = new ApplicationUser();
                user.UserName = "admin";
                user.Email = "admin@tes.com";

                string userPWD = "Okedeh-123";

                var chkUser = UserManager.Create(user, userPWD);

                //Tambahkan user ke role admin
                if (chkUser.Succeeded)
                {
                    var result1 = UserManager.AddToRole(user.Id, "Back Office");

                }
            }
            
            if (!roleManager.RoleExists("Sys Admin"))
            {
                // Jika tidak ada buat role-nya
                var role = new IdentityRole();
                role.Name = "Sys Admin";
                roleManager.Create(role);
            }
        }
    }
}
