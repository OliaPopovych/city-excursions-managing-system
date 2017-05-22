using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcursionsManagementApp.UI.ViewModels
{
    /// <summary>
    /// Removes all elements from collection with given condition
    /// </summary>
    /// Imagine you delete a tour from tours table.
    /// But you have some schedule entries with that tour in schedule table.
    /// This situation should be handled and all schedule entries
    /// with removed tour need to be deleted too.
    public static class CollectionExtensionMethods
    {
        public static void RemoveAll<T>(this ObservableCollection<T> collection, Func<T, bool> condition)
        {
            var itemsToRemove = collection.Where(condition).ToList();

            foreach(var item in itemsToRemove)
            {
                collection.Remove(item);
            }
        }
    }
}
