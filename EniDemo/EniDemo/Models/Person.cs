using System;
using System.Collections.Generic;
using System.Text;

namespace EniDemo.Models
{
    public class Person
    {
        public String Firstname {get; set;}

        public String Email { get; set; }
        public String Password { get; set; }

        public override string ToString()
        {
            return Firstname;
        }
    }
}
