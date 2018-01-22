using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Budgetis_V0.Models
{
    // Vous pouvez ajouter des données de profil pour l'utilisateur en ajoutant plus de propriétés à votre classe ApplicationUser ; consultez http://go.microsoft.com/fwlink/?LinkID=317594 pour en savoir davantage.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Notez qu'authenticationType doit correspondre à l'élément défini dans CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Ajouter les revendications personnalisées de l’utilisateur ici
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<UserTest> UsersTest { get; set; }

        public DbSet<Categorie> Categories { get; set; }
        public DbSet<TypeCategorie> TypesCategorie { get; set; }
        public DbSet<SocialStatusType> SocialStatusTypes { get; set; }
        public DbSet<Tache> Taches { get; set; }
        public DbSet<Devise> Devises { get; set; }
        public DbSet<Income> Incomes { get; set; }
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {


            // COMMENT
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}