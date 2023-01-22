using programsko.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace programsko.Models
{
    internal class Worker : IPerson
    {
        public string Name { get ; set ; }
        public string LName { get ; set ; }

        public double PerCardPercentage { get; }

        public Worker(string name, string lname, double perCardPercentage)
        {
            Name = name;
            LName = lname;
            PerCardPercentage = perCardPercentage;
        }

        public double PaymentCalculation(int numberOfCards, int price)
        {
            return PerCardPercentage*(numberOfCards * price);
        }
    }
}
