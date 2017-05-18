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

        public BusinessLayer()
        {
            userRepository = new UserRepository();
        }

        public void AddCustomer()
        {
            throw new NotImplementedException();
        }

        public void AddGuide()
        {
            throw new NotImplementedException();
        }

        public void AddPlace()
        {
            throw new NotImplementedException();
        }

        public void AddScheduleEntry()
        {
            throw new NotImplementedException();
        }

        public void AddTour()
        {
            throw new NotImplementedException();
        }

        public IList<Customer> GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        public IList<Guide> GetAllGuides()
        {
            throw new NotImplementedException();
        }

        public IList<Place> GetAllPlaces()
        {
            throw new NotImplementedException();
        }

        public IList<ScheduleEntry> GetAllSchedule()
        {
            throw new NotImplementedException();
        }

        public IList<Tour> GetAllTours()
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomerByName()
        {
            throw new NotImplementedException();
        }

        public Guide GetGuideByName()
        {
            throw new NotImplementedException();
        }

        public Tour GetTourByName()
        {
            throw new NotImplementedException();
        }

        public IList<ScheduleEntry> GetToursOnDay()
        {
            throw new NotImplementedException();
        }

        public User GetUserByLoginAndPassword(string login, string password)
        {
            return userRepository.GetSingle(u => u.Login.Equals(login));
        }

        public void RemoveCustomer()
        {
            throw new NotImplementedException();
        }

        public void RemoveGuide()
        {
            throw new NotImplementedException();
        }

        public void RemovePlace()
        {
            throw new NotImplementedException();
        }

        public void RemoveScheduleEntry()
        {
            throw new NotImplementedException();
        }

        public void RemoveTour()
        {
            throw new NotImplementedException();
        }
    }
}
