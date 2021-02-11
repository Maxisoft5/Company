using System;
using System.Collections.Generic;
using System.Text;
using Company.Models.Abstraction;

namespace Company.Models
{
    public class CompanyModel
    {
        public List<Employee> Employees { get; set; }

        public CompanyModel()
        {
            Employees = new List<Employee>();
        }
      
    }
}
