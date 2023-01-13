using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollService_ADO.Net
{
    public class EmployeePayroll
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long Salary { get; set; }
        public DateTime Start { get; set; }
        public string Gender { get; set; }
        public long PhoneNumber { get; set; }
        public string Address { get; set; }
    }
}
