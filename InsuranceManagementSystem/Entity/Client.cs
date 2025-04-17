using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceManagementSystem.Entity
{
    public class Client
    {
        public int ClientId {  get; set; }
        public string ClientName { get; set; }
        public string ContactNum
        {
            get
            {
                return ContactNum;
            }
            set
            {
                if (value.Length == 12 && value[3] == '-' && value[7] == '-')
                {
                    ContactNum = value;
                }
            }

        }
        public int PolicyId {  get; set; }
        public string PolicyName { get; set; }

        public Client()
        {
            
        }

        public Client(int clientId,string clientName,string contactNum,int policyId,string policyName)
        {
            ClientId = clientId;
            ClientName = clientName;
            ContactNum = contactNum;
            PolicyId = policyId;
            PolicyName = policyName;
        }
    }
}
