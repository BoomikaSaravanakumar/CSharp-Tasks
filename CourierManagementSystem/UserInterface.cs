using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierDatabaseConnection
{
    internal class UserInterface
    {
        public int GetServiceId()
        {
            Console.WriteLine("Enter ServiceId:");
            return int.Parse(Console.ReadLine());   
        }
        public string GetServiceName()
        {
            Console.WriteLine("Enter ServiceName:");
            return Console.ReadLine();
        }
        public int GetCourierId()
        {
            Console.WriteLine("Enter the CourierId:");
            return int.Parse(Console.ReadLine());
        }

        public decimal GetCost()
        {
            Console.WriteLine("Enter the Cost:");
            return decimal.Parse(Console.ReadLine());
        }

        public string GetStatus() 
        {
            Console.WriteLine("Enter the Courier Status:");
            return Console.ReadLine();
        }
    }
    }

