using ExcursionsManagementApp.BL;
using ExcursionsManagementApp.DomainModel;

namespace ExcursionsManagementApp.UI.ViewModels
{
    public class ToursViewModel : CommandBase<Tour>
    {
        public Tour SelectedItem { get; set; }
        BusinessLayer businessLayer;

        public ToursViewModel()
        {
            businessLayer = new BusinessLayer();
            var list = businessLayer.GetAllTours();
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
            if (SelectedItem != null)
            {
                businessLayer.RemoveTour(SelectedItem);
                Collection.Remove(SelectedItem);
            }
        }
    }
}
