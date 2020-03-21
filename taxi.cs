
using System;

//Taxi.cs
namespace Taxi
{
    class Taxi {

        //property
        public string DriverName;
        public Boolean OnDuty;
        public int NumPassenger;

        //method
        public void TaxiInfo () {
            Console.WriteLine("Driver Name : " + this.DriverName);
            if(OnDuty == true) {
                Console.WriteLine("On Duty : yes");
            } else if(OnDuty == false) {
                Console.WriteLine("On Duty : no");
            }
            Console.WriteLine("Number Of Passenger : " + this.NumPassenger);
        }

        public void PickUpPassenger() {
            Console.WriteLine( this.DriverName + " sedang menjemput penumpang");
        }

        public void DropOffPassenger() {
            Console.Write( this.DriverName + " selesai mengantar penumpang");
        }



    }
}

//Program.cs

namespace Taxi {
    class Program {

        static void Main(string[] args) {

            Taxi taxi = new Taxi();

            taxi.DriverName = "Jono";
            taxi.OnDuty = true;
            taxi.NumPassenger = 10;

            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();

            Console.ReadKey();

          
        }

    }

}