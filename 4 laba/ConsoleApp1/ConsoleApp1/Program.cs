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

    static class StatisticOperation
    {
        public static int SumList(Set set)
        {
            return set.lst.Sum();
        }
        public static int DifferenceMax_Min(Set set)
        {
            return set.lst.Max() - set.lst.Min();
        }
        public static int LengthList(Set set)
        {
            return set.lst.Count();
        }
        public static string Shifrovanie(this string str,char c)
        {
            
            
            string result = "";
            for (int i=0;i<str.Length;i++) 
            {
                
                if (str[i]==c) 
                {
                    result = result + "*" + str[i+1] + str[i-1];
                    
                }
                result += str[i];
            }
            

            return result;
        }
        public static Set Regulize(this Set set)
        {
            set.lst.Sort();
            return set;
        }
    }

    class Program
    {
        public interface ISort<T> where T : struct 
        {
            void ReWrite();
            void Add(T i, int pos);
            void Remove(int pos);
        }


        class MyObj<T> : ISort<T> where T : struct
        {
            public int longOb { get; set; }
            T[] myarr;

            public MyObj(int i) 
            {
                longOb = i;
            }

            public MyObj(int i, T[] arr) 
            {
                longOb = i;
                myarr = new T[i];
                for (int j = 0; j < arr.Length; j++) 
                {
                    myarr[j] = arr[j];
                }
            }

            public void ReWrite()
            {
                Console.WriteLine("Type: {0}", typeof(T));
                Console.WriteLine("Array of objects: ");
                foreach (T t in myarr)
                    Console.Write("{0}\t", t);
                Console.WriteLine("\n");
            }
            public void Add(T i, int pos)
            {
                myarr[pos] = i;
            }
            public void Remove(int pos)
            {
                myarr[pos] = myarr[pos + 1];
            }


            public void write_to_file()
            {

                string writePath = @"D:\8tt.txt";

                using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                {
                    foreach (T t in myarr)
                        sw.WriteLine(t);
                }



            }
        }


        static void Main(string[] args)
        {
            //4 laba
            ///////////////////////////////////
            Console.WriteLine("4 LABA");
            Console.WriteLine("///////////////////////////////////1");
            Set setFirst = new Set();
            Set setSecond = new Set();
            Set setThird = new Set();

            setFirst.lst.Add(5);
            setFirst.lst.Add(4);
            setFirst.lst.Add(3);
            setFirst++;

            setSecond.lst.Add(6);
            setSecond.lst.Add(7);
            setSecond.lst.Add(8);
            setSecond.lst.Add(9);

            setThird.lst.Add(10);
            setThird.lst.Add(11);
            setThird.lst.Add(12);
            setThird.lst.Add(13);
            Set.Date.PrintHi();

            Console.WriteLine(setFirst.lst[3]); // out
            Console.WriteLine(setSecond.lst[2]); // out
            Console.WriteLine(setThird.lst[1]); // out

            Console.WriteLine("///////////////////////////////////2");
            ////////////////////////////////////

            Set setFourth = new Set();

            setFourth = setSecond + setThird;

            Console.WriteLine(setFourth.lst[2]); // out

            Console.WriteLine("///////////////////////////////////3");
            /////////////////////////////////////

            if (setSecond >= setThird)
            {
                Console.WriteLine("setSecond <= setThird");
            }
            else 
            {
                Console.WriteLine("false!!ERROR!!");
            }

            if (setFourth >= setThird)
            {
                Console.WriteLine("setFourth >= setThird");
            }
            else
            {
                Console.WriteLine("false!!ERROR!!");
            }

            Console.WriteLine("///////////////////////////////////4");
            ///////////////////////////////////

            int var;
            var = Set.GetSize(setThird);
            Console.WriteLine(var);

            Console.WriteLine("///////////////////////////////////5");
            ////////////////////////////////////

            int result = setFourth % 2;
            Console.WriteLine(result);

            Console.WriteLine("///////////////////////////////////7");
            //////////////////////////////////

            string str = "fourth laba efim ooptp mnproga";
            char c = 'o';
            Console.WriteLine(str + " - начальная");
            Console.WriteLine(str.Shifrovanie(c)+ " - итоговая");

            Console.WriteLine("///////////////////////////////////8");
            //////////////////////////////////
            setFourth.Print();

            Console.WriteLine("///////////////////////////////////9");
            //////////////////////////////////
            
            Set setn = new Set();
            Set setresult = new Set();
            setn.lst.Add(3);
            setn.lst.Add(2);
            setn.lst.Add(6);
            setn.lst.Add(1);

            setresult = setn.Regulize();
            Console.WriteLine(setresult.lst[2]);
            Console.WriteLine("///////////////////////////////////10");
            //////////////////////////////////
            Console.ReadLine();
            //StatisticOperation statistic = new StatisticOperation();


            //8 laba
            Console.WriteLine("8 LABA");
            Console.WriteLine("////////////////////////////// EXCEPTIONS /////////////////////////////////////");
            try
            {
                byte[] MyArrByte = new byte[5] { 4, 5, 18, 56, 8 };
                MyObj<byte> ByteConst = new MyObj<byte>(MyArrByte.Length, MyArrByte);
                ByteConst.ReWrite();
                ByteConst.Add(5, 66);
                ByteConst.ReWrite();
            }

            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("IndexOutOfRangeException");
            }
            finally
            {
                Console.WriteLine("block finally");
            }
            Console.ReadLine();

            Console.WriteLine("//////////////////////////////////// FUNCTIONS ////////////////////////////////////////////////");
            float[] MyArrFloat = new float[8] { 12.0f, 1f, 3.4f, 2.8f, -334.7f, -2f, 7.89f, 0 };
            MyObj<float> FloatConst = new MyObj<float>(MyArrFloat.Length, MyArrFloat);
            FloatConst.ReWrite();
            FloatConst.Remove(6);
            FloatConst.ReWrite();
            FloatConst.write_to_file();
            Console.ReadLine();
        }
    }
}

