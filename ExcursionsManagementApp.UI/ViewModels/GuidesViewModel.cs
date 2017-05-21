using ExcursionsManagementApp.BL;
using ExcursionsManagementApp.DomainModel;
using ExcursionsManagementApp.UI.Views;
using System;

namespace ExcursionsManagementApp.UI.ViewModels
{
    public class GuidesViewModel : CommandBase<Guide>
    {
        BusinessLayer businessLayer;

        //#region Guides fields

        //public int GuideID
        //{
        //    get { return GuideID; }
        //    set { GuideID = value; OnPropertyChanged("GuideID"); }
        //}

        //public string FirstName
        //{
        //    get { return FirstName; }
        //    set { FirstName = value; OnPropertyChanged("FirstName"); }
        //}

        //public string LastName
        //{
        //    get { return LastName; }
        //    set { LastName = value; OnPropertyChanged("LastName"); }
        //}

        //#endregion

        public GuidesViewModel()
        {
            businessLayer = new BusinessLayer();
            var list = businessLayer.GetAllGuides();
            foreach(var item in list)
            {
                Collection.Add(item);
            }
        }

        protected override void Get(object parameter)
        {
            //var list = businessLayer.AddGuide();
        }
        protected override void Save(object parameter)
        {
            Tuple<string, string> initials = parameter as Tuple<string, string>;
            Guide guide = new Guide();
            guide.FirstName = initials.Item1;
            guide.LastName = initials.Item2;
            businessLayer.AddGuide(guide);
            // Changing all the collection of guides which is bad for performance
            // A way to bypass this is to create a wrapper class for each entity
            // And change only one property instead of all collection
            Collection.Add(guide);
        }
        protected override void Delete(object parameter)
        {
            //businessLayer.RemoveGuide();
        }
    }
}
