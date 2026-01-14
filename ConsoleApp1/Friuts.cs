using System;
using System.Collections.Generic;
using System.Text;


//constructors 


namespace Program
{
    public class Friuts
    {
        public string Name;
        public string Color;
    

    public Friuts(string fName, string fColor)
        {
            Name = fName;
            Color = fColor;

        }

        public void DisplayFriuts()
        {
            Console.WriteLine($"Name  : {Name}");
            Console.WriteLine($"Color : {Color}");
            Console.WriteLine("-------------------------");
        }
    } }
