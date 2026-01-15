using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
     class ManegerChild : EmployeeParent
    {
        public int TeamSize;

        public void DisplayManagerInfo()
        {
            DisplayBasicInfo();
            Console.WriteLine($"Team Size: {TeamSize}");
        }
    }
}
