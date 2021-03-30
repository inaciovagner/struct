using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @struct
{
    class Program
    {
       struct Student
        {
            public string Name;
            public string Grade;

            public class structure
            {
                static void Main(string[] args)
                {
                    Student st1;
                    st1.Name = Console.ReadLine();
                    st1.Grade = Console.ReadLine();
                    Console.WriteLine(st1.Name + " is from " + st1.Grade);
                }
            }
        }
    }
}
