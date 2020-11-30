using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Diagnostics;
using System.IO;

namespace ConsoleApp1
{
    class Software
    {
        private string purpose; //secutity, work, game, study
        private string name;
        private int size; //in MB
        private bool status;

        public static int maxSize = 5000; //MAXIMUM OF SIZE --------------------------------

        public Software(string _purpose, string _name, int _size, bool _status) 
        {
            purpose = _purpose;
            name = _name;
            size = _size;
            status = _status;
        }

        public string Purpose 
        {
            get { return purpose; }
            set { purpose = value; }
        }
        public string Name 
        {
            get { return name; }
            set { name = value; }
        }
        public int Size 
        {
            set
            {
                if (size > maxSize)
                {
                    size = maxSize - 1;
                    Console.WriteLine($"Size is maximum. New size: {size}");
                }
                else
                {
                    size = value;
                }
            }
            get { return size; }
        }
        public bool Status 
        {
            get { return status; }
            set { status = value; }
        }

        public void TurnOn() 
        {
            if (!status)
            {
                status = true;
                Console.WriteLine("Software is on.");
            }
            else 
            {
                throw new Exception("Software is already on.");
            }
        }
        public void TurnOff() 
        {
            if (status)
            {
                status = false;
                Console.WriteLine("Software is off.");
            }
            else 
            {
                throw new Exception("Software is already off.");
            }
        }
        public void PlusSize(int newSize)
        {
            if (size + newSize < maxSize)
            {
                size += newSize;
                Console.WriteLine($"New size: {size}");
            }
            else 
            {
                size = maxSize - 1;
                Console.WriteLine($"Size is maximum. New size: {size}");
            }
        }
    }
}
