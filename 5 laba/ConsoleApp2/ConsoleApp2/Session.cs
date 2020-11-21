using System;
using System.CodeDom;
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
    public partial class Session : IDescription
    {
        
        public string month;
        public int zachet;
        public string ex;
        public Session[] mySessions { get; private set; } = new Session[10];


        void IDescription.Display()
        {
            Console.WriteLine("This is session");
        }

        public Session() 
        {
            month = "January";
            zachet = 4;
            ex = "Math";
        }

        public Session(string month, int zachet, string ex) 
        {
            this.month = month;
            this.zachet = zachet;
            this.ex = ex;
        }


        public override bool Equals(object obj)
        {
            return obj is Session;
        }

        public override int GetHashCode()
        {
            return zachet++;
        }

        public override string ToString()
        {
            string description = $"Object name: {nameof(Session)}\n" +
                $"Month: {month}\n" +
                $"Number of zachets: {zachet}\n" +
                $"Exam: {ex}\n";

            return description;
        }

        public void AddToSession(int index, string _month, int _zachet, string _ex) 
        {
            mySessions[index] = new Session("empty",0,"empty");
            mySessions[index].month = _month;
            mySessions[index].zachet = _zachet;
            mySessions[index].ex = _ex;
        }
        public void Show(int index) 
        {
            Console.WriteLine($"\nIndex: {index}\nMonth: {mySessions[index].month}\nNumber of zachets: {mySessions[index].zachet}\nExam: {mySessions[index].ex}");
        }
        public void Delete(int index) 
        {
            mySessions[index] = new Session("empty",0,"empty");
        }

    }
}
