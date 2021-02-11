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
        public static bool IsExists(this List<Employee> list, Employee item)
        {
            return list.Contains(item);
        }

        public static List<T> GetAllEmployees<T>(this List<T> list)
        {
            return list;
        }

        public static int GetEmployeesCount<T>(this List<T> list)
        {
            return list.Count;
        }

        public static void PrintEmployees(this List<Employee> list)
        {
            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {list[i].Name} - {list[i].LastName} - {list[i].MiddleName} - Start work date: {list[i].StartWorkDate}");
            }
        }

    }
}
