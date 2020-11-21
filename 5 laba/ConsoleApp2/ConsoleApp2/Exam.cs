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
    class Exam : Test, IDescription
    {
        public int levels;
        public Exam(string _name, int _count, string _theme, int _levels)
           : base(_name, _count, _theme)
        {
            levels = _levels;
        }
        void IDescription.Display() 
        {
            Console.WriteLine("This is an exam.");
        }
        public override string ToString()
        {
            string description = $"Object name: {nameof(Exam)}\n" +
                $"Name: {name}\n" +
                $"Number of questions: {count}\n" +
                $"Theme: {theme}\n" +
                $"Number of levels: {levels}\n";

            return description;
        }
    }
}
