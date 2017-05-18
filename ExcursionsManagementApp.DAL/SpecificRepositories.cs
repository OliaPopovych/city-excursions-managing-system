using ExcursionsManagementApp.DomainModel;
using ExcursionsManagementApp.DomainModel.Entities;

/// <summary>
/// This interfaces and clases are created in case any additional
/// specific logic needs to be implemented for each entity type.
/// </summary>
namespace ExcursionsManagementApp.DAL
{
    public interface ICustomerRepository : IGenericDataRepository<Customer>
    {
    }
    public interface IGuideRepository : IGenericDataRepository<Guide>
    {
    }
    public interface IPlaceRepository : IGenericDataRepository<Place>
    {
    }
    public interface IShEntryRepository : IGenericDataRepository<ScheduleEntry>
    {
    }
    public interface ITourRepository : IGenericDataRepository<Tour>
    {
    }
    public interface IUserRepository : IGenericDataRepository<User>
    {
    }

    public class CustomerRepository : GenericDataRepository<Customer>, ICustomerRepository
    {
    }
    public class GuideRepository : GenericDataRepository<Guide>, IGuideRepository
    {
    }
    public class PlaceRepository : GenericDataRepository<Place>, IPlaceRepository
    {
    }
    public class ShEntryRepository : GenericDataRepository<ScheduleEntry>, IShEntryRepository
    {
    }
    public class TourRepository : GenericDataRepository<Tour>, ITourRepository
    {
    }
    public class UserRepository : GenericDataRepository<User>, IUserRepository
    {
    }
}
