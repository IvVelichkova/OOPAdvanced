using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Roster
{
    public class Employee
    {
        private string name;
        private decimal salary;
        private string position;
        private string department;
        private string email;
        private int age;

        public Employee(string name, decimal salary, string position, string department)
        {
            this.name = name;
            this.salary = salary;
            this.position = position;
            this.department = department;
        }

        public Employee(string name, decimal salary, string position, string department, string email, int age)
            : this(name, salary, position, department)
        {
            this.email = email;
            this.age = age;
        }

        public string Name { get; }


        public decimal Salary { get; }


        public string Department { get; }


        public string Email { get; }


        public int Age { get; }

    }
}
