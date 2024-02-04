using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.EntityLayer.Concrete
{
    public class Booking
    {
        public int BookingID { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public DateTime Checkin { get; set; }// giriş
        public DateTime CheckOut { get; set; }// çıkış
        public string AdultCount { get; set; }//Yetişkin Sayısı
        public string ChildCount { get; set; }// cocuk sayısı
        public string RoomCount { get; set; }//oda sayısı
        public string SpecialRequest { get; set; }//Özel istek
        public string Description { get; set; }
        public string Status { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
