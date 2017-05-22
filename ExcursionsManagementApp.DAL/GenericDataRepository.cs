using ExcursionsManagementApp.DomainModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Diagnostics;
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
            using (var context = new ExcurDbContext())
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
            using(var context = new ExcurDbContext())
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

            using(var context = new ExcurDbContext())
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
            try {
                using (var context = new ExcurDbContext())
                {
                    foreach (var item in items)
                    {
                        // Maby use attach
                        context.Entry(item).State = EntityState.Added;
                    }
                    context.SaveChanges();
                }
            }
            catch (DbUpdateException e)
            {
                Debug.WriteLine(e.InnerException.Message);
                //foreach(var eve in e.EntityValidationErrors)
                //{
                //    Debug.WriteLine($@"Entity of type {eve.Entry.Entity.GetType().Name} 
                //                      in state {eve.Entry.State} has the following errors:");
                //    foreach(var ve in eve.ValidationErrors)
                //    {
                //        Debug.WriteLine("- Property: \"{0}\", Value: \"{1}\", Error: \"{2}\"",
                //ve.PropertyName,
                //eve.Entry.CurrentValues.GetValue<object>(ve.PropertyName),
                //ve.ErrorMessage);
                //    }
                //}
                //throw;
            }
            
        }

        public virtual void Update(params T[] items)
        {
            using (var context = new ExcurDbContext())
            {
                foreach(var item in items)
                {
                    context.Entry(item).State = EntityState.Modified;
                }
                context.SaveChanges();
            }
        }

        public virtual void Remove(params T[] items)
        {
            using(var context = new ExcurDbContext())
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
