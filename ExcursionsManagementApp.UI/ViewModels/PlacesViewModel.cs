using ExcursionsManagementApp.BL;
using ExcursionsManagementApp.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcursionsManagementApp.UI.ViewModels
{
    public class PlacesViewModel : CommandBase<Place>
    {
        BusinessLayer businessLayer;

        public PlacesViewModel()
        {
            businessLayer = new BusinessLayer();

            var list = businessLayer.GetAllPlaces();
            foreach(var item in list)
            {
                Collection.Add(item);
            }
        }

        #region CommandBase overriden methods
        protected override void Get(object parameter)
        {
            throw new NotImplementedException();
        }
        protected override void Save(object parameter)
        {
            Place place = new Place();
            place.PlaceName = parameter as string;

            if(place.PlaceName != string.Empty)
            {
                businessLayer.AddPlace(place);
                Collection.Add(place);
            }        
        }
        protected override void Delete(object parameter)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
