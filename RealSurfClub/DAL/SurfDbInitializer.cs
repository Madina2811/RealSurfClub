using RealSurfClub.Models.DBModels;
using System.Data.Entity;
using System;
namespace RealSurfClub.DAL
{
    public class SurfDbInitializer : DropCreateDatabaseAlways<SurfDbContext>
    //DropCreateDatabaseIfModelChanges<SurfDbContext>
    {
        protected override void Seed(SurfDbContext context)
        {
            var user = new User
            {
                Nickname = "vsel",
                Password = "123456",
                LastName = "Старозубов",
                Name = "Всеволод",
                Email = "vsel@star.ru",
                About = "Я такой хороший!"
            };


            
            var post1 = new Post
            {
                Text = "Первый тестовый пост",
                PublishDate = DateTime.Now,
                Author = user
             };

            var post2 = new Post
            {
                Text = "Второй тестовый пост",
                PublishDate = DateTime.Now,
                Author = user
            };
            

            context.Users.Add(user);
            //context.Posts.Add(post1);
            //context.Posts.Add(post2);
            context.SaveChanges();
        }
    }
}