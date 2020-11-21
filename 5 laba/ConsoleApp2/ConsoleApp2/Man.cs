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
    class Man
    {
        /*public string Name { get; set; }
        private int age;
        public int Age 
        {
            get { return age; }
            set 
            {
                if (value < 18)
                {
                    throw new PersonException("Persons under 18 no entry", value);
                }
                else { age = value; }
            }
        }

        public void mesg(int n) 
        {
            Debug.Assert(n == null, "aaaaaaaaaaaaaaaaaaaaaaaaaaaaa");


            Debug.Assert(n <= 10, "aarrrrrrrrrrrrrrrraaaaaaaaaaaaaa");

            Console.WriteLine("ERROR");
        }

        
        
    }
    class PersException : Exception
    {
        public PersException(string message)
            : base(message)
        { }
    }
    class PersonException : PersException
    {
        public int Value { get; }
        public PersonException(string message, int val)
            : base(message)
        {
            Value = val;
        }
    }
    public class Log
    {
        private static object sync = new object();
        public static void Write(Exception ex)
        {
            try
            {
                // Путь .\\Log
                string pathToLog = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log");
                if (!Directory.Exists(pathToLog))
                    Directory.CreateDirectory(pathToLog); // Создаем директорию, если нужно
                string filename = Path.Combine(pathToLog, string.Format("{0}_{1:dd.MM.yyy}.log",
                AppDomain.CurrentDomain.FriendlyName, DateTime.Now));
                string fullText = string.Format("[{0:dd.MM.yyy HH:mm:ss.fff}] [{1}.{2}()] {3}\r\n",
                DateTime.Now, ex.TargetSite.DeclaringType, ex.TargetSite.Name, ex.Message);
                lock (sync)
                {
                    File.AppendAllText(filename, fullText, Encoding.GetEncoding("Windows-1251"));
                }
            }
            catch
            {
                // Перехватываем все и ничего не делаем
            }
        }
        public void logW()
        {
            try
            {
                Console.WriteLine("log num is: ");
                int numlog = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("log num is " + numlog);
            }
            catch (Exception msg)
            {
                Write(msg);                      //запись в лог
                Console.WriteLine(msg.ToString()); //Вывод сообщения на экран, можно исключить              
                throw;
            }

        }*/
    }
}
