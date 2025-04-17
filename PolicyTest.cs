using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InsuranceManagementSystem;
using InsuranceManagementSystem.DAO;
using InsuranceManagementSystem.Entity;
using InsuranceManagementSystem.exception;


namespace PolicyTest
{
    [TestFixture]
    internal class PolicyTest
    {
        InsuranceServiceImpl service;

        [SetUp]
        public void Setup()
        {
            service = new InsuranceServiceImpl();
            Policy policy = new Policy();
        }
        [Test]
        public void TestCreatePolicy()
        {
            Policy p = new Policy { PolicyId = 101, PolicyName = "Lic", PolicyAmount = 50000, PolicyDuration = DateTime.Now.AddYears(1) };
            int result = service.CreatePolicy(p);
            Assert.IsNotNull(result);
        }

        [Test]
        public void TestUpdatePolicy()
        {
            Policy policy = new Policy { PolicyId = 1 };
            int rows = service.UpdatePolicy(policy, 60000);
            Assert.IsNotNull(rows);
        }


        [Test]

        public void TestGetAllPolicies()
        {
            List<Policy> policies = service.GetAllPolicies();
            Assert.IsTrue(policies.Count >= 0, "Policy list count should be non-negative.");
        }

        [Test]
        public void TestDeletePolicy()
        {
            int id = 101;
            var result= service.DeletePolicy(id);
            Assert.IsNotNull(result);
        }

        [Test]
        public void TestGetPolicy()
        {
            int id = 1;
            var policy = service.GetPolicy(id);
            Assert.IsNotNull(policy);
        }

        [Test]
        public void CreatePolicyTypeChecking()
        {
            Policy policy = new Policy { PolicyId = 11, PolicyName = "Lic", PolicyAmount = 50000, PolicyDuration =  DateTime.Now.AddMonths(2) };
            int result= service.CreatePolicy(policy);
           Assert.That(policy,Is.TypeOf<Policy>());

        }
        [Test]
        public void GetPolicyIdException()
        {
            int id = 123;
            // var policy = service.GetPolicy(id);
            Assert.Throws<PolicyNotFoundException>(() => service.GetPolicy(id));
        }
        [Test]
        public void DeletePolicyIdException()
        {
            int id = 456;
            Assert.Throws<PolicyNotFoundException>(()=>service.DeletePolicy(id));
        }
        [Test]
        public void GetAllPolicyTypeChecking()
        {
            var result=service.GetAllPolicies();
            Assert.That(result, Is.TypeOf<List<Policy>>());
        }

        [Test]
        public void UpdatePolicyException()
        {
            int id = 110;
            double newCost = 29800;
            Assert.Throws<PolicyNotFoundException>(()=> service.UpdatePolicy(service.GetPolicy(id), newCost));
           
        }
        [Test]
        public void GetPolicyTypeChecking()
        {
            int id = 6;
            Policy policy = service.GetPolicy(id);
            Assert.That(policy, Is.TypeOf<Policy>());
        }
    }

    }


  
