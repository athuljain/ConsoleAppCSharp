using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
     class DeveloperChild : EmployeeParent
    {
        public string ProgrammingLanguage;
        public void DisplayDeveloperInfo()
        {
            DisplayBasicInfo();
            Console.WriteLine($"Language: {ProgrammingLanguage}");
        }
    }
}
