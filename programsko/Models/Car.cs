using programsko.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programsko.Models
{
    internal class Car: IVehicle
    {
        public double Gas { get; set; }

        public double GasPrice { get; } = 50;

        public double TicketPrice { get; } = 50;

        public void RefillGas()
        {

        }
    }
}
