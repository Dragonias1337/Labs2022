using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class car
    {
        private string name = "car01";

        public string Name
            { get { return name; } }
               
    }

    internal class CarsCatalog
    {
        private List<car> cars;

        public CarsCatalog()
        {
            cars = new List<car>();
            cars.Add(new car());
            cars.Add(new car());

        }

        internal List<car> Cars { get => cars; set => cars = value; }

        public string this[int index]
        {
            get { return cars[index].Name; }


        }
    }
}

