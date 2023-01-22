using programsko.Interfaces;
using programsko.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programsko
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Pleas select train type(small, large): ");
            string data = GetData();
            ITrain train = SetTrain(data);
            Console.WriteLine("Pleas select vehicle type(car, truck): ");
            data = GetData();
            List<IVehicle> vehicles = new List<IVehicle>();
            SetCar(data, vehicles);        
            Worker worker = new Worker("a","b", 0.1);
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine($"{worker.PaymentCalculation(vehicles.Count,50)}");

        }

        private static void SetCar(string data, List<IVehicle> vehicles)
        {
            if (data.ToLower().Equals("car"))
            {
                vehicles.Add(new Car());
            }
            else if (data.ToLower().Equals("truck"))
            {
                vehicles.Add(new Truck());
            }
            else { throw new NotImplementedException(); }
        }

        private static ITrain SetTrain(string data)
        {
            if (data.ToLower().Equals("small")) {
                return new SmallTrain();
            }
            else if (data.ToLower().Equals("large"))
            {
                return new LargeTrain();
            }
            else { throw new NotImplementedException(); }
        }

        private static string GetData()
        {
            return Console.ReadLine();
        }
    }
}
