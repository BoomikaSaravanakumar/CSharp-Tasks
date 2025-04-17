using InsuranceManagementSystem.DAO;
using InsuranceManagementSystem.Entity;
using InsuranceManagementSystem.exception;

namespace InsuranceManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InsuranceServiceImpl service = new InsuranceServiceImpl();
            UserInterface ui = new UserInterface();
            bool exit = true;

            while (exit)
            {
                Console.WriteLine("\nInsurance Management Services:");
                Console.WriteLine(" 1. Create a Policy");
                Console.WriteLine(" 2. Get the Policy by ID");
                Console.WriteLine(" 3. Get All Policies");
                Console.WriteLine(" 4. Update Policy Amount");
                Console.WriteLine(" 5. Delete Policy");
                Console.WriteLine(" 6. Exit");
                Console.Write("Enter your choice: ");
                int choice=int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        try
                        {
                            Policy policy = new Policy();

                            policy.PolicyId = ui.GetPolicyId();
                            policy.PolicyName = ui.GetPolicyName();
                            policy.PolicyAmount = ui.GetPolicyAmount();
                            policy.PolicyDuration = ui.GetPolicyDuration();
                            
                            int result = service.CreatePolicy(policy);
                            Console.WriteLine(result > 0 ? "Policy created successfully." : "Failed to create policy.");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Could not insert policy: " + ex.Message);
                        }
                        break;

                    case 2:
                        try
                        {
                            int id = ui.GetPolicyId();
                            Policy policy = service.GetPolicy(id);
                            Console.WriteLine(policy);
                            
                        }
                        catch(PolicyNotFoundException p)
                        {
                            Console.WriteLine("Policy not found"+p.Message);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Could not fetch policy: " + e.Message);
                        }
                        break;

                    case 3:
                        try
                        {

                            List<Policy> policies = service.GetAllPolicies();
                            foreach (Policy p in policies)
                            {
                                Console.WriteLine(p);
                            }
                            
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Could not fetch policies: " + e.Message);
                        }
                        break;

                    case 4:
                        try
                        {
                            int id = ui.GetPolicyId();
                            double newAmount = ui.GetPolicyAmount();
                            Policy p = new Policy { PolicyId = id };
                            int result = service.UpdatePolicy(p, newAmount);
                            Console.WriteLine(result > 0 ? "Policy updated successfully." : "Update failed.");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Could not update policy: " + e.Message);
                        }
                        break;

                    case 5:
                        try
                        {
                            int id = ui.GetPolicyId();
                            int result = service.DeletePolicy(id);
                            Console.WriteLine(result > 0 ? "Policy deleted successfully." : "Policy not found.");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Could not delete policy: " + e.Message);
                        }
                        break;

                    case 6:
                        Console.WriteLine("Thank you for using Insurance Management System.");
                        exit = false;
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}

