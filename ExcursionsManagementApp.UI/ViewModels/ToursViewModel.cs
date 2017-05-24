using ExcursionsManagementApp.BL;
using ExcursionsManagementApp.DomainModel;
using System;
using System.Collections.Generic;

namespace ExcursionsManagementApp.UI.ViewModels
{
    public class ToursViewModel : CommandBase<Tour>
    {
        public Tour SelectedDatagridItem { get; set; }
        public Guide SelectedGuide { get; set; }
        public List<Place> SelectedPlaces { get; set; }

        BusinessLayer businessLayer;

        // if tour removed, scheduleEntry should be removed
        public static Action<int> tourRemoved;

        public ToursViewModel()
        {
            businessLayer = new BusinessLayer();
            var list = businessLayer.GetAllTours();
            foreach (var item in list)
            {
                Collection.Add(item);
            }
        }
        #region CommandBase overriden methods
        protected override void Get(object parameter)
        {

        }
        protected override void Save(object parameter)
        {
            var info = parameter as Tuple<string, string>;
            Tour tour = new Tour();
            tour.TourName = info.Item1;
            tour.Price = int.Parse(info.Item2);
            tour.GuideID = SelectedGuide.GuideID;

            if(SelectedPlaces != null){
                foreach (var place in SelectedPlaces)
                {
                    tour.Places.Add(place);
                }
            }
            if (tour.TourName != string.Empty)
            {
                businessLayer.AddTour(tour);
                Collection.Add(tour);
            }
        }
        protected override void Delete(object parameter)
        {
            if (SelectedDatagridItem != null)
            {
                OnTourRemoved(SelectedDatagridItem.TourID);
                businessLayer.RemoveTour(SelectedDatagridItem);
                Collection.Remove(SelectedDatagridItem);
            }
        }
        #endregion

        public void OnTourRemoved(int id)
        {
            tourRemoved?.Invoke(id);
        }
    }
}
