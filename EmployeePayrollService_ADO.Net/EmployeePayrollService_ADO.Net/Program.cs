namespace EmployeePayrollService_ADO.Net
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeePayrollService employeePayrollServices = new EmployeePayrollService();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter the option : 1.AddEmployeePayroll \n 2.Exit :");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        EmployeePayroll employee = new EmployeePayroll()
                        {
                            Id = 1,
                            Name = "Amit",
                            Salary = 40000,
                            Start = DateTime.Now,
                            Gender = "M",
                            Address = "Rampuri Colony",
                            PhoneNumber = 123456789,
                        };
                        employeePayrollServices.AddEmployeeInDB(employee);
                        break;
                    case 2:
                        flag = false;
                        break;
                }
            }
        }
    }
}
