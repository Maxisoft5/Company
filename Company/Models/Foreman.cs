using System;
using System.Collections.Generic;
using System.Text;
using Company.Models.Abstraction;

namespace Company.Models
{
    public class Foreman : Employee
    {
        public override void Work()
        {
            Console.WriteLine("Purchasing of goods");
        }

        public Foreman()
        {
            this.StartWorkDate = DateTime.UtcNow;
        }

        public void CheckEmployees()
        {
            Console.WriteLine("Checking employees");
        }
    }
}
