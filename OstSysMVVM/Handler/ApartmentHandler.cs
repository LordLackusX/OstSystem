using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OstSysMVVM.Model;
using OstSysMVVM.Persistency;
using OstSysMVVM.ViewModel;

namespace OstSysMVVM.Handler
{
    class ApartmentHandler
    {
        public ApartmentViewModel ApartmentViewModel { get; set; }

        public ApartmentHandler(ApartmentViewModel apartmentViewModel)
        {
            ApartmentViewModel = apartmentViewModel;
        }

        public void CreateApartment()
        {
            Apartment aApartment = new Apartment();
            aApartment.Apartment_ID = ApartmentViewModel.NewApartment.Apartment_ID;
            aApartment.Address = ApartmentViewModel.NewApartment.Address;
            aApartment.BBR = ApartmentViewModel.NewApartment.BBR;
            aApartment.Number_Of_Rooms = ApartmentViewModel.NewApartment.Number_Of_Rooms;
            aApartment.Floor = ApartmentViewModel.NewApartment.Floor;
            aApartment.Foredelingstal = ApartmentViewModel.NewApartment.Foredelingstal;
            aApartment.Side = ApartmentViewModel.NewApartment.Side;
            aApartment.Size = ApartmentViewModel.NewApartment.Size;
            aApartment.Reserved = ApartmentViewModel.NewApartment.Reserved;

          new PersistenceFacade().SaveApartment(aApartment);




        }
     
    }
}
