using System;
using System.Collections.Generic;
using System.Text;

namespace GetSet
{
    class Student
    {
        public string Name { set; get; }
        private string gender;


        public Student(string Cname,string Cgender ){
            Name = Cname;
            Gender = Cgender;
        }
        public string Gender
        {
            get { return gender; }
            set { if(value== "Male" || value=="Female"|| value=="Other" )

                {
                    gender = value;
                }
                else
                {
                    throw new ArgumentException("invalid");
                }
            }
        }
    }

}
