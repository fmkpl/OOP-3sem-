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
   
    public interface IDescription 
    {
        void Display();
    }

    public interface ISession 
    {
        void Info();
    }


    public interface ICloneable
    {
        bool Clone();
    }

    abstract public class BaseClone
    {
        public abstract bool Clone();
    }

    class userClass : BaseClone, ICloneable
    {
        public override bool Clone()
        {
            Console.WriteLine("using abstract class to make functions");
            return true;
        }

        /*void IDescription.Display()
        {
            Console.WriteLine("this is iDescription function of my user class");
        }*/
    }





    public class Printer
    {
        public void IAmPrinting(IDescription obj)
        {
            obj.Display();
        }
    }




    public partial struct Student
    {
        public string name { get; set; }
        public int age { get; set; }
        public Student(string name, int age) 
        {
            this.name = name;
            this.age = age;
        }
        public void DisplayInfo() 
        {
            Console.WriteLine($"Name: {name} Age:{age}");
        }
    }
    class Program
    {
        enum Week
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thirsday,
            Friday,
            Saturday,
            Sunday
        }

        static void GetNumberOfTheDay(Week op) 
        {
            string result = "";

            switch (op) 
            {
                case Week.Monday:
                    result = "Monday is the 1st day of the week.";
                    break;
                case Week.Tuesday:
                    result = "Tueday is the 2nd day of the week.";
                    break;
                case Week.Wednesday:
                    result = "Wednesday is the 3rd day of the week.";
                    break;
                case Week.Thirsday:
                    result = "Thursday is the 4th day of the week.";
                    break;
                case Week.Friday:
                    result = "Friday is the 5th day of the week.";
                    break;
                case Week.Saturday:
                    result = "Saturday is the 6th day of the week.";
                    break;
                case Week.Sunday:
                    result = "Sunday is the 7th day of the week.";
                    break;
            }
            Console.WriteLine(result);
        }
        private static void Main(string[] args)
        {
            //7 laba

            Console.WriteLine("7 LABA");
            Console.WriteLine("///////////////////////////////////// EXCEPTIONS ///////////////////////////////////////////////////////");

            try
            {
                Testing example1 = new Testing("Test234574573451241234124215", 10);
                Testing example2 = new Testing("Test26", 123);
            }
            catch (InvalidNumberOfQuestionsException ex)
            {
                Logger.Log(ex, true, true);
            }
            catch (InvalidTestingNameException ex)
            {
                Logger.Log(ex, true, true);
            }
            finally
            {
                Console.WriteLine("-------------------------------------");
            }

            
            // different exceptions

            try
            {
                int a = 13;
                int b = 0;
                if (b == 0) throw new DivideByZeroException("Делить на ноль незя");
                else a /= b;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("\n\tОшибка");
                Console.WriteLine($"Сообщение: {ex.Message}");
                Console.WriteLine("-> Место возникновения: {0}", ex.TargetSite);
            }
            finally
            {
                Console.WriteLine("-------------------------------------");
            }

            int[] arr = { 1, 2, 3, 4, 5 }; // массив размером 5
            try
            {
                int length = 10;
                if (length > arr.Length) throw new IndexOutOfRangeException("С таким length будет выход за массив arr!");
                for (int i = 0; i < length; i++)
                    arr[i] += arr[i];
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("\n\tОшибка");
                Console.WriteLine($"Сообщение: {ex.Message}");
                Console.WriteLine("-> Место возникновения: {0}", ex.TargetSite);
            }
            finally
            {
                Console.WriteLine("-------------------------------------");
            }

            Debug.Assert(0 == 0, "Check");


            Console.WriteLine();
            Console.WriteLine("////////////////////////////");
            Console.WriteLine("////////////////////////////");
            Console.WriteLine("////////////////////////////");
            Console.WriteLine();
            Console.ReadKey();
            //6 laba
            // structs and enums
            Console.WriteLine("6 LABA");
            Console.WriteLine("////////////////////////////// Structs and Enums /////////////////////////////////////");
            
            Student tom = new Student("Tom",18);
            tom.DisplayInfo();
            Student bob = new Student();
            bob.DisplayInfo();
            Student person = new Student { name = "Lily", age = 22 };
            person.DisplayInfo();
            Week op;
            op = Week.Sunday;
            Console.WriteLine((int)op);
            GetNumberOfTheDay(op);


            //class-Container
            Console.WriteLine("////////////////////// Class-Container ///////////////////////");
            Session[] sesControl = new Session[9];
            sesControl[0] = new Session("January",4,"Math");
            sesControl[1] = new Session("January", 5, "OOTP");
            sesControl[2] = new Session("January", 4, "Philosophy");
            sesControl[3] = new Session("February", 5, "OOTP");
            sesControl[4] = new Session("February", 5, "Psyhology");
            sesControl[5] = new Session("February", 4, "Russian");
            sesControl[6] = new Session("June", 3, "CSaN");
            sesControl[7] = new Session("June", 4, "English");
            sesControl[8] = new Session("June", 5, "EVM");

            Session ses = new Session();
            ses.AddToSession(0,"January",4,"Math");
            ses.Show(0);

            ses.AddToSession(1, "January", 5, "Web-design");
            ses.Show(1);
            ses.Delete(0);
            ses.Show(0);

            //class-Controller
            Console.WriteLine("////////////////////// Class-Controller ///////////////////////");
            Session_Control session_Control = new Session_Control();
            //task1
            session_Control.GetSumOfZachets(sesControl);
            //task2
            session_Control.GetNumberOfExamsByNumberOfZachet(sesControl);

            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("////////////////////////////");
            Console.WriteLine("////////////////////////////");
            Console.WriteLine("////////////////////////////");
            Console.WriteLine();
            ///////////////////////////////////////////////
            ///////////////////////////////////////////////
            ///////////////////////////////////////////////
            ///5 laba
            Console.WriteLine("5 LABA");
            //string str = "13.11.2020";
            
            Console.WriteLine("Hello, Efim!");
            Console.ReadLine();
            IDescription[] array = new IDescription[5]; 
            array[0] = new Testing("Test01",15);
            array[1] = new Test("Test02", 12,"IT");
            array[2] = new Exam("Test03", 12, "Biology",3);
            array[3] = new GraduateExam("Test04", 14, "Russian language",3,true);
            array[4] = new Question("Test05", 15, "English", 2, false,"Name some nouns in English.");

            Console.WriteLine("/////////////////////////////////////////////////////////////");
            Console.Write(array[0] is Testing);
            Console.WriteLine("/////////////////////////////////////////////////////////////");
            Console.WriteLine(array[0].ToString());
            Console.WriteLine("/////////////////////////////////////////////////////////////");
            Console.WriteLine(array[1].ToString());
            Console.WriteLine("/////////////////////////////////////////////////////////////");
            Console.WriteLine(array[2].ToString());
            Console.WriteLine("/////////////////////////////////////////////////////////////");
            Console.WriteLine(array[3].ToString());
            Console.WriteLine("/////////////////////////////////////////////////////////////");
            Console.WriteLine(array[4].ToString());
            Console.WriteLine("/////////////////////////////////////////////////////////////");

            Printer p = new Printer();
            for (int i = 0; i < 5; i++)
            {
                p.IAmPrinting(array[i]);
            }
            Console.WriteLine("/////////////////////////////////////////////////////////////");
            userClass ucl = new userClass();
            Console.WriteLine(ucl.ToString());
            Console.WriteLine(ucl.Clone());
            Console.ReadLine();
            
            //BaseClone baseClone = new BaseClone();
        }
    }  
}
