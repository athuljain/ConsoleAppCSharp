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


using System;

namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Name = "John";
            p1.Age = 30;
            p1.Display();

        }
    }
}