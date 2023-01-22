using programsko.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programsko.Models
{
    internal class Truck : IVehicle
    {
        public double Gas { get; set; }
        public double GasPrice { get; } = 80;  
        public double TicketPrice { get; } = 80;
        public void RefillGas()
        {
        }
    }
}
