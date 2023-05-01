using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_MK.I
{
    public class Department
    {
        private string _departmentName;
        private List<Employee> _employees;


        public Department()
        {

        }
        public Department(string courseName, List<Employee> employees)
        {
            _departmentName = courseName;
            _employees = employees;

        }

        public string DepartmentName { get { return _departmentName; } set { _departmentName = value; } }

        public List<Employee> GetEmployees { get { return _employees    ; } set { _employees = value; } }
    }
}
