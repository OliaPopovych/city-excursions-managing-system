using ExcursionsManagementApp.BL;
using ExcursionsManagementApp.DomainModel;

namespace ExcursionsManagementApp.UI.ViewModels
{
    public class SalesViewModel : CommandBase<Customer>
    {
        public Customer SelectedItem { get; set; }
        BusinessLayer businessLayer;

        public SalesViewModel()
        {
            businessLayer = new BusinessLayer();
            var list = businessLayer.GetAllCustomers();
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
                businessLayer.RemoveCustomer(SelectedItem);
                Collection.Remove(SelectedItem);
            }
        }
    }
}
