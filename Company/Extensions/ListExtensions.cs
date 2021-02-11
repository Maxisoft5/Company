using System;
using System.Collections.Generic;
using System.Text;
using Company.Models.Abstraction;
using System.Linq;
using System.Collections;

namespace Company.Extensions
{
    public static class LinqExtensions 
    {
        public static bool IsExists(this List<Employee> list, Employee employee)
        {
            return list.Contains(employee);
        }

        public static List<T> GetAllEmployees<T>(this IEnumerable employees)
        {
            return employees.OfType<T>().ToList();
        }

        public static int GetEmployeesCount<T>(this IEnumerable employees)
        {
            return employees.GetAllEmployees<T>().Count;
        }

        public static void PrintEmployees(this IEnumerable<Employee> list)
        {
            foreach(var emp in list)
            {
                Console.WriteLine($"Employee: {emp.Name} - {emp.LastName} - {emp.MiddleName} - Start work date: {emp.StartWorkDate}");
            }
        }

    }
}
