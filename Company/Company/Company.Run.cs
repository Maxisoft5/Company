using System;
using System.Collections.Generic;
using Company.Extensions;
using Company.Models;
using Company.Models.Abstraction;
using static System.Console;

namespace Company
{
    class Run
    {
        static void Main(string[] args)
        {
            var employees = new List<Employee>();

            var manager = new Manager()
            {
                Name = "Maxim",
                LastName = "Grynyuk",
                MiddleName = "Alexandrovich"
            };

            var foreman = new Foreman()
            {
                Name = "Alexandr",
                LastName = "Ivanov",
                MiddleName = "Segeyevich"
            };

            var worker = new Worker()
            {
                Name = "Alexandr",
                LastName = "Ivanov",
                MiddleName = "Danilovich"
            };


            manager.GiveTask(foreman);
            foreman.CheckEmployees();
            worker.Work();
            manager.Work();
            foreman.Work();

            employees += manager;
            employees += foreman;
            employees += worker;

            if (employees.IsExists(manager)) WriteLine("Exists");

            employees.PrintEmployees();

            if (employees - manager) WriteLine("manager deleted");
            if (employees - manager) WriteLine("Deleted");

            if (employees - foreman) WriteLine("foreman deleted");
            if (employees - worker) WriteLine("worker deleted");

            ReadLine();
        }
    }
}
