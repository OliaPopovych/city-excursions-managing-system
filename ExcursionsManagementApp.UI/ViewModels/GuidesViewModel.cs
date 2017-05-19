using ExcursionsManagementApp.BL;
using ExcursionsManagementApp.DomainModel;
using ExcursionsManagementApp.UI.ViewModels.Base;

namespace ExcursionsManagementApp.UI.ViewModels
{
    public class GuidesViewModel : CommandBase<Guide>
    {
        private ExcurDbContext dbContext = new ExcurDbContext();
        BusinessLayer businessLayer = new BusinessLayer();
        
        public GuidesViewModel()
        {
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
            //var list = businessLayer.AddGuide();
        }
        protected override void Delete()
        {
            //businessLayer.RemoveGuide();
        }
    }
}
