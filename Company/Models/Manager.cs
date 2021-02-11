using System;
using System.Collections.Generic;
using System.Text;
using Company.Models.Abstraction;

namespace Company.Models
{
    public class Manager : Employee
    {
        public override void Work()
        {
            Console.WriteLine("Collecting orders");
        }

        public Manager()
        {
            this.StartWorkDate = DateTime.UtcNow;
        }

        public void GiveTask(Employee employee)
        {
            Console.WriteLine($"Task was give to {employee.Name} {employee.LastName}");
        }


    }
}
