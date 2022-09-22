using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Lab2
{
    internal class VehicleYard
    {
        private Vehicle[] vehicles;

        public VehicleYard(params Vehicle[] _vehicles)
        {
            vehicles = _vehicles;
        }
        
        /*public void Showstats()
        {
            foreach (Vehicle V in vehicles)
            {
                string type = Convert.ToString(V.GetType());
                if (type == "Plane")
                {
                    Console.WriteLine($"Plane's coordinates are:", V.Xcord, V.Ycord);
                    Console.WriteLine($"Plane's price is ", V.Price);
                    Console.WriteLine($"Plane's height is", V.Height);
                    Console.WriteLine($"Plane's speed is", V.Speed);
                    Console.WriteLine($"Plane's year of manufacturing is", V.YearOfManufact);
                    Console.WriteLine($"Plane has", V.Passengers, "passengers");

                }
                if (type == "Car")
                {
                    Console.WriteLine($"Car's coordinates are:", V.Xcord, V.Ycord);
                    Console.WriteLine($"Car's price is ", V.Price);
                    Console.WriteLine($"Plane's speed is", V.Speed);
                    Console.WriteLine($"Plane's year of manufacturing is", V.YearOfManufact);
                }
                if (type == "Ship")
                {
                    Console.WriteLine($"Ships's coordinates are:", V.Xcord, V.Ycord);
                    Console.WriteLine($"Ships's price is ", V.Price);
                    Console.WriteLine($"Ships's speed is", V.Speed);
                    Console.WriteLine($"Ship's year of manufacturing is", V.YearOfManufact);
                    Console.WriteLine($"Ship has", V.Passengers, "passengers");
                    Console.WriteLine($"Ships's homeport is", V.Speed);
                }

            }
        }*/
    }
}
