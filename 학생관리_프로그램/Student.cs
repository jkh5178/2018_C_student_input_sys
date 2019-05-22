using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 학생관리_프로그램
{
   public class Student
    {
        int age;
        double grade = 0;
        string name = "", code = "", g_string, major;
        public Student()
        {
            age = 0;
            grade = 0;
            name = ""; code = ""; ; g_string = ""; major = "";
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public double Grade
        {
            get { return grade; }
            set { grade = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Code
        {
            get { return code; }
            set { code = value; }
        }
      
        public string G_string
        {
            get { return g_string; }
            set { g_string = value; }
        }
        public string Major
        {
            get { return major; }
            set { major = value; }
        }

    }
}
