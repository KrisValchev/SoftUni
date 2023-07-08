using System;
using System.Linq;
using System.Collections.Generic;

namespace _01.CompanyRoster
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> employees = new List<Employee>();
            List<string> departments = new List<string>();
            int numOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfLines; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                double salary = double.Parse(input[1]);
                string department = input[2];
                Employee employee = new Employee(name, salary, department);
                employees.Add(employee);
                if(!departments.Contains(department))
                {
                    departments.Add(department);
                }
            }
            double maxAverage = double.MinValue;
            string nameOfMaxAverageDepartment = "";
            for (int i = 0; i < departments.Count; i++)
            {
                double maxAverageForDepartment = employees.Where(x => x.Department == departments[i]).Select(x => x.Salary).Average();
                if(maxAverageForDepartment>=maxAverage)
                {
                    maxAverage = maxAverageForDepartment;
                    nameOfMaxAverageDepartment = departments[i];
                }
            }
            Console.WriteLine($"Highest Average Salary: {nameOfMaxAverageDepartment}");
            foreach (Employee employee in employees.Where(x=>x.Department==nameOfMaxAverageDepartment).OrderByDescending(x=>x.Salary))
            {
                Console.WriteLine(employee.ToString());
            }
        }
    }
    class Employee
    {
        public Employee(string name, double salary, string department)
        {
            Name = name;
            Salary = salary;
            Department = department;
            ;
        }
        public override string ToString()
        {
            return $"{Name} {Salary:f2}";
        }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }

    }
}
