using System;
using System.Collections.Generic;
using System.Text;
using Company.Models.Abstraction;

namespace Company.Models
{
    public class Company
    {
        public List<Employee> Employees { get; set; }

        public Company()
        {
            Employees = new List<Employee>();
        }
      
    }
}
