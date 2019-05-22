using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 학생관리_프로그램
{
    public class Major
    {
      string code;
      string name;
        public Major() {
            code = "";
            name = "";
        }
        public string Code
        {
            get { return code; }
            set { code = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
