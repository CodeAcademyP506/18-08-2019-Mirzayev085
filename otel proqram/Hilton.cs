using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otel_proqram
{
    public class Hilton : hotels
    {
        hotels hiltonHotel = new hotels();
        rooms hiltonRoom = new rooms();
        


        public string hotelInfo()
        {
            hotelAddress = "Neftchiler Ave.";
            hotelName = "Hilton hotel";
            hotelPrice = "Starts from 200AZN per night";
            hotelServices = "Free wifi";
            return "Hotel name: " + hotelName + "\n" + "Hotel Address: " + hotelAddress +
                 "\n" + "Hotel price: " + hotelPrice + "\n" + "Hotel services include: " + hotelServices;
        }

        
    }
}
