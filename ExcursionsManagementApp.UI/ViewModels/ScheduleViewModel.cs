using ExcursionsManagementApp.BL;
using ExcursionsManagementApp.DomainModel;

namespace ExcursionsManagementApp.UI.ViewModels
{
    public class ScheduleViewModel : CommandBase<ScheduleEntry>
    {
        private ExcurDbContext dbContext;
        BusinessLayer businessLayer;

        public ScheduleViewModel()
        {
            businessLayer = new BusinessLayer();
            dbContext = new ExcurDbContext();
            var list = businessLayer.GetAllSchedule();
            foreach (var item in list)
            {
                Collection.Add(item);
            }
        }

        protected override void Get(object parameter)
        {
            
        }
        protected override void Save(object parameter)
        {
            
        }
        protected override void Delete(object parameter)
        {
           
        }
    }
}

