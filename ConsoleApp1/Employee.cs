namespace Program
{
    public class Employee
    {
        public string EmployeeName;
        public string EmployeeRole;
        public int EmployeeSalary;

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("Employee Name: " + EmployeeName);
            Console.WriteLine("Employee Role: " + EmployeeRole);
            Console.WriteLine("Employee Salary: " + EmployeeSalary);
        }
    }
}