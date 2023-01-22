using programsko.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programsko.Models
{
    internal class SmallTrain : ITrain
    {
        public int SmallVehicleCapacity { get; } = 8;
        public int LargeVehicleCapacity { get; } = 0;
        public double SmallVehicleTicketPrice { get; } = 50;
        public double LargeVehicleTicketPrice { get; } = 0;

        public void ParkVehicle(IVehicle vehicle)
        {
        }
    }
}
