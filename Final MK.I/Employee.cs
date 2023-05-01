using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_MK.I
{
    public class Employee
    {
        public Employee() { }


 


        public Employee(int id, string name, string subject, string detail)
        {
            EmployeeID = id;
            Name = name;
            Subject = subject;
            Detail = detail;

        }
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public string Detail { get; set; }


        public override string ToString()
        {
            return String.Format($"#{EmployeeID} |{Subject}| {Name}:\n{Detail}\n\n");
        }
    }
}
