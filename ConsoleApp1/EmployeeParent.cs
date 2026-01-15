using System;
using System.Collections.Generic;
using System.Text;

namespace Program

{
    public class EmployeeParent
    {
        public int Id;
        public string Name;
        public double Salary;


        public void DisplayBasicInfo()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Salary: {Salary}");
        }
    }
}
