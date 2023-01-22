using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using programsko.Interfaces;

namespace programsko.Models
{
    internal class LargeTrain : ITrain
    {
        private static ITrain _instance;
        public int SmallVehicleCapacity { get; } = 0;
        public int LargeVehicleCapacity { get; } = 6;
        public double SmallVehicleTicketPrice { get; } = 0;
        public double LargeVehicleTicketPrice { get; } = 70;

        public void ParkVehicle(IVehicle vehicle)
        {
        }
        public static ITrain Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new LargeTrain();
                }

                return _instance;
            }
        }
    }
}
