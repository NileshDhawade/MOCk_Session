using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mock_session
{
    public class Employee
    {
        public int EmpId
        {
            get { return empId; }
            set { empId = value; }
            
        }
        public String EmpName
        {
            get { return empName; }
            set { empName = value; }

        }

        public decimal EmpSalary
        {
            get { return empSalary; }
            set { empSalary = value; }

        }
        public string EmpCity
        {
            get { return empCity; }
            set { empCity = value; }
        }
        int empId;
        string empName;
        decimal empSalary;
        string empCity;

        public Employee()
        {

        }
        public Employee(int id,string name,decimal sal,string city)
        {
            empId = id;
            empName = name;
            empSalary = sal;
            empCity = city;

        }

       
        public override string ToString()
        {
            return "employee id is " + empId + "employee name is " + empName + "employee salary is " + empSalary + "employee city is " + empCity;
        }
    }
}
