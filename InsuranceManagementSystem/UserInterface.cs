using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceManagementSystem
{
    internal class UserInterface
    {
        public int GetPolicyId()
        {
            Console.WriteLine("Enter the Policy ID:");
            return int.Parse(Console.ReadLine());   
        }
        public string GetPolicyName()
        {
            Console.WriteLine("Enter the Policy Name:");
            return Console.ReadLine();
        }
        public float GetPolicyAmount()
        {
            Console.WriteLine("Enter the PolicyAmount:");
            return float.Parse(Console.ReadLine());
        }
        public DateTime GetPolicyDuration()
        {
            Console.WriteLine("Enter your policy Duration:");
            return DateTime.Parse(Console.ReadLine());
        }
    }
}
