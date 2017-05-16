using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OstSysMVVM.Persistency;

namespace OstSysMVVM.Model
{
    class ApartmentCatalogSingleton
    {
        private static ApartmentCatalogSingleton instance = new ApartmentCatalogSingleton();

        public static ApartmentCatalogSingleton Instance
        {
            get { return instance; }
        }

        public ObservableCollection<Apartment> Apartments { get; set; }

        private ApartmentCatalogSingleton()
        {
            Apartments = new ObservableCollection<Apartment>();
            //Apartment a1 = new Apartment(45, "Holstebrogade 8", 37, 3, 444, 1222, 3,"left",true);
            //Apartment a2 = new Apartment(12, "Holstebrogade 8",24,2,333,124,1,"Left",false);
            //Apartments.Add(a1);
            //Apartments.Add(a2);
            Apartments = new ObservableCollection<Apartment>(new PersistenceFacade().GetApartments());

        }

        public void Add(int Apartment_ID, string Address, int Size, int Number_Of_Rooms, float BBR, float Foredelingstal, int Floor, string Side, bool Reserved)
        {
            Apartments.Add(new Apartment(Apartment_ID,Address,Size,Number_Of_Rooms,BBR,Foredelingstal,Floor,Side,Reserved));
        }

    }
}
