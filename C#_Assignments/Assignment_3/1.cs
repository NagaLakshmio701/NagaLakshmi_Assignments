using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assingment3
{
    class person
    {
        public string FirstName;
        public string LastName;
        public string Email;
        public DateTime DOB;

        public person(string FirstName,string LastName,string Email,DateTime DOB)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.DOB = DOB;


            
        }


        public person(string FirstName, string LastName, string Email)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;


            
        }

        public person(string FirstName, string LastName, DateTime DOB)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.DOB = DOB;
           
        }

        public void  show()
        {
            Console.WriteLine($"FIRST NAME :{FirstName}");
            Console.WriteLine($"Last NAME :{LastName}");
            if (Email!=null)
            {
                Console.WriteLine($"EMAIL:{Email}");
            }

            if (DOB != default(DateTime))

            {
                Console.WriteLine($"DOB:{DOB}");

            }
        }
    }

    class Demo
    {
        static void Main()
        {
            person p = new person("lakshmi","singamsetty","nagalakshmisingamsetty9390@gmail.com",new DateTime(2003,3,23));
            p.show();
            Console.WriteLine();
            person p1 = new person("lakshmi", "singamsetty", "nagalakshmisingamsetty9390@gmail.com");
            p1.show();
            Console.WriteLine();
            person p3 = new person("lakshmi", "singamsetty", new DateTime(2003,3,23));
            p3.show();




        }
    }
}
