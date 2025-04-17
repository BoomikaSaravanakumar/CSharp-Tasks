using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InsuranceManagementSystem.Entity;

namespace InsuranceManagementSystem.DAO
{
    internal interface IPolicyService
    {
        public int CreatePolicy(Policy policy);

        public Policy GetPolicy(int id);

        public List<Policy> GetAllPolicies();

        public int UpdatePolicy(Policy policy,double cost);
        public int DeletePolicy(int id);
    }
}
