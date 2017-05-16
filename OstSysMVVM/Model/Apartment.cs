using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OstSysMVVM.Model
{
    class Apartment
    {
        public int Apartment_ID { get; set; }
        public string Address { get; set; }
        public int Size { get; set; }
        public int Number_Of_Rooms { get; set; }
        public float BBR { get; set; }
        public float Foredelingstal { get; set; }
        public int Floor { get; set; }
        public string Side { get; set; }
        public bool Reserved { get; set; }

        public Apartment(int apartment_id, string address, int size, int number_of_rooms, float bbr, float foredelingstal, int floor, string side, bool reserved)
        {
            Apartment_ID = apartment_id;
            Address = address;
            Size = size;
            Number_Of_Rooms = number_of_rooms;
            BBR = bbr;
            Foredelingstal = foredelingstal;
            Floor = floor;
            Side = side;
            Reserved = reserved;
        }

        public Apartment()
        {
            
        }

        public override string ToString()
        {
            return $"{nameof(Apartment_ID)}: {Apartment_ID}, {nameof(Address)}: {Address}, {nameof(Size)}: {Size}, {nameof(Number_Of_Rooms)}: {Number_Of_Rooms}, {nameof(BBR)}: {BBR}, {nameof(Foredelingstal)}: {Foredelingstal}, {nameof(Floor)}: {Floor}, {nameof(Side)}: {Side}, {nameof(Reserved)}: {Reserved}";
        }
    }
}
