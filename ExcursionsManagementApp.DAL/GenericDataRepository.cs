using ExcursionsManagementApp.DomainModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace ExcursionsManagementApp.DAL
{
    public class GenericDataRepository<T> : IGenericDataRepository<T> where T : class
    {
        public virtual IList<T> GetAll(params Expression<Func<T, object>>[] navigationProperties)
        {
            List<T> list;
            // for short living contexts its better to use eager loading
            using (var context = new Entities())
            {
                // To implement LINQ-providers to external 
                // data let's use the interface IQueryable <T>
                // it doesn't load all set to memory unlike IEnumerable
                IQueryable<T> dbQuery = context.Set<T>();

                // eager loading
                foreach(var navProperty in navigationProperties)
                {
                    dbQuery = dbQuery.Include<T, object>(navProperty);
                }
                list = dbQuery
                    .AsNoTracking() // don't track any changes
                    .ToList();
            }
            return list;
        }
        // now a method with "where" 
        public virtual IList<T> GetList(Func<T, bool> where, 
            params Expression<Func<T, object>>[] navigationProperties)
        {
            List<T> list;
            using(var context = new Entities())
            {
                IQueryable<T> dbQuery = context.Set<T>();

                foreach(var navProperty in navigationProperties)
                {
                    dbQuery = dbQuery.Include<T, object>(navProperty);
                }
                list = dbQuery
                    .AsNoTracking()
                    .Where(where)
                    .ToList();
            }
            return list;
        }

        public virtual T GetSingle(Func<T, bool> where, 
            params Expression<Func<T, object>>[] navigationProperties)
        {
            T item = null;

            using(var context = new Entities())
            {
                IQueryable<T> dbQuery = context.Set<T>();

                foreach(var navProperty in navigationProperties)
                {
                    dbQuery = dbQuery.Include<T, object>(navProperty);
                }
                item = dbQuery
                    .AsNoTracking()
                    .FirstOrDefault(where);
            }
            return item;
        }

        public virtual void Add(params T[] items)
        {
            using(var context = new Entities())
            {
                foreach(var item in items)
                {
                    context.Entry(item).State = EntityState.Added;
                }
                context.SaveChanges();
            }
        }

        public virtual void Update(params T[] items)
        {
            using (var context = new Entities())
            {
                foreach(var item in items)
                {
                    context.Entry(item).State = EntityState.Modified;
                }
            }
        }

        public virtual void Remove(params T[] items)
        {
            using(var context = new Entities())
            {
                foreach(var item in items)
                {
                    context.Entry(item).State = EntityState.Deleted;
                }
                context.SaveChanges();
            }
        }
    }
}
