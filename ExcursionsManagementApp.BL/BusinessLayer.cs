using System;
using System.Collections.Generic;
using ExcursionsManagementApp.DomainModel;
using ExcursionsManagementApp.DomainModel.Entities;
using ExcursionsManagementApp.DAL;

namespace ExcursionsManagementApp.BL
{
    public class BusinessLayer : IBusinessLayer
    {
        private readonly IUserRepository userRepository;
        private readonly ITourRepository tourRepository;
        private readonly IShEntryRepository shRepository;
        private readonly IGuideRepository guideRepository;
        private readonly IPlaceRepository placeRepository;
        private readonly ICustomerRepository customerRepository;

        public BusinessLayer()
        {
            userRepository = new UserRepository();
            tourRepository = new TourRepository();
            shRepository = new ShEntryRepository();
            guideRepository = new GuideRepository();
            placeRepository = new PlaceRepository();
            customerRepository = new CustomerRepository();
        }

        public IList<ScheduleEntry> GetAllSchedule()
        {
            return shRepository.GetAll();
        }

        public IList<ScheduleEntry> GetToursOnDay()
        {
            throw new NotImplementedException();
        }

        public void AddScheduleEntry(ScheduleEntry shEntry)
        {
            shRepository.Add(shEntry);
        }

        public void RemoveScheduleEntry(ScheduleEntry shEntry)
        {
            shRepository.Remove(shEntry);
        }

        public IList<Tour> GetAllTours()
        {
            return tourRepository.GetAll();
        }

        public Tour GetTourByName(string tourName)
        {
            return tourRepository.GetSingle(t => t.TourName.Equals(tourName));
        }

        public void AddTour(Tour tour)
        {
            tourRepository.Add(tour);
        }

        public void RemoveTour(Tour tour)
        {
            tourRepository.Remove(tour);
        }

        public IList<Place> GetAllPlaces()
        {
            return placeRepository.GetAll();
        }

        public void AddPlace(Place place)
        {
            placeRepository.Add(place);
        }

        public void RemovePlace(Place place)
        {
            placeRepository.Remove(place);
        }

        public IList<Guide> GetAllGuides()
        {
            return guideRepository.GetAll();
        }

        public Guide GetGuideByName(string firstName, string lastName)
        {
            return guideRepository.GetSingle(g => g.FirstName.Equals(firstName) 
                                                && g.LastName.Equals(lastName));
        }

        public void AddGuide(Guide guide)
        {
            guideRepository.Add(guide);
        }

        public void RemoveGuide(Guide guide)
        {
            guideRepository.Remove(guide);
        }

        public IList<Customer> GetAllCustomers()
        {
            return customerRepository.GetAll();
        }

        public Customer GetCustomerByName(string firstName, string lastName)
        {
            return customerRepository.GetSingle(c => c.FirstName.Equals(firstName) 
                                                && c.LastName.Equals(lastName));
        }

        public void AddCustomer(Customer customer)
        {
            customerRepository.Add(customer);
        }

        public void RemoveCustomer(Customer customer)
        {
            customerRepository.Remove(customer);
        }

        public User GetUserByLoginAndPassword(string login, string password)
        {
            return userRepository.GetSingle(u => u.Login.Equals(login));
        }
    }
}
