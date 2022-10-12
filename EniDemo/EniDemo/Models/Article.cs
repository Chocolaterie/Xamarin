using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace EniDemo.Models
{
    public class Article
    {
        public String Title {get; set; }

        public override string ToString()
        {
            return Title;
        }
    }
}
