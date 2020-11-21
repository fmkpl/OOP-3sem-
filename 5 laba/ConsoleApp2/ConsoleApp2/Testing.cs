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
    //-----------------My exceptions------------------------------------------------------------------------
    class InvalidNumberOfQuestionsException : ArgumentException
    {
        public int Value { get; }

        public InvalidNumberOfQuestionsException(string message, int count)
            : base(message)
        {
            Value = count;
            Data.Add("Время возникновения", DateTime.Now);
        }
    }

    class InvalidTestingNameException : ArgumentException
    {
        public string Value { get; }
        public InvalidTestingNameException(string message, string name)
            : base(message)
        {
            Value = name;
            Data.Add("Время возникновения", DateTime.Now);
        }
    }

    class InvalidArmyNameException : InvalidTestingNameException
    {
        public InvalidArmyNameException(string message, string name)
            : base(message, name) 
        {

        }
    }

    //-----------------My exceptions----------------------------------------------------------------------



    class Testing : IDescription
    {
        private int hash = 0;
        public string name;
        public int count;
        void IDescription.Display()
        {
            Console.WriteLine("This is a testing.");
        }
        public Testing() 
        {
            name = "TestX";
            count = 10;
        }
        public Testing(string _name, int _count)
        {
            if (_name.Length > 20 && _name.Length < 3)
            {
                throw new InvalidTestingNameException("Name of testing can not be more than 20 symbols!", _name);
            }
            else
            { 
                name = _name;
            }
            if (_count < 0 && _count > 20)
            {
                throw new InvalidNumberOfQuestionsException("Number of questions can not be more then 20 and less then 0!", _count);
            } 
            else 
            {
                count = _count;
            }
        }
        public void Date(string line) 
        {
            Console.WriteLine("Date: " + line);
        }
        public override bool Equals(object obj)
        {
            return obj is Testing;
        }

        public override int GetHashCode()
        {
            return hash++;
        }

        public override string ToString()
        {
            string description = $"Object name: {nameof(Testing)}\n" +
                $"Name of testing: {name}\n" + 
                $"Number of questions: {count}\n";

            return description;
        }
    }
}
