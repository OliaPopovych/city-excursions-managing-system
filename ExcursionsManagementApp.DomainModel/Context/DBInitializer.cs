using ExcursionsManagementApp.DomainModel.Entities;
using System.Data.Entity;

namespace ExcursionsManagementApp.DomainModel.Context
{
    public class DBInitializer : DropCreateDatabaseAlways<ExcurDbContext>
    {
        protected override void Seed(ExcurDbContext context)
        {          
            var user = new User()
            {
                FirstName = "olia",
                LastName = "p",
                Login = "olia",
                //pass = 123
                Password = "202cb962ac59075b964b07152d234b70",
                IsDisable = false
            };

            context.Users.Add(user);

            context.SaveChanges();

            base.Seed(context);

        }
    }
}
