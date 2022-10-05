using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class sos
    {
        private string name = "huesos";

        public string Name
            { get { return name; } }
               
    }

    internal class CarsCatalog
    {
        private List<sos> soses;

        public CarsCatalog()
        {
            Soses = new List<sos>();
            Soses.Add(new sos());
            Soses.Add(new sos());
        }

        internal List<sos> Soses { get => soses; set => soses = value; }

        public string this[int index]
        {
            get { return soses[index].Name; }
        }
    }
}

