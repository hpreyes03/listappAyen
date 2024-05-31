using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public void OnGet(string? sortBy = null, string? sortAsc = "true")
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee() {
                    Name = "John Doe",
                    Department = "Engineering",
                    Salary = 75000 },

                new Employee() {
                    Name = "Jane Smith",
                    Department = "Marketing",
                    Salary = 65000 },

                new Employee() {
                    Name = "Alice Johnson",
                    Department = "HR",
                    Salary = 70000 },

                new Employee() {
                    Name = "Bob Brown",
                    Department = "Engineering",
                    Salary = 80000 },

                new Employee() {
                    Name = "Charlie Black",
                    Department = "Finance",
                    Salary = 90000 },

                new Employee() {
                    Name = "Daisy Green",
                    Department = "Marketing",
                    Salary = 60000 },

                new Employee() {
                    Name = "Edward White",
                    Department = "IT",
                    Salary = 95000 },

                new Employee() {
                    Name = "Fiona Gray",
                    Department = "Finance",
                    Salary = 87000 },

                new Employee() {
                    Name = "George Yellow",
                    Department = "HR",
                    Salary = 72000 },

                new Employee() {
                    Name = "Hannah Blue",
                    Department = "IT",
                    Salary = 94000 },

                new Employee() {
                    Name = "Ian Pink",
                    Department = "Engineering",
                    Salary = 78000 },

                new Employee() {
                    Name = "Jack Orange",
                    Department = "Marketing",
                    Salary = 63000 }
            };

            if (sortBy == null || sortAsc == null)
            {
                this.Employees = employees;
                return;
            }

            bool sortAscending = sortAsc!.ToLower() == "true";

            this.Employees = sortBy!.ToLower() switch
            {
                "name" => sortAscending ? employees.OrderBy(e => e.Name).ToList() : employees.OrderByDescending(e => e.Name).ToList(),
                "department" => sortAscending ? employees.OrderBy(e => e.Department).ToList() : employees.OrderByDescending(e => e.Department).ToList(),
                "salary" => sortAscending ? employees.OrderBy(e => e.Salary).ToList() : employees.OrderByDescending(e => e.Salary).ToList(),
                "joindate" => sortAscending ? employees.OrderBy(e => e.JoinDate).ToList() : employees.OrderByDescending(e => e.JoinDate).ToList(),
                _ => employees,
            };
        }

        public class Employee
        {
            public string Name { get; set; }
            public string Department { get; set; }
            public decimal Salary { get; set; }
            public DateTime JoinDate { get; set; }
        }
    }
}