using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourierDatabaseConnection.ConnectionUtil;
using CourierDatabaseConnection.Entity;
using CourierDatabaseConnection;


namespace CourierDatabaseConnection.DAO
{
    internal class CourierServiceDb
    {
        SqlConnection con = null;
        SqlCommand command = null;


        public int AddCourier(CourierServices courier)
        {
            int rows= 0;
            string query = $"insert into courierServices(serviceid,servicename,courierid,cost,status) values(@sid,@sname,@cid,@cost,@status)";
            try
            {
                using (con = DBConnection.GetConnection())
                {
                    command = new SqlCommand(query, con);
                    command.Parameters.Add(new SqlParameter("@sid", courier.ServiceId));
                    command.Parameters.Add(new SqlParameter("@sname", courier.ServiceName));
                    command.Parameters.Add(new SqlParameter("@cid", courier.CourierId));
                    command.Parameters.Add(new SqlParameter("@cost", courier.Cost));
                    command.Parameters.Add(new SqlParameter("@status", courier.Status));

                    rows = command.ExecuteNonQuery();

                }
            }
            catch (SqlException e)
            {
                throw e;
            }
            catch (Exception ex)
            {
                throw new Exception("Could not add Courier");
            }
            return rows;
        }


        public int DeleteCourier(int id)
        {
            int rowsAffected = 0;
            string query = $"delete from courierservices where serviceid=@id";
            try
            {
                using (con = DBConnection.GetConnection())
                {
                    command = new SqlCommand(query, con);
                    command.Parameters.Add(new SqlParameter("@id", id));
                    rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected <= 0)
                    {
                        throw new ServiceIdNotFoundException("Id Couldn't found and deleted");
                    }
                    
                }
            }
            catch(ServiceIdNotFoundException s)
            {
                Console.WriteLine(s.Message);
            }
            
            catch (Exception e)
            {
                throw new Exception("Error of removing the courier");
            }

            return rowsAffected;
        }


        public CourierServices GetCourierByServiceId(int id)
        {
            CourierServices services = null;
            string query = "select * from courierservices where serviceid=@id";
            try
            {
                using (con = DBConnection.GetConnection())
                {
                    command = new SqlCommand(query, con);
                    command.Parameters.Add(new SqlParameter("@id", id));
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        services = new CourierServices();
                        services.ServiceId = (int)reader["serviceid"];
                        services.ServiceName = (string)reader["servicename"];
                        services.CourierId = (int)reader["courierid"];
                        services.Cost = (decimal)reader["cost"];
                        services.Status = (string)reader["status"];
                    }
                }
                if (services == null)
                {
                    throw new ServiceIdNotFoundException("Id not found");
                }
            }
            catch(ServiceIdNotFoundException s)
            {
                Console.WriteLine(s.Message);
            }
            catch (Exception e)
            {
                throw new Exception("Error of fetching Courier");
            }
            return services;
        }




        public int UpdateCourierCost(int id, decimal newCost)
        {
            int rowsAffected = 0;
            CourierServices services = GetCourierByServiceId(id);
            if (services == null)
            {
                throw new Exception("Product id doesnot found");
            }
            else
            {
                string query = "update courierservices set cost=@cost where serviceid=@sid";
                try
                {
                    using (con = DBConnection.GetConnection())
                    {
                        command = new SqlCommand(query, con);
                        command.Parameters.Add(new SqlParameter("@sid", id));
                        command.Parameters.Add(new SqlParameter("@cost", newCost));
                        rowsAffected = command.ExecuteNonQuery();
                    }
                    if(rowsAffected < 0)
                    {
                        throw new ServiceIdNotFoundException("Id doesnot exists");
                    }
                }
                catch(ServiceIdNotFoundException s)
                {
                    Console.WriteLine (s.Message);
                }
                catch (Exception e)
                {
                    throw new Exception("could not update");
                }
                return rowsAffected;
            }
        }

        public Dictionary<string, int> GenerateShipmentStatusReport()
        {
            string query = "select status,count(*) as count from courierServices group by status;";
            Dictionary<string, int> result = new Dictionary<string, int>();
            try
            {
                using (con = DBConnection.GetConnection())
                {
                    command = new SqlCommand(query, con);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string status =(string) reader["Status"];
                        int count = (int)(reader["count"]);
                        result[status] = count;
                    }

                }
            }
            catch (Exception e)
            {
                throw new Exception("Cannot Track the status");
            }
            return result;
        }


        public decimal GetRevenueReport()
        {
            
            decimal revenue = 0;
            string query = "select sum(cost) as revenue from courierservices ";
            try
            {
                using (con = DBConnection.GetConnection())
                {
                    command = new SqlCommand(query, con);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        revenue = (decimal)reader["revenue"];
                         
                    }

                }

            }
            catch (Exception e)
            {
                throw new Exception("Cannot access Revenue");
            }
            return revenue;
        }

        public  List<CourierServices> GetCourierByServiceName(string serviceName)
        {
            List<CourierServices> services = new List<CourierServices>();
            string query = "select * from courierservices where servicename=@serviceName";
            try
            {
                using (con = DBConnection.GetConnection())
                {
                    command = new SqlCommand(query, con);
                    command.Parameters.Add(new SqlParameter("@serviceName", serviceName));
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        CourierServices s = new CourierServices
                        {
                            ServiceId = (int)reader["serviceid"],
                            ServiceName = (string)reader["servicename"],
                            CourierId = (int)reader["courierid"],
                            Cost = (decimal)reader["cost"],
                            Status = (string)reader["status"]
                        };
                        services.Add(s);
                    }
                }
                if (services == null || services.Count == 0)
                {
                    throw new ServiceIdNotFoundException("No courier found with this service name");
                }
            }
            catch (ServiceIdNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                throw new Exception("Error of fetching Courier");
            }
            return services;
        }

    }
    }
