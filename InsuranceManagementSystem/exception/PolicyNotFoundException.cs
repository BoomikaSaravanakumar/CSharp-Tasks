using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceManagementSystem.exception
{
    internal class PolicyNotFoundException:Exception
    {
       public PolicyNotFoundException():base() { }
       public  PolicyNotFoundException (string message):base(message) { }
    }
}
