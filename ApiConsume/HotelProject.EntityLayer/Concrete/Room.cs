using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.EntityLayer.Concrete
{
    public class Room
    {
        public int RoomID { get; set; }
        public string RoomNumber { get; set; }
        public string RoomCoverImage { get; set; } // oda kapak fotografı
        public int Price { get; set; } // fiyat
        public string Title { get; set; } // başlık
        public string BedCount { get; set; } // Yatak Sayısı
        public string BathCount { get; set; }//Banyo Sayımı
        public string Wifi { get; set; }
        public string Description { get; set; } // acıklama
    }
}
