using ExcursionsManagementApp.BL;
using ExcursionsManagementApp.DomainModel;
using System;

namespace ExcursionsManagementApp.UI.ViewModels
{
    public class ScheduleViewModel : CommandBase<ScheduleEntry>
    {
        public ScheduleEntry SelectedItem { get; set; }
        BusinessLayer businessLayer;

        public ScheduleViewModel()
        {
            businessLayer = new BusinessLayer();
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
            var parameters = parameter as Tuple<string, string>;
            ScheduleEntry shEntry = new ScheduleEntry();
            shEntry.TourName = parameters.Item1;
            shEntry.StartTime = Convert.ToDateTime(parameters.Item2);
            shEntry.TourID = 1;

            if(shEntry.TourName != string.Empty && shEntry.StartTime != null)
            {
                businessLayer.AddScheduleEntry(shEntry);
                Collection.Add(shEntry);
            }          
        }
        protected override void Delete(object parameter)
        {
            if(SelectedItem != null)
            {
                businessLayer.RemoveScheduleEntry(SelectedItem);
                Collection.Remove(SelectedItem);
            }         
        }
    }
}

