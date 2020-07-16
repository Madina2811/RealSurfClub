using RealSurfClub.Models.DBModels;
using System.Data.Entity;

namespace RealSurfClub.DAL
{
    public class SurfDbInitializer : DropCreateDatabaseAlways<SurfDbContext>
       // DropCreateDatabaseIfModelChanges<SurfDbContext>
    {
        protected override void Seed(SurfDbContext context)
        {
            var user = new User
            {
                Nickname = "vsel",
                LastName = "Старозубов",
                Name = "Всеволод",
                Email = "vsel@star.ru",
                About = "Я такой хороший!"
            };
            context.Users.Add(user);
            context.SaveChanges();
        }
    }
}