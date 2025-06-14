using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierDatabaseConnection.Entity
{
    internal class CourierServices
    {
        public int ServiceId {  get; set; }
        public string ServiceName { get; set; }
        public int CourierId {  get; set; }
        public decimal Cost {  get; set; }
        public string Status { get; set; }
        public override string ToString()
        {
            return $"{ServiceId} {ServiceName} {Cost} {CourierId}";
        }
    }
}
