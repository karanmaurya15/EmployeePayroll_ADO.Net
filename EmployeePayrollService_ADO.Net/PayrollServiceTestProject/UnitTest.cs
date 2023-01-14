using EmployeePayrollService_ADO.Net;

namespace PayrollServiceTestProject
{
    [TestClass]
    public class UnitTest
    {
        EmployeePayrollService employeePayrollServices = new EmployeePayrollService();
        [TestMethod]
        public void TestAddDataInDB()
        {
            EmployeePayroll employee = new EmployeePayroll()
            {
                Id = 1,
                Name = "Karan",
                PhoneNumber = 8976543210,
                Address = "Colony",
                Gender = "M",
                Start = DateTime.Now
            };
            string result = employeePayrollServices.AddEmployeeInDB(employee);
            Assert.AreEqual("Employee Added Successfully", result);
        }
        [TestMethod]
        public void TestRetriveDataFromDB()
        {
            string result = employeePayrollServices.RetrieveEntriesFromEmployeePayDB();
            Assert.AreEqual("Retrive data Successfully", result);
        }
    }
}