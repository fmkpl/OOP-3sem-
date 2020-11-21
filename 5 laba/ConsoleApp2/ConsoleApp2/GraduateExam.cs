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
    class GraduateExam : Exam, IDescription
    {
        public bool checkongraduate;
        public GraduateExam(string _name, int _count, string _theme, int _levels, bool _check)
           : base(_name, _count, _theme, _levels)
        {
            checkongraduate = _check;
        }
        void IDescription.Display() 
        {
            Console.WriteLine("This is a graduate exam.");
        }
        public override string ToString()
        {
            string description = $"Object name: {nameof(GraduateExam)}\n" +
                $"Name: {name}\n" +
                $"Number of questions: {count}\n" +
                $"Theme: {theme}\n" +
                $"Number of levels: {levels}\n"+
                $"Graduate or not: {checkongraduate}\n";

            return description;
        }
    }
}
