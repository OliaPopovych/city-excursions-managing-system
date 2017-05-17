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

    public class CustomerRepositories : GenericDataRepository<Customer>, ICustomerRepository
    {
    }
    public class GuideRepositories : GenericDataRepository<Guide>, IGuideRepository
    {
    }
    public class PlaceRepositories : GenericDataRepository<Place>, IPlaceRepository
    {
    }
    public class ShEntryRepositories : GenericDataRepository<ScheduleEntry>, IShEntryRepository
    {
    }
    public class TourRepositories : GenericDataRepository<Tour>, ITourRepository
    {
    }
}
