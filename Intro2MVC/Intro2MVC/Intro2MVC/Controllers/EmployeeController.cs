using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Intro2MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting.Internal;

namespace Intro2MVC.Controllers
{
    public class EmployeeController : Controller
    {
        //private readonly HostingEnvironment hostingEnvironment;

        //public EmployeeController(HostingEnvironment hostingEnvironment)
        //{
        //    this.hostingEnvironment = hostingEnvironment;
        //}

        //Get: Employee/Index
        public IActionResult Index()
        {
            return View();
        }

        //Get: Employee/Create
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Save(string firstName, string lastName, int age, string nationalInsuranceNo, string gender, string address, double monthlySalary)
        {
            // Declare a file stream reference
            FileStream fileStreamEmployee = null;
            // Serialize employee's data to the stream
            BinaryFormatter binaryFormatterEmp = new BinaryFormatter();
            HashSet<Employee> employeeCollection = new HashSet<Employee>();
            //var employeeRecordDir = @"EmployeeFile/employee.txt";
            //var webroot = this.hostingEnvironment.ContentRootPath;
            //var path = Path.Combine(webroot, employeeRecordDir);
            var path = @"wwwroot/EmployeeFile/employee.txt";

            if (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName) && !string.IsNullOrEmpty(nationalInsuranceNo))
            {
                if (System.IO.File.Exists(path))
                {
                    using (fileStreamEmployee = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
                    {
                        employeeCollection = (HashSet<Employee>)binaryFormatterEmp.Deserialize(fileStreamEmployee);
                        fileStreamEmployee.Close(); // it is not necessary because it is in using 
                    }
                }

                // Create the employee object using the data from the view
                Employee objEmployee = new Employee
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = Convert.ToInt32(age),
                    NationalInsuranceNumber = nationalInsuranceNo,
                    Gender = gender,
                    Address = address,
                    MonthlySalary = Convert.ToInt64(monthlySalary)
                };

                // Add Employee object to list of employees
                employeeCollection.Add(objEmployee);

                // Serialize and save to file
                using (fileStreamEmployee = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Write))
                {
                    binaryFormatterEmp.Serialize(fileStreamEmployee, employeeCollection);
                    fileStreamEmployee.Close(); // it is not necessary because it is in using 
                }

                // if employee list has been serialized and saved, return to the create view/form
                return RedirectToAction("Create");
            }
            return View();
        }
    }
}
