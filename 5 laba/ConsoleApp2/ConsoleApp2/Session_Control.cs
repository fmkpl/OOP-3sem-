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
    class Session_Control : Session
    {
        int sum = 0;

        //task1
        public void GetSumOfZachets(Session[] obj) 
        {
            for (int i = 0; i < obj.Length; i++) 
            {
                sum += obj[i].zachet;
            }
            Console.WriteLine($"Sum of zachets = {sum}");
        }

        //task2
        public void GetNumberOfExamsByNumberOfZachet(Session[] obj) 
        {
            int count = 0;
            for (int i = 0; i < obj.Length; i++) 
            {
                if (obj[i].zachet == 5) { count++; }
            }
            Console.WriteLine($"Number of exmas with 5 zachets = {count}");
        }
    }
}
