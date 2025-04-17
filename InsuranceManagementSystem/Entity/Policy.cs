using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceManagementSystem.Entity
{
    public class Policy
    {
        public int PolicyId {  get; set; }
        public string PolicyName { get; set; }
        public double PolicyAmount { get; set; }
        public DateTime PolicyDuration { get; set; }

        public Policy()
        {
            
        }
        public Policy(int policyId,string policyName,float policyAmount,DateTime policyDuration  )
        {
            PolicyId = policyId;
            PolicyName = policyName;
            PolicyAmount = policyAmount;
            PolicyDuration = policyDuration;
        }
        public override string ToString()
        {
            return $"PolicyId:{PolicyId} PolicyName:{PolicyName} policyAmount:{PolicyAmount} ";
        }
    }
}
