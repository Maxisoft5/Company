using System;
using System.Collections.Generic;
using System.Text;
using Company.Models.Abstraction;

namespace Company.Models
{
    public class Worker : Employee
    {
        public override void Work()
        {
            Console.WriteLine("Release product");
        }

        public Worker()
        {
            this.StartWorkDate = DateTime.UtcNow;
        }
    }
}
