using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationApp
{
    class StudentInfo
    {
        public string regNumber;
        public string firstName;
        public string lastname;

        public string GetFullName()
        {
            return firstName + lastname;
        }

        public string GetCode(string code)
        {
            return regNumber + code;
        }
    }
}
