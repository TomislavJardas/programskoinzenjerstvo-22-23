using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programsko.Interfaces
{
    internal interface IVehicle
    {
        double Gas { get; set; }
        double GasPrice { get; }
        double TicketPrice { get; }
        void RefillGas();

    }
}
