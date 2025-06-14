using CourierDatabaseConnection.DAO;
using CourierDatabaseConnection.Entity;

namespace CourierDatabaseConnection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CourierServiceDb db = new CourierServiceDb();
            UserInterface ui = new UserInterface();
            bool exit = true;

            while (exit)
            {
                Console.WriteLine("\nFunctions:\n 1. AddProduct\n 2. GetCourierByServiceName\n 3. GetRevenue\n 4. GetShipmentStatus and UpdateCost\n 5. GetCourierByServiceId\n 6. Delete a Courier\n 7. Exit");
                Console.Write("Enter your choice to perform: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        // AddProduct
                        try
                        {
                            CourierServices cs = new CourierServices();
                            cs.ServiceId = ui.GetServiceId();
                            cs.ServiceName = ui.GetServiceName();
                            cs.CourierId = ui.GetCourierId();
                            cs.Cost = ui.GetCost();
                            cs.Status = ui.GetStatus();
                            int add = db.AddCourier(cs);
                            Console.WriteLine(add);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                        }
                        break;

                    case 2:
                        // GetCourierByServiceName
                        try
                        {
                            string name = ui.GetServiceName();
                            List<CourierServices> couSer = db.GetCourierByServiceName(name);
                            foreach(var cou in couSer)
                            {
                                Console.WriteLine(cou);
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                        }
                        break;

                    case 3:
                        // GetRevenue
                        try
                        {
                            decimal revenue = db.GetRevenueReport();
                            Console.WriteLine($"Total Revenue: {revenue}");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                        }
                        break;

                    case 4:
                        // GetShipmentStatus
                        try
                        {
                            Dictionary<string, int> status = db.GenerateShipmentStatusReport();
                            foreach (var item in status)
                            {
                                Console.WriteLine($"{item.Key} => {item.Value}");
                            }

                            // UpdateCost
                            int id = ui.GetServiceId();
                            decimal cost = ui.GetCost();
                            int result = db.UpdateCourierCost(id, cost);
                            Console.WriteLine($"Updated rows: {result}");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                        }
                        break;

                    case 5:
                        // GetCourierByServiceId
                        try
                        {
                            int id = ui.GetServiceId();
                            CourierServices sc = db.GetCourierByServiceId(id);
                            if (sc != null)
                            {
                                Console.WriteLine(sc);
                            }
                            else
                            {
                                Console.WriteLine($"Table does not contain the service ID: {id}");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                        }
                        break;

                    case 6:
                        // Delete a Courier
                        try
                        {
                            int id = ui.GetServiceId();
                            int res = db.DeleteCourier(id);
                            Console.WriteLine($"Deleted rows: {res}");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                        }
                        break;

                    case 7:
                        // Exit
                        Console.WriteLine("Exiting...");
                        exit = false;
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 7.");
                        break;
                }
            }
        }

        static void Display(List<CourierServices> Couriers)
        {
            foreach (CourierServices cs1 in Couriers)
            {
                Console.WriteLine(cs1);
            }
        }
    }
}
