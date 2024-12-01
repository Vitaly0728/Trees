using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class Employee: IComparable<Employee>
    {
        public string Name {  get; private set; }
        public int Salary { get; private set; }

        public Employee(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }

        public int CompareTo(Employee other)
        {
            return Salary.CompareTo(other.Salary);
        }
    }
}
