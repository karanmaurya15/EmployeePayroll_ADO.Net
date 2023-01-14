using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollService_ADO.Net
{
    public class EmployeePayrollService
    {
        public static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Payroll_Service;";
        public string AddEmployeeInDB(EmployeePayroll employeePayroll)
        {
            SqlConnection sQLConnection = new SqlConnection(connectionString);
            try
            {
                using (sQLConnection)
                {
                    sQLConnection.Open();
                    SqlCommand command = new SqlCommand("SPAddNewEmployee", sQLConnection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Id", employeePayroll.Id);
                    command.Parameters.AddWithValue("@Name", employeePayroll.Name);
                    command.Parameters.AddWithValue("@Salary", employeePayroll.Salary);
                    command.Parameters.AddWithValue("@Start", employeePayroll.Start);
                    command.Parameters.AddWithValue("@Gender", employeePayroll.Gender);
                    command.Parameters.AddWithValue("@PhoneNumber", employeePayroll.PhoneNumber);
                    command.Parameters.AddWithValue("@Address", employeePayroll.Address);
                    int result = command.ExecuteNonQuery();
                    sQLConnection.Close();
                    if (result >= 1)
                    {
                        Console.WriteLine("Employee Added Successfully");
                    }
                    else
                    {
                        Console.WriteLine("No Data found");
                    }
                }
                return "Employee Added Successfully";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
        public string RetrieveEntriesFromEmployeePayDB()
        {
            SqlConnection sqlconnection = new SqlConnection(connectionString);
            try
            {
                List<EmployeePayroll> employee = new List<EmployeePayroll>();
                using (sqlconnection)
                {
                    sqlconnection.Open();
                    SqlCommand command = new SqlCommand("SPRetrieveAllDetails", sqlconnection);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader dr = command.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            EmployeePayroll emp = new EmployeePayroll();
                            emp.Id = dr.GetInt32(0);
                            emp.Name = dr.GetString(1);
                            emp.Salary = dr.GetInt64(2);
                            emp.Start = dr.GetDateTime(3);
                            emp.Gender = dr.GetString(4);
                            emp.PhoneNumber = dr.GetInt64(5);
                            emp.Address = dr.GetString(6);
                            employee.Add(emp);
                        }
                        Console.WriteLine("ID" + " " + "Name" + "  " + "Salary" + "  " + "Start" + "  " + "Gender" + "  " + "  " + "PhoneNumber" + " " + "Address");
                        foreach (var data in employee)
                        {
                            Console.WriteLine(data.Id + " " + data.Name + " " + data.Salary + " " + data.Start + " " + data.Gender + " " + data.PhoneNumber + " " + data.Address);
                        }
                    }
                    else
                    {
                        Console.WriteLine("No Database Found");
                    }
                }
                return "Retrive data Successfully";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
    }
}
