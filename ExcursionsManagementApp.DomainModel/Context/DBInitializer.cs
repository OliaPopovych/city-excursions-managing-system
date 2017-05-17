using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcursionsManagementApp.DomainModel.Context
{
    public class DBInitializer : DropCreateDatabaseIfModelChanges<ExcurDbContext>
    {
        protected override void Seed(ExcurDbContext context)
        {
            /*var tours = new List<Tour>
            {

            };

            var schedule = new List<ScheduleEntry>
            {
               new ScheduleEntry { TourID = 1, Tour = tours.FirstOrDefault(t => t.TourID == 1),  Customers = new List<Customer>() },
            };
            schedule.ForEach(d => context.Schedule.Add(d));
            context.SaveChanges();

            IList<Customer> customers = new List<Customer>();

            customers.Add(new Customer()
            {
                FirstName = "Andrew",
                LastName = "Peters",
                ScheduleEntryID = 1,
                ScheduleEntry = departments.FirstOrDefault(d => d.DepartmentId == 1)
            });

            customers.Add(new Customer()
            {
                FirstName = "Brice",
                LastName = "Lambson",
                EnrollmentDate = DateTime.Parse(DateTime.Today.ToString())
            });

            customers.Add(new Customer()
            {
                FirstName = "Rowan",
                LastName = "Miller",
                EnrollmentDate = DateTime.Parse(DateTime.Today.ToString())
            });

            foreach (Customer student in customers)
                context.Customers.Add(student);
            base.Seed(context);*/

        }
    }
}
