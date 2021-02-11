using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Company.Models.Abstraction
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime StartWorkDate { get; set; }
        public DateTime EndWorkDate { get; set; }
        public abstract void Work();
        public static List<Employee> operator+(List<Employee> employees, Employee employee)
        {
            employees.Add(employee);
            return employees;
        }
        public static bool operator -(List<Employee> employees, Employee employee)
        {
            if(employees.Contains(employee) == false)
            {
                return false;
            }
            else
            {
                employees.Remove(employee);
                return true;
            }
        }
    }
}
