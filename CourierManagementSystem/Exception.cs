using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierDatabaseConnection
{
   
        public class CourierIdNotFoundException : Exception
        {
            public CourierIdNotFoundException() : base("Courier ID not found.") { }
            public CourierIdNotFoundException(string message) : base(message) { }
           
        }

        public class ServiceIdNotFoundException : Exception
        {
            public ServiceIdNotFoundException() : base("Service ID not found.") { }
            public ServiceIdNotFoundException(string message) : base(message) { }
            
        }

    }
