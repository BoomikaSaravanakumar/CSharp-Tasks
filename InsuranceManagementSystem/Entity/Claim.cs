using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceManagementSystem.Entity
{
    public class Claim
    {
        public int ClaimId {  get; set; }
        public string ClaimNumber { get; set; }
        public DateTime DateFiled { get; set; }
        public float ClaimAmount {  get; set; }
        public string Status { get; set; }
        public int PolicyId { get; set; }
        public int ClientId { get; set; }

        public Claim()
        {
            
        }

        public Claim(int claimId,string clientNumber,DateTime dateFiled,float claimAmount,string status,int policyId,int clientId)
        {
            ClaimId = claimId;
            ClaimNumber = clientNumber;
            ClaimAmount = claimAmount;
            Status = status;
            PolicyId = policyId;
            ClientId = clientId;    
            
        }
    }
}
