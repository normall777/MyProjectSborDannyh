using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using LibraryModel;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;
using System.Data.Entity.Migrations;

namespace LibraryWeb.Models
{
    // Чтобы добавить данные профиля для пользователя, можно добавить дополнительные свойства в класс ApplicationUser. Дополнительные сведения см. по адресу: http://go.microsoft.com/fwlink/?LinkID=317594.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Обратите внимание, что authenticationType должен совпадать с типом, определенным в CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Здесь добавьте утверждения пользователя
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, DataContextConfiguration>());
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        public virtual DbSet<UserBook> Books { get; set; }
    }
    internal sealed class DataContextConfiguration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public DataContextConfiguration()
        {
            AutomaticMigrationsEnabled = true;
        }
    }


    public class UserBook
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("UserId")]
        public virtual ApplicationUser User { get; set; }
        public string UserId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Town { get; set; }
        public string Izdatelstvo { get; set; }
        public int YearOfPublic { get; set; }
        public string ISBN { get; set; }
        public int SumOfBooks { get; set; }
        //public int CountOfStudent { get; set; }
        public virtual ICollection<UserStudent> Students { get; set; }
    }

    public class UserStudent
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Group { get; set; }
        public DateTime Vidacha { get; set; }
        public DateTime Sdacha { get; set; }

        public override string ToString()
        {
            string str = String.Format("{0,-20}                                \t{1,5:N1}      \t{2:dd.MM.yyyy}      \t{3:dd.MM.yyyy}", (Name + " " + Surname), Group, Vidacha, Sdacha);
            //string str = String.Format("{0,-20} \t{1,5:N1}", (Name + " " + Surname), Group) + $"\t{Vidacha.ToString("d")}    Выдано до {Sdacha.ToString("d")}";
            return str;
            //return $"{Name} {Surname} \t\t{Group} \t{Vidacha.ToString("d")}    Выдано до {Sdacha.ToString("d")}";
        }
    }
}