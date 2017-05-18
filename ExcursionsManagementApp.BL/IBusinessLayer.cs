using ExcursionsManagementApp.DomainModel;
using ExcursionsManagementApp.DomainModel.Entities;
using System.Collections.Generic;

namespace ExcursionsManagementApp.BL
{
    public interface IBusinessLayer
    {
        IList<ScheduleEntry> GetAllSchedule();
        IList<ScheduleEntry> GetToursOnDay();
        void AddScheduleEntry(ScheduleEntry shEntry);
        void RemoveScheduleEntry(ScheduleEntry shEntry);

        IList<Tour> GetAllTours();
        Tour GetTourByName(string tourName);
        void AddTour(Tour tour);
        void RemoveTour(Tour tour);

        IList<Place> GetAllPlaces();
        void AddPlace(Place place);
        void RemovePlace(Place place);

        IList<Guide> GetAllGuides();
        Guide GetGuideByName(string firstName, string lastName);
        void AddGuide(Guide guide);
        void RemoveGuide(Guide guide);

        IList<Customer> GetAllCustomers();
        Customer GetCustomerByName(string firsttName, string lastName);
        void AddCustomer(Customer customer);
        void RemoveCustomer(Customer customer);

        User GetUserByLoginAndPassword(string login, string password);

    }
}
