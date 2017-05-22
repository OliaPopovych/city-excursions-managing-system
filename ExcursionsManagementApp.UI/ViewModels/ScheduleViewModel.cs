using ExcursionsManagementApp.BL;
using ExcursionsManagementApp.DomainModel;
using System;

namespace ExcursionsManagementApp.UI.ViewModels
{
    public class ScheduleViewModel : CommandBase<ScheduleEntry>
    {
        public ScheduleEntry SelectedDatagridItem { get; set; }
        public Tour SelectedTour { get; set; }
        public DateTime SelectedDate { get; set; }

        // if item in collection here will be removed
        // than we remove it from other collections
        // Pass id of remowed scheduleEntry
        public static Action<int> rowRemoved;

        BusinessLayer businessLayer;

        public ScheduleViewModel()
        {
            businessLayer = new BusinessLayer();
            var list = businessLayer.GetAllSchedule();
            foreach (var item in list)
            {
                Collection.Add(item);
            }

            ToursViewModel.tourRemoved += TourRemoved;
        }

        #region CommandBase overriden methods
        protected override void Get(object parameter)
        {
            
        }
        protected override void Save(object parameter)
        {
            ScheduleEntry shEntry = new ScheduleEntry();
            shEntry.TourName = SelectedTour.TourName;
            shEntry.StartTime = SelectedDate;
            //shEntry.Tour = SelectedTour; this row makes new Tour in database
            shEntry.TourID = SelectedTour.TourID;

            if(shEntry.TourName != string.Empty && shEntry.StartTime != null)
            {
                businessLayer.AddScheduleEntry(shEntry);
                Collection.Add(shEntry);
            }          
        }
        protected override void Delete(object parameter)
        {
            if(SelectedDatagridItem != null)
            {
                OnRowRemoved(SelectedDatagridItem.ScheduleEntryID);
                businessLayer.RemoveScheduleEntry(SelectedDatagridItem);
                Collection.Remove(SelectedDatagridItem);     
            }         
        }
        #endregion

        public void OnRowRemoved(int id)
        {
            rowRemoved?.Invoke(id);
        }

        public void TourRemoved(int id)
        {
            OnRowRemoved(id);
            Collection.RemoveAll(s => s.TourID == id);
        }
    }
}

