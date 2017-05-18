using ExcursionsManagementApp.DomainModel;
using ExcursionsManagementApp.DomainModel.Entities;
using System.Collections.Generic;

namespace ExcursionsManagementApp.BL
{
    public interface IBusinessLayer
    {
        IList<ScheduleEntry> GetAllSchedule();
        IList<ScheduleEntry> GetToursOnDay();
        void AddScheduleEntry();
        void RemoveScheduleEntry();

        IList<Tour> GetAllTours();
        Tour GetTourByName();
        void AddTour();
        void RemoveTour();

        IList<Place> GetAllPlaces();
        void AddPlace();
        void RemovePlace();

        IList<Guide> GetAllGuides();
        Guide GetGuideByName();
        void AddGuide();
        void RemoveGuide();

        IList<Customer> GetAllCustomers();
        Customer GetCustomerByName();
        void AddCustomer();
        void RemoveCustomer();

        User GetUserByLoginAndPassword(string login, string password);

    }
}
