using ExcursionsManagementApp.BL;
using ExcursionsManagementApp.DomainModel;
using System;

namespace ExcursionsManagementApp.UI.ViewModels
{
    public class SalesViewModel : CommandBase<Customer>
    {
        public Customer SelectedDatagridItem { get; set; }
        public ScheduleEntry SelectedShEntry { get; set; }
        BusinessLayer businessLayer;

        public SalesViewModel()
        {
            businessLayer = new BusinessLayer();
            var list = businessLayer.GetAllCustomers();
            foreach (var item in list)
            {
                Collection.Add(item);
            }
            // if tour will be deleted from schedule
            // than we delete all customers from observablecollection here
            ScheduleViewModel.rowRemoved += ScheduleEntryRemoved;
        }
        #region CommandBase overriden methods
        protected override void Get(object parameter)
        {

        }
        protected override void Save(object parameter)
        {
            var initials = parameter as Tuple<string, string>;
            Customer customer = new Customer();
            customer.FirstName = initials.Item1;
            customer.LastName = initials.Item2;
            customer.ScheduleEntryID = SelectedShEntry.ScheduleEntryID;

            if(customer.FirstName != string.Empty && customer.LastName != string.Empty)
            {
                businessLayer.AddCustomer(customer);
                Collection.Add(customer);
            }
        }
        protected override void Delete(object parameter)
        {
            if (SelectedDatagridItem != null)
            {
                businessLayer.RemoveCustomer(SelectedDatagridItem);
                Collection.Remove(SelectedDatagridItem);
            }
        }
        #endregion

        // 
        protected void ScheduleEntryRemoved(int id)
        {
            Collection.RemoveAll(c => c.ScheduleEntryID == id);
        }
    }
}
