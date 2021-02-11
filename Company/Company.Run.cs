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
            var company = new CompanyModel();
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

            company.Employees.Add(manager);
            company.Employees.Add(foreman);
            company.Employees.Add(worker);

            var managers = company.Employees.GetAllEmployees<Manager>();
            var foremans = company.Employees.GetAllEmployees<Foreman>();
            var workers = company.Employees.GetAllEmployees<Worker>();

            int managersCount = company.Employees.GetEmployeesCount<Manager>();
            int foremansCount = company.Employees.GetEmployeesCount<Foreman>();
            int workersCount = company.Employees.GetEmployeesCount<Worker>();

            manager.GiveTask(foreman);
            foreman.CheckEmployees();
            worker.Work();
            manager.Work();
            foreman.Work();

            company.Employees += manager;
            company.Employees += foreman;
            company.Employees += worker;

            if (company.Employees.IsExists(manager)) WriteLine("Exists");
            if (company.Employees.IsExists(worker)) WriteLine("Exists");
            if (company.Employees.IsExists(foreman)) WriteLine("Exists");

            managers.PrintEmployees();
            WriteLine($" Managers count : {managersCount}");
            foremans.PrintEmployees();
            WriteLine($" Foremans count : {foremansCount}");
            workers.PrintEmployees();
            WriteLine($" Workers count : {workersCount}");

            if (company.Employees - manager) WriteLine("manager deleted");
            if (company.Employees - manager) WriteLine("Deleted");
            if (company.Employees - foreman) WriteLine("foreman deleted");
            if (company.Employees - worker) WriteLine("worker deleted");

            ReadLine();
        }
    }
}
