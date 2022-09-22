using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Lab2
{
    static class VehicleYard
    {
        static public void ShowVehicleStats(params Vehicle[] vehicles)
        {
            foreach (var V in vehicles)
            {
                V.ShowStats();
            }
        }       
        
    }
}
