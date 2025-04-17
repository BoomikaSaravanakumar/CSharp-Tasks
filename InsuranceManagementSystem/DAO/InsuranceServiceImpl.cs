using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InsuranceManagementSystem.Entity;
using InsuranceManagementSystem.Util;
using InsuranceManagementSystem.exception;
using InsuranceManagementSystem.DAO;

namespace InsuranceManagementSystem.DAO
{
    public class InsuranceServiceImpl : IPolicyService
    {
        SqlConnection con = null;
        SqlCommand cmd = null;

        public int CreatePolicy(Policy policy)
        {
            int row = 0;
            string query = "insert into policy (policyId, policyName, policyAmount, policyDuration) values (@policyId, @policyName, @policyAmount, @policyDuration)";
            try
            {
                using (con = DBConnection.GetConnection())
                {
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@policyId", policy.PolicyId);
                    cmd.Parameters.AddWithValue("@policyName", policy.PolicyName);
                    cmd.Parameters.AddWithValue("@policyAmount", policy.PolicyAmount);
                    cmd.Parameters.AddWithValue("@policyDuration", policy.PolicyDuration);
                    row = cmd.ExecuteNonQuery();

                    if (row <= 0)
                        throw new Exception("Insertion failed");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Could not insert Policy", ex);
            }
            return row;
        }

        public int DeletePolicy(int id)
        {
            int rows = 0;
            string query = "delete from policy where policyId=@id";
            try
            {
                using (con = DBConnection.GetConnection())
                {
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", id);
                    rows = cmd.ExecuteNonQuery();

                    if (rows <= 0)
                    {
                        throw new PolicyNotFoundException("Policy not found");
                    }
                }
            }
            catch (PolicyNotFoundException p)
            {
                throw new PolicyNotFoundException(p.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Could not delete the policy");
            }
            return rows;
        }

        public List<Policy> GetAllPolicies()
        {
            List<Policy> policies = new List<Policy>();
            Policy policy = null;
            string query = "select *  from policy";
            try
            {
                using (con = DBConnection.GetConnection())
                {
                    cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        policy = new Policy();

                        policy.PolicyId = (int)reader["policyId"];
                        policy.PolicyName = (string)reader["policyName"];
                        policy.PolicyAmount = (double)reader["policyAmount"];
                        policy.PolicyDuration = (DateTime)reader["policyDuration"];
                        policies.Add(policy);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Could not fetch policies", ex);
            }
            return policies;
        }

        public Policy GetPolicy(int id)
        {
            Policy policy = null;
            string query = "SELECT * FROM policy WHERE policyId=@id";
            try
            {
                using (con = DBConnection.GetConnection())
                {
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", id);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while(reader.Read())
                    {
                        policy = new Policy
                        {
                            PolicyId = (int)reader["policyId"],
                            PolicyName = (string)reader["policyName"],
                            PolicyAmount = (double)reader["policyAmount"],
                            PolicyDuration = (DateTime)reader["policyDuration"]
                        };
                    }
                    if (policy == null)
                    {
                        throw new PolicyNotFoundException($"Policy with ID {id} not found.");
                    }
                }
            }
            catch(PolicyNotFoundException p)
            {
                throw new PolicyNotFoundException(p.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Could not fetch the policy", ex);
            }
            return policy;
        }

        public int UpdatePolicy(Policy policy, double cost)
        {
            int rows = 0;
            string query = "UPDATE policy SET policyAmount=@cost WHERE policyId=@policyId";
            try
            {
                using (con = DBConnection.GetConnection())
                {
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@cost", cost);
                    cmd.Parameters.AddWithValue("@policyId", policy.PolicyId);
                    rows = cmd.ExecuteNonQuery();

                    if (rows <= 0)
                        throw new Exception("Could not update policy");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Update failed", ex);
            }
            return rows;
        }
    }
}

