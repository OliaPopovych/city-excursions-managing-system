using System;
using System.Collections.Generic;
using System.Linq.Expressions;

/// <summary>
/// Below is a generic interface which provides methods to query for all
/// entities, specific entities matching a given where predicate and 
/// a single entity as well as methods for inserting, updating and removing
/// an arbitrary number of entities
/// <summary>
namespace ExcursionsManagementApp.DAL
{
    public interface IGenericDataRepository<T> where T: class
    {
        IList<T> GetAll(params Expression<Func<T, object>>[] navigationProperties);
        IList<T> GetList(Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties);
        T GetSingle(Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties);
        void Add(params T[] items);
        void Update(params T[] items);
        void Remove(params T[] items);
    }
}
