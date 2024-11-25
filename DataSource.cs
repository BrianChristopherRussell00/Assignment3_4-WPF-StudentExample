using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_4_WPF
{
    public class DataSource
    {
        public static List<Student> Students;


        public static List<Student> CreateData()
        {
            Students = new List<Student>()
            { new Student() { StudentId =1, FirstName="Brian", LastName="Russell", Address="123 Nottrue St."},
             new Student() { StudentId =2, FirstName="Joe", LastName="Joester", Address="124 Nottrue Ave." },
             new Student() { StudentId =1, FirstName="Jane", LastName="Janeison", Address="125 Nottrue Blvd." }
            };
            return Students;
        }
    }
}
