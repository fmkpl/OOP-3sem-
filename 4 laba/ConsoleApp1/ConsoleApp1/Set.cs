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

namespace ConsoleApp1
{
    //++ - добавление случайного элемента к множесту
    //+ - объединение множеств;
    //<= - сравнение множеств;
    //неявный int () - мощность множества;
    //% - доступ к элементу в заданной позиции
    class Set
    {
        public List<int> lst { get; set; } = new List<int>();

        public Set() { }

        public static Set operator ++(Set set) 
        {
            set.lst.Add(252);
            return set;
        }


        public static Set operator +(Set set1, Set set2) 
        {
            Set set3 = new Set();

            set3.lst.Add(0);
            set3.lst.Add(0);
            set3.lst.Add(0);
            set3.lst.Add(0);
           

            for (int i = 0; i < set3.lst.Count; i++) 
            {
                set3.lst[i] = set1.lst[i] + set2.lst[i];
            }
            return set3;
        }

        public static bool operator >=(Set set1, Set set2)
        {
            bool check = false;
            if (set1.lst.Count == set2.lst.Count)
            {
                for (int i = 0; i < set2.lst.Count; i++)
                {
                    if (set1.lst[i] >= set2.lst[i])
                        check = true;
                }
            }
            return check;
        }

        public static bool operator <=(Set set1, Set set2) 
        {
            bool check = false;
            if (set1.lst.Count == set2.lst.Count)
            {
                for (int i = 0; i < set2.lst.Count; i++)
                {
                    if (set1.lst[i] <= set2.lst[i])
                        check = true;
                }
            }
            return check;
        }

        public static int GetSize(Set set) 
        {
            return set.lst.Count;
        }

        public static int operator %(Set set, int position) 
        {
            int pos;
            pos = set.lst[position];
            return pos;
        }

        public class Date
        {
            public static void PrintHi()
            {
                Console.WriteLine("09.11.2020");
            }
        }

        class Owner
        {
            public int id { get; set; }
            public static int counter { get; set; }
            public static string name { get; set; }
            public static string organization { get; set; }

            public Owner()
            {
                id = counter++;
            }
            static Owner()
            {
                counter = 0;
                name = "Efim";
                organization = "BSTU";
            }

            public void WriteOwner()
            {
                Console.WriteLine($"ID: {id}; Name: {name}; Organization: {organization};");
            }
        }

        /*public static Set Regulize(Set set)
        {
            set.lst.Sort();
            return set;
        }*/


        /*public static Set Shifr(Set set) 
        {
            for (int i = 0; i < set.lst.Count; i++) 
            {
                set.lst[i] *= set.lst[i];
            }
            return set;
        }*/

        public static implicit operator int(Set set) 
        {
            return set.lst.Count;
        }

        
            public void Print()
            {
                for (int i = 0; i < lst.Count; i++)
                {
                    Console.Write($"{lst[i]} ");
                }
                Console.WriteLine();
            }
        
    }
}
