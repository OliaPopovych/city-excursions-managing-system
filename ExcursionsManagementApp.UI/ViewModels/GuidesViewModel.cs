using ExcursionsManagementApp.BL;
using ExcursionsManagementApp.DomainModel;
using ExcursionsManagementApp.UI.ViewModels;

namespace ExcursionsManagementApp.UI.ViewModels
{
    public class GuidesViewModel : CommandBase<Guide>
    {
        private ExcurDbContext dbContext;
        BusinessLayer businessLayer;
        
        public GuidesViewModel()
        {
            businessLayer = new BusinessLayer();
            dbContext = new ExcurDbContext();
            var list = businessLayer.GetAllGuides();
            foreach(var item in list)
            {
                Collection.Add(item);
            }
        }

        protected override void Get()
        {
            //var list = businessLayer.AddGuide();
        }
        protected override void Save()
        {
            Guide guide = new Guide();
            //guide.FirstName = 

            //var list = businessLayer.AddGuide();
        }
        protected override void Delete()
        {
            //businessLayer.RemoveGuide();
        }
    }
}
