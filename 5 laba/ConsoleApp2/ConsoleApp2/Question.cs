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
    sealed class Question : GraduateExam, IDescription
    {
        public string question;

        public Question(string _name, int _count, string _theme, int _levels, bool _check, string _question)
           : base(_name, _count, _theme, _levels, _check)
        {
            question = _question;
        }
        void IDescription.Display() 
        {
            Console.WriteLine("This is a qustion.");
        }
        public override string ToString()
        {
            string description = $"Object name: {nameof(Question)}\n" +
                $"Name: {name}\n" +
                $"Number of questions: {count}\n" +
                $"Theme: {theme}\n" +
                $"Number of levels: {levels}\n" +
                $"Graduate or not: {checkongraduate}\n" +
                $"Question: {question}\n";

            return description;
        }
    }
}
