using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace listappAyen.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public List<Employee> Employees { get; set; }

        public void OnGet()
        {
            Employees = new List<Employee>
    {
        new Employee {
            Name = "John Doe",
            Department = "Sales",
            Salary = 50000,
            JoinDate = new DateTime(2020, 1, 15) },

        new Employee {
            Name = "Jane Smith",
            Department = "Marketing",
            Salary = 60000,
            JoinDate = new DateTime(2019, 5, 20) },

        new Employee {
            Name = "David Johnson",
            Department = "Finance",
            Salary = 70000,
            JoinDate = new DateTime(2018, 8, 10) },

        new Employee {
            Name = "Emily Brown",
            Department = "Human Resources",
            Salary = 55000,
            JoinDate = new DateTime(2017, 10, 5) },

        new Employee {
            Name = "Michael Wilson",
            Department = "IT",
            Salary = 75000,
            JoinDate = new DateTime(2016, 3, 25) },

        new Employee {
            Name = "Jennifer Davis",
            Department = "Operations",
            Salary = 65000,
            JoinDate = new DateTime(2015, 7, 12) },

        new Employee {
            Name = "Christopher Martinez",
            Department = "Engineering",
            Salary = 80000,
            JoinDate = new DateTime(2014, 11, 30) },

        new Employee {
            Name = "Jessica Taylor",
            Department = "Customer Support",
            Salary = 48000,
            JoinDate = new DateTime(2013, 9, 18) },

        new Employee {
            Name = "Matthew Anderson",
            Department = "Research and Development",
            Salary = 72000,
            JoinDate = new DateTime(2012, 6, 8) },

        new Employee {
            Name = "Amanda White",
            Department = "Quality Assurance",
            Salary = 60000,
            JoinDate = new DateTime(2011, 4, 3) },

        new Employee {
            Name = "Daniel Garcia",
            Department = "Legal",
            Salary = 85000,
            JoinDate = new DateTime(2010, 2, 28) },

        new Employee {
            Name = "Sarah Thompson",
            Department = "Public Relations",
            Salary = 57000,
            JoinDate = new DateTime(2009, 12, 20) },


        new Employee {
            Name = "Kevin Hernandez",
            Department = "Logistics",
            Salary = 68000,
            JoinDate = new DateTime(2008, 8, 15) },

        new Employee {
            Name = "Melissa Walker",
            Department = "Training",
            Salary = 50000,
            JoinDate = new DateTime(2007, 6, 10) },

        new Employee {
            Name = "Erica Lewis",
            Department = "Administration",
            Salary = 59000,
            JoinDate = new DateTime(2006, 4, 5) }
    };
        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
        public DateTime JoinDate { get; set; }
    }
}