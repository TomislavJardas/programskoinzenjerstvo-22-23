using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programsko.Interfaces
{
    internal interface ITrain
    {
        int SmallVehicleCapacity { get; }
        int LargeVehicleCapacity { get; }
        double SmallVehicleTicketPrice { get; }
        double LargeVehicleTicketPrice { get; }
        void ParkVehicle(IVehicle vehicle);
    }
}
