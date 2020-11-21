using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Diagnostics;
using System.IO;

namespace ConsoleApp2
{
    class Test : Testing, IDescription
    {
        public string theme { get; set; }
        public Test(string _name, int _count, string _theme)
            : base(_name,_count)
        {
            theme = _theme;
        }
        void IDescription.Display()
        {
            Console.WriteLine("This is a test.");
        }
        public override string ToString()
        {
            string description = $"Object name: {nameof(Test)}\n" +
                $"Name: {name}\n" + 
                $"Number of questions: {count}\n" +
                $"Theme: {theme}\n";

            return description;
        }
    }
    
}
