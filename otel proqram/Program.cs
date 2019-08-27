using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otel_proqram
{
    class Program
    {
        static void Main(string[] args)
        {
            Hilton hiltonHotel = new Hilton();
            Absheron absheronHotel = new Absheron();
            roomInfom absheronRoom = new roomInfom();

           
            Console.WriteLine("Qalmaq istediyiniz oteli sechin." + "\n");


            Console.WriteLine(hiltonHotel.hotelInfo() + "\n");
            Console.WriteLine(absheronHotel.hotelInfo() + "\n");

            Console.WriteLine("Hilton otel uchun 1 , Absheron otel uchun 2 yazin.");

            string sechim = Console.ReadLine();
            if(sechim == "1")
            {
                Console.WriteLine("Are you sure?");
                string answer = Console.ReadLine();
                if(answer == "yes")
                {
                    Console.WriteLine(absheronRoom.hotelInfo());

                }
            } else if(sechim == "2")
            {
                Console.WriteLine(hiltonHotel.hotelInfo());

            }




        }
    }
}
