using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programsko.Interfaces
{
    internal interface IPerson
    {
        string Name { get; set; }
        string LName { get; set; }
        double PerCardPercentage { get; }

        double PaymentCalculation(int numberOfCards, int price);
    }
}
