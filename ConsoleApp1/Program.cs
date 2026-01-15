//using System;

//namespace Program
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("enter your age");
//            int Age = Convert.ToInt32(Console.ReadLine());
//            if (Age >= 18)
//            {
//                Console.WriteLine("you are eligible to vote");
//            }
//            else
//            {
//                Console.WriteLine("you are not eligible to vote");
//            }
//        }
//    }
//}


//------------------------------------------------------------------


// method  

//----------------------------------------------------------------

//using System;

//namespace Program
//{
//    public class Program
//    {

//        public static int LargestNumber(int num1, int num2)
//        {
//            int result;
//            if(num1>num2){
//                result=num1;
//        }else{
//            result=num2;
//        } 
//            return result;
//        }


//        public static void Main(String[] args)
//        {
//    Console.WriteLine(LargestNumber(12, 23));
//        }
//    }
//}



//===============================================================

//namespace Program
//{
//    public class Program
//    {
//        public static int addNum(int x ,int y)
//        {
//            return x + y;
//        }

//        public static double addNum(double x, double y)
//        {
//            return x + y;
//        }
//        public static void Main(string[] args)
//        {
//            Console.WriteLine(addNum(5, 10));
//            Console.WriteLine(addNum(5.6, 10));
//        }
//    }
//}


//===============================================================


//using System;

//namespace Program
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            Person p1 = new Person();
//            p1.Name = "John";
//            p1.Age = 30;
//            p1.Display();


//            Employee emp1 = new Employee(); 
//            emp1.EmployeeName = "Alice";
//            emp1.EmployeeRole = "MERN Stack Developer";
//            emp1.EmployeeSalary = 50000;

//            emp1.DisplayEmployeeDetails();


//        }
//    }
//}


//using System;
//using System.Collections.Generic;
//namespace Program
//{
//    public class Program
//    {

//public static void Main(string[] args)
//{
//   Employee emp1 = new Employee();
//    Console.WriteLine("Enter Employee Name:");
//    emp1.EmployeeName = Console.ReadLine();
//    Console.WriteLine("Enter Employee Role:");
//    emp1.EmployeeRole = Console.ReadLine(); 
//    Console.WriteLine("Enter Employee Salary:");    
//    emp1.EmployeeSalary = Convert.ToInt32(Console.ReadLine());
//    emp1.DisplayEmployeeDetails();
//}


//=============================================



//        public static void Main(string[] args)
//        {
//            List<Employee> employees = new List<Employee>();
//            string choice;

//            do
//            {
//                Employee emp = new Employee();
//                Console.WriteLine("Enter Employee Name:");
//                emp.EmployeeName = Console.ReadLine();
//                Console.WriteLine("Enter Employee Role:");
//                emp.EmployeeRole = Console.ReadLine();
//                Console.WriteLine("Enter Employee Salary:");
//                emp.EmployeeSalary = Convert.ToInt32(Console.ReadLine());

//                employees.Add(emp);

//                Console.WriteLine(" All Employees Details:");
//                foreach (Employee e in employees)
//                {
//                    e.DisplayEmployee();
//                }
//                Console.WriteLine("do you want to add another employee ? (yes/no"));
//                choice = Console.ReadLine();
//            } while (choice.ToLower() == "yes");
//        }
//    }
//}


//========================================================

//constructor

//using System;

//namespace Program
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            Friuts frt = new Friuts("apple", "red");
//            frt.DisplayFriuts();
//        }
//    }
//}


//================================================




//inheritance

//    Inheritance in C# is an object-oriented programming concept 
//    where a child class (derived class) acquires the properties and methods of a parent class (base class). 
//    It helps in code reusability, method overriding, and 
//    establishing a parent–child relationship between classes.



//using System;

//namespace Program
//{
//    public class Program
//    {

//        public static void Main(string[] args)
//        {
//            DeveloperChild dev = new DeveloperChild();
//            dev.Id = 101;
//            dev.Name = "Athul";
//            dev.Salary = 50000;
//            dev.ProgrammingLanguage = "C#";

//            ManegerChild mgr = new ManegerChild();
//            mgr.TeamSize = 10;

//            dev.DisplayDeveloperInfo();
//            mgr.DisplayManagerInfo();



//            ManegerChild mgr1 = new ManegerChild();
//            mgr1.Id = 201;
//            mgr1.Name = "Rahul";
//            mgr1.Salary = 80000;
//            mgr1.TeamSize = 10;

//            dev.DisplayDeveloperInfo();
//            Console.WriteLine();
//            mgr1.DisplayManagerInfo();
//        }
//    }
//}



//===============================================================